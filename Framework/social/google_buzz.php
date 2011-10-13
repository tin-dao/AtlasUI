<?php

	function google_buzz($url)
	{
		if ($url == "dynamic")
		{
			$url = atlasui_url_address("no");
		}
		
		print "<head>";
			print "<script type=\"text/javascript\" src=\"http://www.google.com/buzz/api/button.js\"></script>";
		print "</head>";
		print "<body>";
			print "<a title=\"Post " . $url . " to Google Buzz\" class=\"google-buzz-button\" href=\"http://www.google.com/buzz/post\" data-button-style=\"normal-count\" data-url=\"" . $url . "\"></a>";
		print "</body>";
	}
	
?>
