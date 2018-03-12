from django.shortcuts import render

def mh(request):
    return render(request, 'hometemp/home.html')
def con(request):
    return render(request, 'hometemp/contacts.html', { 'values':['Если у вас возникли какие-либо вопросы, то задавайте их по телефону', '89996995743']})
