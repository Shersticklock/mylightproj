from django.views.generic.edit import CreateView
from django.urls import reverse_lazy
from rest_framework.response import Response
from rest_framework.views import APIView
from .models import New
from .forms import NewForm
from .serializers import NewSerializer
import logging


class NewView(APIView):
    def get(self, request):
        news = New.objects.all().order_by('-date')
        new_serializer = NewSerializer(news, many=True)
        logging.error(new_serializer.data)
        return Response(new_serializer.data)


class NewCreateView(CreateView):
    model = New
    form_class = NewForm
    template_name = 'administrator/new_add.html'
    success_url = reverse_lazy('new_add')
