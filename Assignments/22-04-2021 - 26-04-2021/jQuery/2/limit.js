$(document).ready(function(e) {   
    var maxLength = 15;
    $('textarea').keyup(function() {
    var textlen = maxLength - $(this).val().length;
    $('#rchars').text(textlen);
    });
});
