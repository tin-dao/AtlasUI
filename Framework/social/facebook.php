<?php

	function facebookEmbeddedPost($applicationID, $facebookPost){
		if ((isset($applicationID)) && (strlen($facebookPost) > 0)){
			print "<div class=\"fb-post\" ";
				$fbGlobalAttributes = html5GlobalDataAttributes(
					array(
						"href" => $facebookPost
					)
				);
				print $fbGlobalAttributes;
			print ">";
			print "</div>";
			
			facebookIncludeJSScript($applicationID);
		}
		else{
			print "add_appID_and_fbpost";
		}
	}
	
	function facebookFacepile($applicationID, $facebookPage, $actions = "like", $maxRows = 2, $avatarSize = "medium", $colorScheme = "light", $showCount = false, $showBorder = false, $width = 200){
		if ((isset($applicationID)) && (strlen($facebookPage) > 0)){
			print "<div class=\"fb-facepile\"";
				$fbGlobalAttributes = html5GlobalDataAttributes(
					array(
						"href" => "https://www.facebook.com/" . $facebookPage, "action" => $actions, "max-rows" => $maxRows, "size" => $avatarSize,
						 "colorscheme" => $colorScheme, "show-count" => $showCount, "show-border" => $showBorder, "width" => $width
					)
				);
				print $fbGlobalAttributes;
			print ">";
			print "</div>";
			
			facebookIncludeJSScript($applicationID);
		}
		else{
			print "add_appID_and_fbpage";
		}
	}

	function facebookFollow($applicationID, $facebookUser, $colorScheme = "light", $buttonLayout = "standard", $showFaces = true, $width = 450){
		if ((isset($applicationID)) && (strlen($facebookUser) > 0)){
			print "<div class=\"fb-follow\"";
				$fbGlobalAttributes = html5GlobalDataAttributes(
					array(
						"href" => "https://www.facebook.com/" . $facebookUser, "colorscheme" => $colorScheme, 
						"show-faces" => $showFaces, "width" => $width
					)
				);
				
				print $fbGlobalAttributes;
				
				if (atlasui_string_check($buttonLayout, array("standard", "button_count", "box_count")) !== false){
					print "data-layout=\"" . $buttonLayout . "\"";
				}
			print ">";
			print "</div>";
			
			facebookIncludeJSScript($applicationID);
		}
		else{
			print "add_appID_and_fbuser";
		}
	}
	
	function facebookLikeButton($applicationID, $likeUrl = "generate", $likeVerb = "like", $colorScheme = "light", $buttonLayout = "standard", $showFaces = false, $width = 450){
		if (isset($applicationID)){
			print "<div class=\"fb-like\" ";
				if ($likeUrl == "generate"){
					$likeUrl = atlasui_url_address("", false);
				}
				
				$fbGlobalAttributes = html5GlobalDataAttributes(
					array(
						"href" => $likeUrl, "action" => $likeVerb, "colorscheme" => $colorScheme, 
						"show-faces" => $showFaces, "font" => "segoe ui", "width" => $width
					)
				);
				print $fbGlobalAttributes;
				
				if (atlasui_string_check($buttonLayout, array("standard", "button_count", "box_count")) !== false){
					print "data-layout=\"" . $buttonLayout . "\"";
				}
			print ">";
			print "</div>";
			
			facebookIncludeJSScript($applicationID);
		}
		else{
			print "error_empty_appid";
		}
	}

	function facebookLikeBox($applicationID, $facebookPage, $colorScheme = "light", $showBorder = true, $showFaces = true, $showStream = true, $showHeader = true, $height = 556, $width = 292){
		if ((isset($applicationID)) && (strlen($facebookPage) > 0)){
			print "<div class=\"fb-like-box\"";
				$fbGlobalAttributes = html5GlobalDataAttributes(
					array(
						"href" => "https://www.facebook.com/" . $facebookPage, "colorscheme" => $colorScheme, "show-border" => $showBorder,
						"show-faces" => $showFaces, "show-stream" => $showStream, "show-header" => $showHeader, "height" => $height, "width" => $width
					)
				);
				print $fbGlobalAttributes;
			print ">";
			print "</div>";
			
			facebookIncludeJSScript($applicationID);
		}
		else{
			print "add_appID_and_fbpage";
		}
	}
	
?>