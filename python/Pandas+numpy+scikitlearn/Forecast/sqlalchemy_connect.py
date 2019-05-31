from sqlalchemy import create_engine
from sqlalchemy.ext.declarative import declarative_base
from sqlalchemy import Column, Integer, Float, BigInteger
from sqlalchemy.orm import sessionmaker
import logging
logging.basicConfig(format = u'%(filename)s[LINE:%(lineno)d]# %(levelname)-8s [%(asctime)s]  %(message)s', level = logging.DEBUG, filename='log.log')
#Декларативное создание таблиц
Base = declarative_base()
# Подключение к БД
def get_connection(path):
    logging.info(u'Get connection start')
    engine = create_engine(path)
    logging.info(u'Get connection end')
    return engine
#Получение connection
engine = get_connection('postgresql+psycopg2://postgresadmin:admin123@192.168.1.37:32543/postgresdb')
class Source(Base):
    def __init__(self,**kwargs):
        pass
    __tablename__ = 'SOURCE'
    index = Column(Integer, primary_key=True, autoincrement=True)
    unnamed = Column('Unnamed: 0', BigInteger)
    cnt_activity = Column(BigInteger)
    cnt_activity_doc = Column(BigInteger)
    cnt_activity_pharmacy = Column(BigInteger)
    cnt_events = Column(BigInteger)
    cnt_all_promo_tv_takeda = Column(Float(53))
    cnt_all_promo_tv_comp = Column(Float(53))
    trade_investments_1 = Column(Float(53))
    cnt_pharmacy = Column(BigInteger)
    season_coef_month = Column(Float(53))
    sum_quantity_tv_promo = Column(Float(53))
    season_coef_month_target_1 = Column(Float(53))
    season_coef_month_target_2 = Column(Float(53))
    season_coef_month_target_3 = Column(Float(53))
    season_coef_month_target_4 = Column(Float(53))
    season_coef_month_target_5 = Column(Float(53))
    season_coef_month_target_6 = Column(Float(53))
    season_coef_month_target_7 = Column(Float(53))
    season_coef_month_target_8 = Column(Float(53))
    season_coef_month_target_9 = Column(Float(53))
    season_coef_month_target_10 = Column(Float(53))
    season_coef_month_target_11 = Column(Float(53))
    season_coef_month_target_12 = Column(Float(53))
    sum_salesrur_month = Column(Float(53))
    sum_salesrur_month_1 = Column(Float(53))
    sum_salesrur_month_2 = Column(Float(53))
    sum_salesrur_month_3 = Column(Float(53))
    sum_salesrur_month_4 = Column(Float(53))
    sum_salesrur_month_5 = Column(Float(53))
    sum_salesrur_month_6 = Column(Float(53))
    sum_salesrur_month_7 = Column(Float(53))
    sum_salesrur_month_8 = Column(Float(53))
    sum_salesrur_month_9 = Column(Float(53))
    sum_salesrur_month_10 = Column(Float(53))
    sum_salesrur_month_11 = Column(Float(53))
    avg_salesrur_month_3 = Column(Float(53))
    avg_salesrur_month_6 = Column(Float(53))
    avg_salesrur_month_9 = Column(Float(53))
    sum_salesrur_delivery_month = Column(Float(53))
    sum_salesrur_delivery_month_1 = Column(Float(53))
    sum_salesrur_delivery_month_2 = Column(Float(53))
    avg_salesrur_1_month_3 = Column(Float(53))
    avg_salesrur_1_month_6 = Column(Float(53))
    avg_salesrur_1_month_9 = Column(Float(53))
    sum_sellout_packs = Column(Float(53))
    avg_price_month = Column(Float(53))
    avg_price_month_1 = Column(Float(53))
    avg_price_month_2 = Column(Float(53))
    sum_salesrur_budget = Column(Float(53))
    sum_salesrur_actual = Column(Float(53))
    avg_price_actual = Column(Float(53))
    sum_packs_budget = Column(Float(53))
    num_comp = Column(Float(53))
    sum_packs_comp = Column(Float(53))
    sum_rur_comp = Column(Float(53))
    cnt_members = Column(BigInteger)
    month = Column(BigInteger)
    sum_sales_diff_1 = Column(Float(53))
    sum_sales_diff_2 = Column(Float(53))
    sum_sales_diff_3 = Column(Float(53))
    sum_sales_diff_4 = Column(Float(53))
    sum_sales_diff_5 = Column(Float(53))
    sum_sales_diff_6 = Column(Float(53))
    sum_sales_diff_7 = Column(Float(53))
    sum_sales_diff_8 = Column(Float(53))
    sum_sales_diff_9 = Column(Float(53))
    sum_sales_diff_10 = Column(Float(53))
    sum_sales_diff_11 = Column(Float(53))
    sum_rur_takeda = Column(Float(53))
    sum_promo_comp = Column(Float(53))
    cnt_pharm_act = Column(Float(53))

    def create_session(self):
        """Создание сессии"""
        logging.info(u'Create session start')
        Session = sessionmaker(bind=engine)
        session = Session()
        logging.info(u'Create session end')
        return session

    def select_all(self):
        """Выбор всех строк из таблицы"""
        logging.info(u'Select_all from SOURCE table start')
        session = self.create_session()
        all_obj = session.query(Source).all()
        session.close()
        logging.info(u'Select_all from SOURCE table end')
        return all_obj

class Forecast(Base):
    def __init__(self, forecast=0):
        self.forecast = forecast
    __tablename__ = 'FORECAST'
    index = Column(Integer, primary_key=True, autoincrement=True)
    forecast = Column(Float)

    def drop_table(self):
        """Удаление таблицы"""
        logging.info(u'Drop_table FORECAST start')
        Forecast.__table__.drop(engine)
        logging.info(u'Drop_table FORECAST end')

    def create_session(self):
        """Создание сессии"""
        logging.info(u'Create session start')
        Session = sessionmaker(bind=engine)
        session = Session()
        logging.info(u'Create session end')
        return session

    def select_all(self):
        """Выбор всех строк из таблицы"""
        logging.info(u'Select_all from FORECAST table start')
        session = self.create_session()
        all_obj = session.query(Forecast).all()
        session.close()
        logging.info(u'Select_all from FORECAST table end')
        return all_obj

    def save_to_db(self):
        """Сохранение записи в базу"""
        logging.info(u'Save forecast to DB start')
        session = self.create_session()
        session.add(self)
        session.commit()
        session.flush()
        session.close()
        logging.info(u'Save forecast to DB end')

    def save_all_to_db(self, nparray):
        """Сохранение всех записей в базу"""
        logging.info(u'Save all forecasts to DB start')
        session = self.create_session()
        for j in nparray:
            fc = Forecast(forecast=j)
            session.add(fc)
        session.commit()
        session.flush()
        session.close()
        logging.info(u'Save all forecasts to DB end')


def create_tables():
    """Создание таблиц"""
    logging.info(u'Create all tables start')
    Base.metadata.create_all(engine)
    logging.info(u'Create all tables end')
create_tables()

if __name__ == '__main__':
    pass