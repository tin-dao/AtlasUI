<?php

	function youtube($vid_id, $hd_or_normal, $privacy_mode, $height, $width){

		print "<iframe width=\"";
		if ($width !== "")
		{
			print $width;
		}
		else{
			print "560\"";
		}
		if ($height !== "")
		{
			print "height=\"" . $height . "\"";
		}
		else{
			print "height=\"345\"";
		}

		print "src=\"";

		if ($privacy_mode == "true")
		{
			print "http://www.youtube-nocookie.com/embed/" . $vid_id;
		}
		else{
			print "http://www.youtube.com/embed/" . $vid_id;
		}
		if ($hd_or_normal == "normal")
		{
			print "\"";
		}
		else{
			print "?hd=1\"";
		}
		print "frameborder=\"0\" allowfullscreen></iframe>";

	}

?>