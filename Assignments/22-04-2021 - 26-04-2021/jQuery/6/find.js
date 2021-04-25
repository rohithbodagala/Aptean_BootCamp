$(document).ready(function(e) {   
    $("h3").each(function(i){
        $(this).on("click", {x:i}, function(event){
          var info = "Header" + $(this).index() + ". paragraph has Event data: " + event.data.x;    
         $("<p>"+info+"</p>").appendTo( "body" );      
        });
     })
 });
