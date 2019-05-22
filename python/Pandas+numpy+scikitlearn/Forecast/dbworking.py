import pandas as pd
import sqlalchemy_connect as sc
from sqlalchemy_connect import Source


class DbWorking():
    def __init__(self, file_path, con_db):
        self.path = file_path
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

    def read_data_from_db(self):
        """Чтение данных из БД"""
        source = sc.Source()
        session = source.create_session()
        data = pd.read_sql(session.query(Source).statement,session.bind)
        session.close()
        return data.to_json()

if __name__ == '__main__':
    pass
