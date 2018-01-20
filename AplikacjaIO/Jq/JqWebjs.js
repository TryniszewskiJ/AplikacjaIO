$(document).ready(function () {


    $("a").click(function () {
        var hash = this.hash;
        $('html, body').animate({
            scrollTop: $(hash).offset().top
        }, 1000);
    });


    $('#nav-icon1').click(function (e) {

        $(this).toggleClass('open');
        $(this).css('pointer-events', 'none');
        if (!$('#nav2').hasClass('show')) {
            $('.navbar-collapse').collapse('show');
        }
        else {
            $('.navbar-collapse').collapse('hide');
        }
        setTimeout(function () {
            $('#nav-icon1').css('pointer-events', 'auto');
        }, 400);
    });
    $('#nav2').click(function () {
        $('#nav-icon1').toggleClass('open');
        $('.navbar-collapse').collapse('hide');
    });

    $(window).resize(function () {
        if ($(window).width() > 768 && $('#nav2').hasClass('show')) {
            $('#nav-icon1').toggleClass('open');
            $('#nav2').removeClass('show');

        }
    });

});