function StringGenerate(){
    var s=document.getElementById("string").value;
    if(s.charAt(0).toUpperCase()=='P' || s.charAt(s.length-1).toUpperCase()=='P'){
        document.getElementById("result").innerHTML=s.slice(1,s.length-1);
    }
    else{
        document.getElementById("result").innerHTML=s;
    }
}