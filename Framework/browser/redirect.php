<?php

	function redirect($url, $seconds){

		if ($seconds < "0.5")
		{
			$seconds = "0.5";
		}
		else{
			$seconds = $seconds;
		}
		print "<meta http-equiv=\"refresh\" content=\"" . $seconds . ";url=" . $url . "\" />";
		print "Redirecting...";
	}

?>
