$(function () {
    $('div > a').click(function (event) {
        $.ajax({
            url: $(this).attr('href'),
            type: 'GET',
            success: function (responce) {
                alert("1232");
                $('#'+  event.target.id).addClass('active').siblings().removeClass('active');
            }
        });
    });
});