<?php

	function audio($type, $url, $preload = true){
		
		$preloadValue = str_replace(array(true, false), array("auto", "none"), $preload);
		
		print "<audio type=\"audio/$type\" controls=\"controls\" src=\"$url\" preload=\"$preloadValue\"></audio>";
	}

?>