<?php
	
	function atlasui_sql_connect($location, $database, $user, $password){
		$mysqlInstance = mysqli_connect($location, $user, $password, $database); // Create a new MySQLi instance

		if (!$mysqlInstance){ // If the MySQLi instance failed to connect
			return false; // Return a boolean FALSE signifying that the connection failed
		}
		else{ // If the connection was a success
			return $mysqlInstance; // Return the MySQLi instance
		}
	}
	
?>