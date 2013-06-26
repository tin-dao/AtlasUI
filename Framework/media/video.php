<?php

	function video($type, $url, $preload = true, $videoHeight = 480, $videoWidth = 640){
		$preloadValue = str_replace(array(true, false), array("auto", "none"), $preload);
		
		print "<video type=\"video/$type\" controls=\"controls\" preload=\"$preloadValue\" height=\"" . $videoHeight . "px\" width=\"" . $videoWidth . "px\">";
			print "Your browser does not support HTML5 video.";
		print "</video>";
	}
  
 	function youtubePlayer($youtubeVideoID, $youtubeVideoDefinition = "720", $youtubePrivacyMode = false){
		if ((isset($youtubeVideoID)) && (strlen($youtubeVideoID) > 0)){
			$youtubeVideoDefinition_Height = str_replace(array("360", "480", "720"), array("640", "853", "1280"), $youtubeVideoDefinition);
			print "<iframe width=\"$youtubeVideoDefinition\" width=\"$youtubeVideoDefinition\" height=\"$youtubeVideoDefinition_Height\" ";

				if ($youtubePrivacyMode == false){
					$youtubeEmbedUrl = "https://www.youtube.com/embed/" . $youtubeVideoID;
				}
				else{
					$youtubeEmbedUrl = "https://www.youtube-nocookie.com/embed/" . $youtubeVideoID;
				}

				print "src=\"$youtubeEmbedUrl?rel=0\" frameborder=\"0\" allowfullscreen>";
			print "</iframe>";
		}
		else{
			print "error_no_youtube_id";
		}
	}

?>
