from pandas import read_csv
import psycopg2
import numpy as np
import pandas as pd
import joblib
import sqlalchemy_connect as sc
from sqlalchemy_connect import Source, Forecast


class Forecasting():
    def __init__(self, file_path, model_path, con_db):
        self.path = file_path
        self.model = model_path
        self.con = con_db

    def conn_to_db(self):
        """Подключение к базе"""
        conn = sc.get_connection(self.con)
        return conn

    def load_data_from_csv(self):
        """Загрузка данных из csv в базу SOURCE"""
        data = pd.read_csv(self.path)
        con = self.conn_to_db()
        data.to_sql(name="SOURCE", con=con, if_exists='replace')

    def forecast_for_dataset(self):
        """Предсказание меток для полученного набора"""
        data = pd.DataFrame(self.path)
        df = data.drop(data.columns[[0,1]], axis='columns')
        loaded_model = joblib.load(self.model)
        pred_1 = loaded_model.predict(df)
        df_2 = pd.DataFrame(pred_1, columns=['forecast'])
        return df_2.to_json()

    def read_data_from_db(self):
        """Чтение данных из БД"""
        source = sc.Source()
        session = source.create_session()
        data = pd.read_sql(session.query(Source).statement,session.bind)
        session.close()
        return data.to_json()

    def forecast(self, data):
        """Предсказание меток по уже обученной модели"""
        loaded_model = joblib.load(self.model)
        pred_1 = loaded_model.predict(data)
        forecast = sc.Forecast()
        forecast.save_all_to_db(pred_1)

if __name__ == '__main__':
    pass
