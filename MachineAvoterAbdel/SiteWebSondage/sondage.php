<?php

	$bdd = include("connexion.php"); // on inclus la connexion de la base de données dans une variable

/* GERATION DU SONDAGE */

	// ON RECUPERE LA QUESTION

	$idQuestion = "9";

	try{
		
		$sql = $bdd->prepare("SELECT question FROM sondages WHERE idsondages = :idQuestion");
		$sql->bindParam(':idQuestion',$idQuestion);
		if($answer = $sql->execute())
		{
			$question = $sql->fetch();
		}
	}catch (\PDOException $e) {
		echo $e->getMessage() . '<BR>';
	}

	// ON RECUPERE LES VOTANTS DE LA QUESTION

	$sql = "SELECT optionChoisie FROM sondages_has_votants WHERE sondages_idsondages = 9 ORDER BY votants_idvotants ASC";
	$opt1 = 0;
	$opt2 = 0;


	foreach ($bdd->query($sql) as $row) {
		
		
		if($row['optionChoisie'] == 0)
			$opt1++;
		else
			$opt2++;
	} 

	$totalVote = $opt1 + $opt2;
	$valeur_p = 100;
	$p1 = cacul_pourcentage($opt1,$totalVote,$valeur_p)." %";
	$p2 = cacul_pourcentage($opt2,$totalVote,$valeur_p)." %";









//IMPORTATION HTML ETC

	echo "<link rel='stylesheet' type='text/css' href='/path/to/file.css' />";
	echo "<html>";

	echo	"	
				
				<div id='page2' class='enAttente'>
				
					<div id='terre'>
						<p id='question' class='sondage '>" . $question[0] ." </p>
					</div>
					<div id='soleil'></div>
			 
					<div id='option1' class=''>
						<p class='sondage  pourcentage'>" . $p1 ." </p>
						<p class='sondage  options'>" . $opt1 ." </p>
						<p></p>
						</img>
					</div>

					<div id='option2' class=''>
						<p class='sondage pourcentage'>" . $p2 ." </p>
						<p class='sondage options'>" . $opt2 ." </p>				
						</img>
					</div>

					
				
				</div>";
	
	
			
				
	echo "</html>";

	include("sondage.html");
	 
	 
 
 
 
 
 
/*FONCTION PHP*/ 
 
 
 
 
	 
	function cacul_pourcentage($nombre,$total,$pourcentage)
	{ 
	  $resultat = ($nombre/$total) * $pourcentage;
	  return round($resultat); // Arrondi la valeur
	} 
	 
?>