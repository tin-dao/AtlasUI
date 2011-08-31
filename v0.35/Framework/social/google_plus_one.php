<?php

	function google_plus_one($title, $description, $url, $size)
	{
		print "<head>";
			if ($title !== "")
			{
				print "<meta property=\"og:title\" content=\"" . $title . "\" />";
			}
			else{
				
			}
			if ($description !== "")
			{
				print "<meta property=\"og:description\" content=\"" . $description . "\" />";
			}
			else{
				
			}
			print "<meta property=\"og:type\" content=\"website\" />";
			print "<script type=\"text/javascript\" src=\"https://apis.google.com/js/plusone.js\"></script>";
		print "</head>";
		print "<body>";
			print "<g:plusone href=\"";
			if ($url !== "")
			{
				print $url;
			}
			else{
				$initurl = $_SERVER["SERVER_NAME"].$_SERVER["REQUEST_URI"];
				$stripcolons = str_replace(":", "%3A", $url);
				$url = str_replace("/","%2F", $stripcolons);
				print $url;
			}
			print "\"";
			if ($size == "default" || "")
			{
				print "></g:plusone>";
			}
			elseif ($size == "small")
			{
				print " size=\"small\"></g:plusone>";
			}
			elseif ($size == "medium")
			{
				print " size=\"medium\"></g:plusone>";
			}
			elseif ($size == "large")
			{
				print " size=\"large\"></g:plusone>";
			}
			else{
				print "></g:plusone>";
			}
		print "</body>";
	}

?>
