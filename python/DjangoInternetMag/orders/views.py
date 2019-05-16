from django.http import JsonResponse
from .models import ProductInBasket
from django.shortcuts import render

# Create your views here.
def basket_adding(request):
    return_dict = dict()
    data=request.POST
    prod_id = data.get('product_id')
    nmb = data.get('nmb')
    session_key = data.get('session_key')
    is_delete = data.get('is_delete')
    if is_delete == 'false':
        new_product = ProductInBasket.objects.create(session_key=session_key, product_id=prod_id, nmb=nmb)
        prod_id = ProductInBasket.objects.get(session_key=session_key, product_id=prod_id, nmb=nmb).id
        return_dict["prod_id"] = prod_id
    else:
        new_product = ProductInBasket.objects.filter(id=prod_id).delete()
        return_dict["prod_id"] = prod_id
    products_total_nmb = ProductInBasket.objects.filter(session_key=session_key, is_active=True).count()
    return_dict["products_total_nmb"] = products_total_nmb
    return JsonResponse(return_dict)

def checkout(request):
    session_key = request.session.session_key
    product_in_basket = ProductInBasket.objects.filter(session_key=session_key,is_active=True)
    total_price = 0
    if request.POST:
        print(request.POST)
    for product in product_in_basket:
        total_price += product.total_price
    return render(request,'orders/checkout.html',locals())