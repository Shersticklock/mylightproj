from django.urls import path
from . import views

urlpatterns = [
    path('', views.mh, name="mh"),
    path('contacts/', views.con, name="con")
]
