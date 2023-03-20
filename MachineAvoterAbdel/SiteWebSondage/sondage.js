var soleil = document.getElementById("soleil");
var terre = document.getElementById("earth");
var page1 = document.getElementById("page1");
var page2 = document.getElementById("page2");

var opt1 = document.getElementById("option1");
var opt2 = document.getElementById("option2");


document.getElementById("earth").addEventListener("click", transitionVersSondage);
document.getElementById("soleil").addEventListener("click", transitionVersAccueil);



function transitionVersSondage()
{
  
	// terre.classList.remove("animationMouvementSpatial");
	// terre.classList.add("animationTransition");

	page1.classList.add("enAttente");

	page2.classList.remove("enAttente");


}


function transitionVersAccueil()
{
	// terre.classList.add("animationMouvementSpatial");
	// terre.classList.remove("animationTransition");
	
	page1.classList.remove("enAttente");

	page2.classList.add("enAttente");

}

function tailleOption()
{
	
	
	
}