from pandas import read_json
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
        #data = read_json(self.path)
        data = pd.DataFrame(self.path)
        print(data)
        con = self.conn_to_db()
        data.to_sql(name="SOURCE", con=con, if_exists='replace')

    def read_data_from_db(self):
        """Чтение данных из БД"""
        source = sc.Source()
        session = source.create_session()
        data = pd.read_sql(session.query(Source).statement,session.bind)
        session.close()
        return data

    def forecast(self, data):
        """Предсказание меток по уже обученной модели"""
        loaded_model = joblib.load(self.model)
        pred_1 = loaded_model.predict(data)
        forecast = sc.Forecast()
        forecast.save_all_to_db(pred_1)

    def start(self):
        self.load_data_from_csv()
        df = self.read_data_from_db()
        df = df.drop(df.columns[[70, 71]], axis='columns')
        self.forecast(df)
        data = self.data_to_json()
        return data

    def data_to_json(self):
        """Чтение данных из БД Forecast и преобразование их в json"""
        source = sc.Forecast()
        session = source.create_session()
        data = pd.read_sql(session.query(Forecast).statement,session.bind)
        session.close()
        return data.to_json()

if __name__ == '__main__':
    fc = Forecasting(file_path="csv.csv", model_path="model.sav",
                     con_db='postgresql+psycopg2://postgresadmin:admin123@192.168.99.100:32543/postgresdb')
    fc.start()
