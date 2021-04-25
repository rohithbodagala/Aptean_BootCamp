function guess(){
    var n=Math.floor((Math.random() * 10) + 1);
    if(parseInt(document.getElementById("guess").value)==n){
        document.getElementById("result").innerHTML="Good Work";
    }
    else{
        document.getElementById("result").innerHTML="Not Matched";
        
    }
}
