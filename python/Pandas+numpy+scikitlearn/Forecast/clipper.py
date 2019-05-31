from clipper_admin import ClipperConnection, KubernetesContainerManager, DockerContainerManager
from clipper_admin.deployers import python as python_deployer
import joblib
import sys
import signal
import logging
logging.basicConfig(format = u'%(filename)s[LINE:%(lineno)d]# %(levelname)-8s [%(asctime)s]  %(message)s', level = logging.DEBUG,filename='log.log')

def signal_handler(signal, frame):
    """Stop Clipper on Ctrl-C"""
    logging.info(u'Stopping Clipper...')
    clipper_conn = ClipperConnection(KubernetesContainerManager(useInternalIP=True))
    clipper_conn.stop_all()
    sys.exit(0)

if __name__ == '__main__':
    signal.signal(signal.SIGINT, signal_handler)
    clipper_conn = ClipperConnection(KubernetesContainerManager(useInternalIP=True) )
    try:
        clipper_conn.connect()
    except:
        logging.warning(u'Clipper is not running')
        clipper_conn.start_clipper()
    try:
        clipper_conn.register_application(name='forecastservice3', input_type='doubles', default_output='-1.0', slo_micros=1000000000)
    except:
        logging.warning(u'Application forecastservice3 already exists')

    def forecast_for_dataset(input_data):
        """Предсказание меток для полученного набора"""
        loaded_model = joblib.load("/model/model.sav")
        pred_1 = loaded_model.predict(input_data)
        return [str(pred) for pred in pred_1]


    try:
        python_deployer.deploy_python_closure(clipper_conn, name='forecast-model3', version=1, input_type='doubles', func=forecast_for_dataset, pkgs_to_install=['pandas==0.24.2','joblib==0.13.2','scikit-learn==0.21.1'], registry='shersticklock')
    except:
        logging.warning(u'Model forecast-model3 already exists')

    try:
        clipper_conn.build_and_deploy_model(name='fc',version=1,input_type='doubles',model_data_path='model.sav',base_image='shersticklock/forecast-model3:1',container_registry='shersticklock')
    except:
        logging.warning(u'Model fc already exists')

    try:
        clipper_conn.link_model_to_app(app_name='forecastservice3', model_name='fc')
    except:
        logging.warning(u'Model fc and app forcastservice3 are already linked')

