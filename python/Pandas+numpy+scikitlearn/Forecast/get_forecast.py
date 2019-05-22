import forecast
import requests
import sqlalchemy_connect as sc

class GetForecast():

    def get_forecast(self):
        fc = forecast.Forecasting(file_path="csv.csv", model_path="model.sav",
                                  con_db='postgresql+psycopg2://postgresadmin:admin123@192.168.99.100:32543/postgresdb')
        #загрузка данных из csv в базу
        fc.load_data_from_csv()
        #чтение данных из БД
        df = fc.read_data_from_db()
        #получение прогнозов
        try:
            response = requests.post('http://127.0.0.1:5000/', data = df, headers = {'Content-type':'application/json'})
        except ConnectionError:
            print('Что-то пошло не так')
        json = response.json()
        #Сохранение в  базу
        ft = sc.Forecast()
        ft.save_all_to_db(list(json['forecast'].values()))


if __name__ == '__main__':
    gf = GetForecast()
    gf.get_forecast()