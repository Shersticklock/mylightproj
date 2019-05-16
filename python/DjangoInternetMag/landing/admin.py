from django.contrib import admin
from .models import *

@admin.register(Subscriber) #регистрируем модель в админке

class SubscriberAdmin(admin.ModelAdmin):# отображение в админке
   list_display = [field.name for field in Subscriber._meta.fields] # какие поля показывать
   ordering = ["name"] # отсортировать по названию по алфавиту
   list_filter = ["name"]
   search_fields = ["name"]

