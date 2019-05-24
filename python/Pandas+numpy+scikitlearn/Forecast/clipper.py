from clipper_admin import ClipperConnection, DockerContainerManager
from clipper_admin.deployers import python as python_deployer
import pandas as pd
import joblib
clipper_conn = ClipperConnection(DockerContainerManager())
clipper_conn.start_clipper()
clipper_conn.register_application(name='fcservice', input_type='doubles', default_output='-1.0', slo_micros=100000)
clipper_conn.get_all_apps()

# def load_model():
#     loaded_model = joblib.load("model.sav")
#     return loaded_model
# def forecast_for_dataset(input):
#     """Предсказание меток для полученного набора"""
#     loaded_model = load_model()
#     data = pd.DataFrame(input)
#     df = data.drop(data.columns[[0,1]], axis='columns')
#     pred_1 = loaded_model.predict(df)
#     df_2 = pd.DataFrame(pred_1, columns=['forecast'])
#     return df_2.to_json()

def feature_sum(xs):
    return [str(sum(x)) for x in xs]

python_deployer.deploy_python_closure(clipper_conn, name='forecast-model', version=1, input_type='doubles', func=feature_sum)
#python_deployer.deploy_python_closure(clipper_conn, name='forecast-model', version=1, input_type='doubles',
#  func=forecast_for_dataset, pkgs_to_install=['pandas==0.24.2','joblib==0.13.2','scikit-learn==0.21.1'])
clipper_conn.link_model_to_app(app_name='fcservice', model_name='forecast-model')