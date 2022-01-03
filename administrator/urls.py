from django.urls import path
from .views import NewCreateView, NewView

urlpatterns = [
    path('', NewCreateView.as_view(), name='new_add'),
    path('news/', NewView.as_view(), name='news')
]
