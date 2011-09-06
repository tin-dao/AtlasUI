<?php
	
	function atlasui_sql_connect($location, $database, $user, $password)
	{
		$go = mysql_connect('$location', '$user', '$password');
		if (!$go)
		{
			die('Could not connect: ' . mysql_error());
		}
		else{
			mysql_select_db('$database', $go);
		}
	}
	
?>
