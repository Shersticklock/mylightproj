from selenium import webdriver
import unittest
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.common.by import By
from selenium.webdriver.support import expected_conditions as EC
from selenium.webdriver.support.ui import WebDriverWait
from selenium.common.exceptions import TimeoutException

class YandexSearch(unittest.TestCase):
    def setUp(self):
        self.driver = webdriver.Chrome()
        self.driver.get("http://yandex.ru")

    def test_01(self):
        driver = self.driver
        input = driver.find_element_by_id("text")
        # Проверка наличия поля поиска
        self.assertEqual(input.get_attribute("id"), "text")
        input.send_keys("Тензор")
        wait = WebDriverWait(driver, 30)
        wait.until(EC.visibility_of_element_located(
            (By.XPATH, "//div[@class='suggest2__content suggest2__content_theme_normal']")))
        suggest = driver.find_element_by_xpath(
            "//div[@class='suggest2__content suggest2__content_theme_normal']")
        # Проверка того, что появилась таблица с подсказками (suggest)
        self.assertEqual(suggest.get_attribute("class"),
                         "suggest2__content suggest2__content_theme_normal")
        input.send_keys(Keys.ENTER)
        urls = driver.find_elements_by_xpath(
            "//div[@class='organic__subtitle typo typo_type_greenurl']//b")
        # Проверка,что 1 ссылка ведет на сайт tensor.ru
        self.assertEqual(urls[0].text, "tensor.ru")

    def test_02(self):
        driver = self.driver
        # Проверка, что ссылка «Картинки» присутствует на странице
        self.assertEqual(driver.find_element_by_xpath(
            "//a[@data-id='images']").get_attribute("data-id"), "images")
        driver.find_element_by_xpath("//a[@data-id='images']").click()
        # Проверка, что перешли на url https://yandex.ru/images/
        self.assertEqual(driver.current_url, "https://yandex.ru/images/")
        images = driver.find_elements_by_xpath("//a[@class='cl-teaser__link']")
        images[0].click()
        wait = WebDriverWait(driver, 30)
        try:
            wait.until(EC.visibility_of_element_located(
                (By.XPATH, "//a[@class='layout__nav__arrow ' or @class='layout__nav__arrow']")))
        except TimeoutException as ex:
            print(str(ex))
        image_src1 = driver.find_element_by_class_name(
            "image__image").get_attribute("src")
        # Проверка, что картинка открылась
        self.assertEqual(driver.find_element_by_class_name(
            "image__image").get_attribute("class"), "image__image")
        try:
            driver.find_element_by_xpath(
                "//a[@class='layout__nav__arrow ' or @class='layout__nav__arrow']").click()
            wait.until(EC.visibility_of_element_located(
                (By.XPATH, "//img[@data-il='image__wrap']")))
        except TimeoutException as ex:
            print(str(ex))
        image_src2 = driver.find_element_by_class_name(
            "image__image").get_attribute("src")

        # Проверка, что при нажатии кнопки вперёд картинка изменяется
        self.assertNotEqual(image_src1, image_src2)
        arrows = driver.find_elements_by_xpath(
            "//a[@class='layout__nav__arrow ' or @class='layout__nav__arrow']")
        arrows[0].click()
        image_src3 = driver.find_element_by_class_name(
            "image__image").get_attribute("src")
        # Проверка, что принажатии кнопки назад картинка изменяется на изображение 1
        self.assertEqual(image_src1, image_src3)

    def tearDown(self):
        if self.driver is not None:
            self.driver.quit()


if __name__ == '__main__':
    unittest.main()
