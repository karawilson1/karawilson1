$("#interaction").hide();
setInterval(function(){
	$("#interaction").show();
},4000);

window.onload=function showInteraction()  //executes when the page finishes loading

{
	setTimeout(func1, 4000);  //sets a timer which calls function func1 after 2,000 milliseconds = 2 secs.
};

function showInteraction()
{
	document.getElementById("#interaction").className="show";
}
