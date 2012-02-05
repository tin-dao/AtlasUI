<?php

	function ekiga_button($username)
	{
		if ($username !== "")
		{
			print "<script src=\"http://www.ekiga.net/status/presence.php?user=$username\"></script>";
		}
		else{
			print "<b>Please add your Ekiga.Net username!</b>";
		}
	}