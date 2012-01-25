<?php

	function evovid_badge($username){

		print "<iframe src=\"http://evovid.com/apis/badge?u=" . $username . "\" width=\"250px\" height=\"120px\" frameborder=\"0\"></iframe>";

	}

	function evovid_video($vidid, $height, $width){

		print "<iframe src=\"http://evovid.com/embed?id=" . $vidid . "\" height=\"";
		if ($height == "")
		{
			print "500px\"";
		}
		else{
			print $height . "px\"";
		}
		if ($width == "")
		{
			print "width=\"500px\"";
		}
		else{
			print "width=\"" . $width . "px\"";
		}
		
		print "frameborder=\"0px\"></iframe>";

	}

?>
