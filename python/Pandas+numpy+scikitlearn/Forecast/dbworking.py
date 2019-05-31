import pandas as pd
import sqlalchemy_connect as sc
from sqlalchemy_connect import Source
import logging
logging.basicConfig(format = u'%(filename)s[LINE:%(lineno)d]# %(levelname)-8s [%(asctime)s]  %(message)s', level = logging.DEBUG, filename='log.log')

class DbWorking():
    def __init__(self, file_path, con_db):
        self.path = file_path
        self.con = con_db

    def conn_to_db(self):
        logging.info(u'Connect to DB start')
        """Подключение к базе"""
        conn = sc.get_connection(self.con)
        logging.info(u'Connect to DB end')
        return conn

    def load_data_from_csv(self):
        """Загрузка данных из csv в базу SOURCE"""
        logging.info(u'Load data from csv to DB start')
        data = pd.read_csv(self.path)
        con = self.conn_to_db()
        data.to_sql(name="SOURCE", con=con, if_exists='replace')
        logging.info(u'Load data from csv to DB end')

    def read_data_from_db(self):
        """Чтение данных из БД"""
        logging.info(u'Read data from db start')
        data_list = []
        source = sc.Source()
        session = source.create_session()
        data = pd.read_sql(session.query(Source).statement,session.bind)
        session.close()
        data = data.drop(data.columns[[0,1]], axis='columns')
        for index, row in data.iterrows():
            data_list.append(list(row))
        logging.info(u'Read data from db end')
        return data_list

if __name__ == '__main__':
    pass
