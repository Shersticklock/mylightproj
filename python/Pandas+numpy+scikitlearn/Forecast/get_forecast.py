import dbworking
import requests
import sqlalchemy_connect as sc
import json
import logging
class GetForecast():
    logging.basicConfig(format = u'%(filename)s[LINE:%(lineno)d]# %(levelname)-8s [%(asctime)s]  %(message)s', level = logging.DEBUG, filename='log.log')
    def get_forecast(self):
        logging.info(u'Start get_forecast')
        forecasts = []
        db = dbworking.DbWorking(file_path="csv.csv",
                                 con_db='postgresql+psycopg2://postgresadmin:admin123@192.168.1.37:32543/postgresdb')
        #загрузка данных из csv в базу
        db.load_data_from_csv()
        #чтение данных из БД
        data_list = db.read_data_from_db()
        data = json.dumps({'input_batch': data_list})
        #получение прогнозов
        try:
            response = requests.post('http://192.168.1.37:31341/forecastservice3/predict', data = data, headers = {'Content-type':'application/json'})
            for out in response.json()['batch_predictions']:
                forecasts.append(out['output'])
        except requests.exceptions.ConnectionError:
            logging.error(u'ConnectionError - Что-то пошло не так')
        #Сохранение в  базу
        ft = sc.Forecast()
        ft.save_all_to_db(forecasts)
        logging.info(u'End get_forecast')

if __name__ == '__main__':
    logging.info(u'Start get_forecast.py')
    gf = GetForecast()
    gf.get_forecast()
    logging.info(u'End get_forecast.py')