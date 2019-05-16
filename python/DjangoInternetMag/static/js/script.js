$(document).ready(function () {
    var form = $('#form_buying_prod');
    form.on('submit',function (e) {
        e.preventDefault();
        var nmb = $('#number').val();
        var sbtn = $('#submit_btn');
        var product_id = sbtn.data("product_id");
        var product_name = sbtn.data("name");
        var product_price = sbtn.data("price");
        var session_key = sbtn.data("session_key");

        var data = {};
        data.product_id = product_id;
        data.nmb = nmb;
        data.session_key = session_key;
        var csrf_token = $('#form_buying_prod [name=csrfmiddlewaretoken]').val();
        data["csrfmiddlewaretoken"] = csrf_token;
        data.is_delete = false;
        url = form.attr("action");
        $.ajax({
            url: url,
            type: 'POST',
            data: data,
            cache: true,
            success: function (data) {
                console.log("OK");
                if(data.products_total_nmb)
                $('#basket-total-nmb').text("(" + data.products_total_nmb + ")");
                console.log(data.prod_id);
                $('.basket-items ul').append('<li>' + product_name + ', ' + nmb + 'шт. ' + 'по ' + product_price + 'руб.  ' +
            '<a href="#" class="delete-item" data-product_id = "'+ data.prod_id +'" data-product_name = "' + product_name +'"">x</a> </li>');

            }
        });

    })

    function showBasket() {
        $('.basket-items').toggleClass('hidden');
    }
    var cart = $('.basket-container');
    cart.on('click hover',function (e) {
        showBasket();
    })
        .mouseover(function (e) {
        $('.basket-items').removeClass('hidden');
    })
        $('.basket-items').mouseout(function () {
            $(this).addClass('hidden');
        });
    $(document).on('click','.delete-item',function () {

        var data = {};
        data.product_name = $(this).data("product_name");
        data.product_id = $(this).data("product_id");
        data.nmb = 0;
        var csrf_token = $('#form_buying_prod [name=csrfmiddlewaretoken]').val();
        data["csrfmiddlewaretoken"] = csrf_token;
        data.is_delete = true;
        url = form.attr("action");
        $.ajax({
            url: url,
            type: 'POST',
            data: data,
            cache: true,
            success: function (data) {
                console.log("OK");
                $('#basket-total-nmb').text("(" + data.products_total_nmb + ")");
            }
        });
        $(this).closest('li').remove();
    })
    function calculatingBasketAmount() {
        var total_order_amount = 0;
        $('.total-in-basket-price').each(function () {
           total_order_amount += Number($(this).text());
        });
        $('#total_order_amount').text(total_order_amount);
    }
    calculatingBasketAmount();

    $(document).on('change','.product-in-basket-nmb', function () {
        var current_nmb = $(this).val();
        var current_tr = $(this).closest('tr');
        var current_price = Number(current_tr.find(".product-in-basket-price").text());
        var total_amount = current_nmb * current_price;
        current_tr.find(".total-in-basket-price").text(total_amount);
        calculatingBasketAmount();
    })
});

