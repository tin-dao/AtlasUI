<?php

	function google_plus_badge($id, $size)
	{
		if ($id !== "")
		{
			print "<head>";
				print "<link href=\"https://plus.google.com/$id\" rel=\"publisher\" />";
				print "<script type=\"text/javascript\" src=\"https://apis.google.com/js/plusone.js\"></script>";
				
				if ($size == "small")
				{
					$badgeSize = "smallbadge";
				}
				else{
					$badgeSize = "badge";
				}
				
				print "<div class=\"g-plus\" data-href=\"https://plus.google.com/$id\" data-size=\"$badgeSize\"></div>";
		}
		else{
			print "Add a Google+ <b>Page</b> ID.";
		}
	}
	
?>