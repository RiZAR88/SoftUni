let timer;
let hours;

$('.start').on('click', function () {
    timer = setInterval(function () {
        hours = $('#hours').text();
        $('hours').text(hours+1);
    }, 1000);
});

$('.stop').on('click', function () {
    clearInterval(timer);
});