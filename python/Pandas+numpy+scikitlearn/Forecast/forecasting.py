import pandas as pd
import joblib
import logging
logging.basicConfig(format = u'%(filename)s[LINE:%(lineno)d]# %(levelname)-8s [%(asctime)s]  %(message)s', level = logging.DEBUG, filename='log.log')
class Forecasting():
    def __init__(self, file_path, model_path):
        self.path = file_path
        self.model = model_path

    def forecast_for_dataset(self):
        """Предсказание меток для полученного набора"""
        logging.info(u'forecast for dataset start')
        data = pd.DataFrame(self.path)
        df = data.drop(data.columns[[0,1]], axis='columns')
        loaded_model = joblib.load(self.model)
        pred_1 = loaded_model.predict(df)
        df_2 = pd.DataFrame(pred_1, columns=['forecast'])
        logging.info(u'forecast for dataset end')
        return df_2.to_json()