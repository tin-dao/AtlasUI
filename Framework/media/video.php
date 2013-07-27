<?php

	function video($type, $url, $preload = true, $videoHeight = 480, $videoWidth = 640){
		$preloadValue = str_replace(array(true, false), array("auto", "none"), $preload);
		
		print "<video type=\"video/$type\" controls=\"controls\" preload=\"$preloadValue\" height=\"" . $videoHeight . "px\" width=\"" . $videoWidth . "px\">";
			print "Your browser does not support HTML5 video.";
		print "</video>";
	}

?>