$(document).ready(function(e) {   
    $("p").bind("click", function(){
        $( "<p>This is a click Event</p>").appendTo( "#result" );
        });
        $("p").bind("dblclick", function(){
          $( "<p>This is a double-click Event</p>"  ).appendTo( "#result" );
          });
 });
