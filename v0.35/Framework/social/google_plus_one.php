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
		print "<div class=\"g-plusone\" data-href=";
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
			print "></div>";
		}
		elseif ($size == "small")
		{
			print " data-size=\"small\"></div>";
		}
		elseif ($size == "medium")
		{
			print " data-size=\"medium\"></div>";
		}
		elseif ($size == "large")
		{
			print " data-size=\"large\"></div>";
		}
		else{
			print "></div>";
		}
		
		print "<script type=\"text/javascript\">";
		  print"function() {";
			print "var po = document.createElement('script'); po.type = 'text/javascript'; po.async = true;";
			print "po.src = 'https://apis.google.com/js/plusone.js';";
			print "var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(po, s);";
		  print "};";
		print "</script>";
	}

?>
