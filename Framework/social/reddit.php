<?php

	function reddit($set_or_dynamic, $url, $image){
		print "<a href=\"http://www.reddit.com/submit?url=";
		if ($set_or_dynamic == "set")
		{
			print $url;
		}
		elseif ($set_or_dynamic == "dynamic")
		{
			$initurl = $_SERVER["SERVER_NAME"].$_SERVER["REQUEST_URI"];
			$stripcolons = str_replace(":", "%3A", $url);
			$url = str_replace("/","%2F", $stripcolons);
			print $url;
		}
		else{
			print "\"></a>You will need to choose set or dynamic on your Framework reddit function.";
		}
		if ($set_or_dynamic == "set" || "dynamic")
		{
			print "\" target=\"_blank\">";
			if ($image !== "default")
			{
				print "<img src=\"" . $url . "\" alt=\"Submit To Reddit!\" border=\"0\" />";
			}
			else{
				print "<img src=\"http://www.reddit.com/static/spreddit7.gif\" alt=\"Submit To Reddit!\" border=\"0\" />";
			}
			print "</a>";
		}
		else{
		
		}
	}

?>
			
