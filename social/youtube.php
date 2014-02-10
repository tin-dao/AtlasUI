<?php

 	function youtubePlayer($youtubeVideoID, $youtubeVideoDefinition = 720, $youtubePrivacyMode = false){
		if ($youtubeVideoID !== null){
			$youtubeVideoDefinition_Width = round(($youtubeVideoDefinition * 1.777), 0, PHP_ROUND_HALF_UP);
			print "<iframe width=\"$youtubeVideoDefinition_Width\" width=\"$youtubeVideoDefinition_Width\" height=\"$youtubeVideoDefinition\" ";

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
	
	function youtubeSubscribe($youtubeChannel, $layout = "full", $theme = "light"){
		if (isset($youtubeChannel)){
			print "<div class=\"g-ytsubscribe\"";
			
				$dataAttributes = html5GlobalDataAttributes(
					array("channel" => $youtubeChannel, "layout" => $layout, "theme" => $theme)
				);
				print $dataAttributes;
			
			print ">";
			print "</div>";
			
			googleIncludeJSScript();
		}
		else{
			print "error_no_youtube_channel";
		}
	}
?>