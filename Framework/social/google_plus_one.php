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
				$url = atlasui_url_address("yes");
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
