# Generated by Django 3.2.10 on 2021-12-30 13:33

from django.db import migrations, models


class Migration(migrations.Migration):

    initial = True

    dependencies = [
    ]

    operations = [
        migrations.CreateModel(
            name='New',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('subject', models.CharField(max_length=256, verbose_name='Заголовок')),
                ('content', models.TextField(verbose_name='Контент')),
                ('date', models.DateField(verbose_name='Дата')),
            ],
        ),
    ]
