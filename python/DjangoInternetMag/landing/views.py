from django.shortcuts import render
from .forms import SubscriberForm
from products.models import ProductImage

def index(request):
    form = SubscriberForm(request.POST or None)
    name = {"subForm": form}
    if request.method == "POST" and form.is_valid():
        new_form = form.save()
    return render(request,"landing/landing.html", context=name)

def home(request):
    products = ProductImage.objects.filter(is_active=True, is_main=True, product__is_active=True)
    products_laptops = products.filter(product__category__id = 2)
    products_phones = products.filter(product__category__id = 1)
    return render(request,"landing/home.html", locals())