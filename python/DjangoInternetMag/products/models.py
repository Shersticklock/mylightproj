from django.db import models

# Create your models here.
class ProductCategory(models.Model):
    name = models.CharField(max_length=128)
    is_active = models.BooleanField(default=True)
    def __str__(self):
        return "%s" % self.name

    class Meta:
        verbose_name = "Категория"
        verbose_name_plural = "Категории"

class Product(models.Model):
    name = models.CharField(max_length=128)
    description = models.TextField(blank=True, null=True, default=None)
    is_active = models.BooleanField(default=True)
    price = models.DecimalField(max_digits=10, decimal_places=2, default=0)
    discount = models.IntegerField(default=0)
    category = models.ForeignKey(ProductCategory, blank=True, null=True, default=None, on_delete=models.CASCADE)
    created = models.DateTimeField(auto_now_add=True, auto_now=False)
    updated = models.DateTimeField(auto_now_add=False, auto_now=True)

    def __str__(self):
        return "%s" % self.name

    class Meta:
        verbose_name = "Товар"
        verbose_name_plural = "Товары"

class ProductImage(models.Model):
    product = models.ForeignKey(Product,blank=True, null=True, default=None, on_delete=models.CASCADE)
    image = models.ImageField(upload_to="media/products_img/")
    is_active = models.BooleanField(default=True)
    is_main = models.BooleanField(default=False)
    created = models.DateTimeField(auto_now_add=True, auto_now=False)
    updated = models.DateTimeField(auto_now_add=False, auto_now=True)

    class Meta:
        verbose_name = "Изображение"
        verbose_name_plural = "Изображения"