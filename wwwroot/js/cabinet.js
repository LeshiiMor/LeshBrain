
$('.nav-admin-item').removeClass('active-item');
var item = $('.namePage').text();
var listNav = $('.nav-admin-link')
for (var i = 0; i < listNav.length; i++)
{
    if (listNav[i].textContent === item) listNav[i].parentElement.parentElement.classList.add('active-item')
}



$('#createRolebtn').on('click', function () {
    $('#hideCreaterolbtn').slideDown()
    $('.form').slideDown()
})

$('#hideCreaterolbtn').on('click', function () {
    $(this).slideToggle()
    $('.form').slideToggle()
})

$('.book-card').on('click', function () {
    var id = $(this).data('id');
    $.ajax({
        type: 'GET',
        //url: '@Url.Action("Info","Library")',
        url:'Library/Info',
        data: { 'idBook': id },
        success: function (msg) {
            $('#main').html(msg);
        },
        error: function (req, status, error) {
            console.log(msg);
        }
    });
})

$('.test-card').on('click', function () {
    var id = $(this).data('id');
    $.ajax({
        type: 'GET',
        //url: '@Url.Action("Info","Test")',
        url:'Test/Info',
        data: { 'id': id },
        success: function (msg) {
            $('#main').html(msg);
        },
        error: function (req, status, error) {
            console.log(msg);
        }
    });
})

function updateUrl(input) {
    let file = input.files[0];
    let check = false;
    if ($('#persAva').attr('src') == '') check = true;
    if (check) {
        $('#persAva').attr('src', URL.createObjectURL(file));
        $('#persAva').show(1000);
    }
    else {
        $('#persAva').animate({ opacity: 0 }, 500);
        setTimeout(function () {
            $('#persAva').attr('src', URL.createObjectURL(file));
        }, 500)
        $('#persAva').animate({opacity:1}, 500);
    }
    $('#paperClip').hide(500)
    $('#completeIcon').show(1000)
    $('.file-text').text('Изменить файл');
}