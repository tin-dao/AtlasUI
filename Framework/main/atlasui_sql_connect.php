<?php
	
	function atlasui_sql_connect($type, $location, $database, $user, $password)
	{
		if ($type == "mysql"){
			$mysql_var = mysql_connect($location, $user, $password);
			if (!$mysql_var){
				die('Could not connect: ' . mysql_error());
			}
			else{
				mysql_select_db($database, $mysql_var);
			}
			return $go;
		}
		elseif ($type == "mysqli"){
			$mysqli_var = new mysqli($location, $user, $password, $database);
			if (!$mysqli_var){
				die("Could not connect: ") . mysqli_error($mysqli_var);
			}
			else{
				return $mysqli_var;
			}
		}
	}
	
?>
