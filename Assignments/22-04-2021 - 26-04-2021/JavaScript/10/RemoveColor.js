function removecolor()
{
var x=document.getElementById("colorSelect");
x.remove(x.selectedIndex);
document.getElementById("result").innerHTML="No.of Remaining Items: "+ x.length;
}
