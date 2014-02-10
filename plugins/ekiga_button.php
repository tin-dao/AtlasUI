<?php

	function ekiga_button($username){
		if ($username !== null){
			print "<script src=\"http://www.ekiga.net/status/presence.php?user=$username\"></script>";
		}
		else{
			print "Please add your Ekiga.Net username!";
		}
	}
	
?>