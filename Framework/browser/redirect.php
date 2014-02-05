<?php

	function atlasui_redirect($url, $seconds = 0.5){

		if ($seconds < 0.5){
			$seconds = 0.5;
		}

		print "<meta http-equiv=\"refresh\" content=\"" . $seconds . ";url=" . $url . "\" />";
	}

?>
