from django.db import models


class New(models.Model):
    subject = models.CharField(max_length=256, verbose_name='Заголовок')
    content = models.TextField(verbose_name='Контент')
    date = models.DateField(verbose_name='Дата')
