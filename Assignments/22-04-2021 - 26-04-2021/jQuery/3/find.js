$(document).ready(function(e) {   
    var count_Checked = function() {
        var n = $( "input:checked" ).length;
        $( "p" ).text( n + (n === 1 ? " is" : " are") + " checked." );
        };
        count_Checked();
        $("input[type=checkbox]" ).on( "click", count_Checked );
 });
