from django import forms
from bootstrap_datepicker_plus.widgets import DatePickerInput
from .models import New


class NewForm(forms.ModelForm):

    class Meta:
        model = New
        exclude = []
        widgets = {
            'date': DatePickerInput()
        }
