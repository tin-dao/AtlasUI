<?php

	function audio($type, $url, $preload = true){
		
		$preloadValue = str_replace(array(true, false), array("auto", "none"), $preload);
		
		print "<audio type=\"audio/$type\" controls=\"controls\" src=\"$url\" preload=\"$preloadValue\"></audio>";
	}
	
	function spotifyPlay($spotifyUrl, $spotifyPlayerSize = "large", $spotifyPlayerTheme = "black", $spotifyPlayerView = "list"){
		if (isset($spotifyUrl)){
			if ($spotifyPlayerSize !== "large"){
				$spotifyPlayerHeight = "80";
				$spotifyPlayerTheme = "black";
				$spotifyPlayerView = "list";
			}
			else{
				$spotifyPlayerHeight = "380";
			}
			print "<iframe src=\"https://embed.spotify.com/?uri=$spotifyUrl&theme=$spotifyPlayerTheme&view=$spotifyPlayerView\" ";
				print "width=\"300\" height=\"$spotifyPlayerHeight\" frameborder=\"0\" allowtransparency=\"true\">";
			print "/iframe>";
		}
		else{
			print "error_empty_spotifyurl";
		}		 
	}

?>
