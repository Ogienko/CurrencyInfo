$(function () {
    var timer = setTimeout(Update, 15000);

    $('#update-link').click(function (e) {
        Update();
        e.preventDefault();
    });

    function Update() {
        $.get('/Currency/GetCurrencies', function (data) {
            $('#currencies').html(data);
            clearTimeout(timer);
            timer = setTimeout(Update, 15000);
        });
    }
});