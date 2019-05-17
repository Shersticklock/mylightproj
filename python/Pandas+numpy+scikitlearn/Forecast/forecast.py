from pandas import read_csv, read_sql
import psycopg2
import numpy as np
import pandas as pd
from sqlalchemy import create_engine
import joblib

class Forecast():
    def __init__(self, csv_path, model_path, con_db):
        self.path = csv_path
        self.model = model_path
        self.con = con_db

    def conn_to_db(self):
        """Подключение к базе"""
        conn = create_engine(self.con)
        return conn

    def load_data_from_csv(self):
        """Загрузка данных из csv в базу SOURCE"""
        data = read_csv(self.path)
        con = self.conn_to_db()
        data.to_sql(name="SOURCE", con=con, if_exists='replace')

    def read_data_from_db(self):
        """Чтение данных из БД"""
        con = self.conn_to_db()
        data = read_sql('SELECT * FROM public."SOURCE"', con)
        return data

    def load_data_to_db(self,data):
        """Загрузка прогноза в базу FORECAST"""
        fc = pd.Series(data=data,name='forecast')
        con = self.conn_to_db()
        fc.to_sql(name="FORECAST", con=con, if_exists='replace')
        print(fc)

    def forecast(self, data):
        """Предсказание меток по уже обученной модели"""
        loaded_model = joblib.load(self.model)
        pred_1 = loaded_model.predict(data)
        self.load_data_to_db(pred_1)

    def main(self):
        self.load_data_from_csv()
        df = self.read_data_from_db()
        df = df.drop(df.columns[[70, 71]], axis='columns')
        self.forecast(df)

if __name__ == '__main__':
    fc = Forecast(csv_path="csv.csv", model_path="model.sav",
                  con_db='postgresql+psycopg2://postgresadmin:admin123@192.168.99.100:32543/postgresdb')
    fc.main()
