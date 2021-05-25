
window.onload=function showInteraction()  //executes when the page finishes loading

{
	setTimeout(showInteraction, 4000);  //sets a timer which calls function func1 after 4,000 milliseconds = 4 secs.
};

function showInteraction()
{
	document.getElementById("#interaction").addClass=".show";
}
