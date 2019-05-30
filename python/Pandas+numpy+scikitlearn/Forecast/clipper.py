from clipper_admin import ClipperConnection, KubernetesContainerManager, DockerContainerManager
from clipper_admin.deployers import python as python_deployer
import pandas as pd
import joblib
import sys
import signal

# Stop Clipper on Ctrl-C
def signal_handler(signal, frame):
    print("Stopping Clipper...")
    clipper_conn = ClipperConnection(KubernetesContainerManager(useInternalIP=True))
    clipper_conn.stop_all()
    sys.exit(0)

if __name__ == '__main__':
    signal.signal(signal.SIGINT, signal_handler)
    clipper_conn = ClipperConnection(KubernetesContainerManager(useInternalIP=True) )
    try:
        clipper_conn.connect()
    except:
        clipper_conn.start_clipper()
    try:
        clipper_conn.register_application(name='forecastservice2', input_type='doubles', default_output='-1.0', slo_micros=1000000000)
    except:
        pass

    def forecast_for_dataset(input_data):
        """Предсказание меток для полученного набора"""
        loaded_model = joblib.load("model.sav")
        pred_1 = loaded_model.predict(input_data)
        return pred_1


    try:
        python_deployer.deploy_python_closure(clipper_conn, name='forecast-model2', version=1, input_type='doubles', func=forecast_for_dataset, pkgs_to_install=['pandas==0.24.2','joblib==0.13.2','scikit-learn==0.21.1'], registry='shersticklock')
    except:
        pass

    try:
        clipper_conn.link_model_to_app(app_name='forecastservice2', model_name='forecast-model2')
    except:
        pass

