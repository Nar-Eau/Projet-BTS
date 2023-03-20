 <?php
 
 
// $dbname = "essai.db";

// try {
  // $conn = new PDO("sqlite:dbname=$dbname");
  // // $conn->setAttribute(PDO::ATTR_EMULATE_PREPARES, false);
  // $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

// } catch(PDOException $e) {
  // echo "Error: " . $e->getMessage();
// }

// $ipAdress = '172.18.199.9';
// $username = 'root';
// $password = '';

// //On établit la connexion
// mysql_connect($ipAdrress,$username,$password);

// //On vérifie la connexion
// if($conn->connect_error){
	// die('Erreur : ' .$conn->connect_error);
// }
// echo 'Connexion réussie';


// $host = '172.18.199.9';
// $db   = 'bddsondages';
// $user = 'root';
// $pass = '';
// $port = "3306";
// $charset = 'utf8mb4';

// $dsn = "mysql:host=$host;dbname=$db;charset=$charset;port=$port";
// try {
     // $pdo = new \PDO($dsn, $user, $pass);
// } catch (\PDOException $e) {
     // throw new \PDOException($e->getMessage(), (int)$e->getCode());
// }


$dbServerName = "172.18.199.9";
$dbUsername = "root";
$dbPassword = "%STS*Mauriacdb";
$dbName = "bddsondages";

// // create connection
// $conn = new mysqli($dbServerName, $dbUsername, $dbPassword, $dbName);

// // check connection
// if ($conn->connect_error) {
    // die("Connection failed: " . $conn->connect_error);
// }
// else 
// {
	// $result = $conn->query("SELECT question, idsondages FROM sondages ORDER BY idsondages ASC");

	// foreach ($result as $row) {
		// echo " question " . $row['idsondages']. " = " . $row['question'] . "\n";
	// }
// }


try {
$conn = new PDO("mysql:host=$dbServerName;dbname=$dbName", $dbUsername, $dbPassword);
echo "<html> <p style='display:none;'> Connected to $dbName at $dbServerName successfully </p> </html>";
} catch (PDOException $pe) {
die ("Could not connect to the database $dbName :" . $pe->getMessage());
}

return $conn;

?> 