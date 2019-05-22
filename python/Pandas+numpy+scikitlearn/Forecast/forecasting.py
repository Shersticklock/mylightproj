import pandas as pd
import joblib
class Forecasting():
    def __init__(self, file_path, model_path):
        self.path = file_path
        self.model = model_path

    def forecast_for_dataset(self):
        """Предсказание меток для полученного набора"""
        data = pd.DataFrame(self.path)
        df = data.drop(data.columns[[0]], axis='columns')
        loaded_model = joblib.load(self.model)
        pred_1 = loaded_model.predict(df)
        df_2 = pd.DataFrame(pred_1, columns=['forecast'])
        return df_2.to_json()