from django.urls import path
from django.views.generic import ListView, DetailView
from news.models import Table

urlpatterns = [
    path('', ListView.as_view(queryset=Table.objects.all().order_by("-date")[:20], template_name="news/post.html"))
]
