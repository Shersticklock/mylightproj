import dbworking
import requests
import sqlalchemy_connect as sc
import json
import numpy as np
class GetForecast():

    def get_forecast(self):
        db = dbworking.DbWorking(file_path="csv.csv",
                                 con_db='postgresql+psycopg2://postgresadmin:admin123@192.168.1.37:32543/postgresdb')
        #загрузка данных из csv в базу
        db.load_data_from_csv()
        #чтение данных из БД
        df =db.read_data_from_db()
        df = json.dumps({'input_batch': df})
        #получение прогнозов
        try:
            response = requests.post('http://192.168.1.37:31341/forecastservice2/predict', data = df, headers = {'Content-type':'application/json'})
            print(response.json())
        except requests.exceptions.ConnectionError:
            print('Что-то пошло не так')
        json2 = response.json()
        #Сохранение в  базу
        ft = sc.Forecast()
        ft.save_all_to_db(list(json2['forecast'].values()))

if __name__ == '__main__':
    gf = GetForecast()
    gf.get_forecast()