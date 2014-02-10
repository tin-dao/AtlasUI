<?php

	// #region Facebook Commenting System
	function facebookComments($applicationID, $url = null, $colorScheme = "light", $width = 550){
		if ($applicationID !== null){
			print "<div class=\"fb-comments\"";
				if ($url == null){
					$url = atlasui_url_address();
				}

				print html5GlobalDataAttributes(array("href" => $url, "colorscheme" => $colorScheme, "width" => $width));
			print "</div>";
			facebookIncludeJSScript($applicationID);
		}
		else{
			print "add_appID";
		}
	}
	// #endregion

	// #region Facebook Embedded Post
	function facebookEmbeddedPost($applicationID, $facebookPost, $facebookPostWidth = 500){
		if (($applicationID !== null) && ($facebookPost !== null)){
			print "<div class=\"fb-post\" " . html5GlobalDataAttributes(array("href" => $facebookPost, "width" => $facebookPostWidth)) . "></div>";
			facebookIncludeJSScript($applicationID);
		}
		else{
			print "add_appID_and_fbpost";
		}
	}
	// #endregion

	// #region Facebook Facepile
	function facebookFacepile($applicationID, $facebookPage, $actions = "like", $maxRows = 2, $avatarSize = "medium", $colorScheme = "light", $showCount = false, $showBorder = false, $width = 200){
		if (($applicationID !== null) && ($facebookPage !== null)){
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
	// #endregion

	// #region Facebook Follow Button
	function facebookFollow($applicationID, $facebookUser, $colorScheme = "light", $buttonLayout = "standard", $showFaces = true, $width = 450){
		if (($applicationID !== null) && ($facebookUser !== null)){
			print "<div class=\"fb-follow\"";
				$fbGlobalAttributes = html5GlobalDataAttributes(
					array(
						"href" => "https://www.facebook.com/" . $facebookUser, "colorscheme" => $colorScheme, 
						"show-faces" => $showFaces, "width" => $width
					)
				);
				
				print $fbGlobalAttributes;
				
				if (atlasui_string_check($buttonLayout, array("standard", "button_count", "box_count")) !== false){
					print html5GlobalDataAttributes(array("layout" => $buttonLayout));
				}
			print ">";
			print "</div>";
			
			facebookIncludeJSScript($applicationID);
		}
		else{
			print "add_appID_and_fbuser";
		}
	}
	// #endregion

	// #region Facebook Like Embeds
		// #region Facebook Like Button
			function facebookLikeButton($applicationID, $likeUrl = null, $likeVerb = "like", $colorScheme = "light", $buttonLayout = "standard", $showFaces = false, $width = 450){
		if ($applicationID !== null){
			print "<div class=\"fb-like\" ";
				if ($likeUrl == null){
					$likeUrl = atlasui_url_address();
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
		// #endregion

		// #region Facebook Like Box
			function facebookLikeBox($applicationID, $facebookPage, $colorScheme = "light", $showBorder = true, $showFaces = true, $showStream = true, $showHeader = true, $height = 556, $width = 292){
		if (($applicationID !== null) && ($facebookPage !== null)){
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
		// #endregion
	// #endregion

	// #region Facebook Send Button
		function facebookSendButton($applicationID, $url = null, $colorScheme = "light", $kidSite = false){
			if ($applicationID !== null){
				if ($url == null){
					$url = atlasui_url_address();
				}

				print "<div class=\"fb-send\"";
					print html5GlobalDataAttributes(array("colorscheme" => $colorScheme, "href" => $url, "kid-directed-site" => $kidSite));
				print "</div>";
			}
			else{
				print "add_appID";
			}
		}
	// #endregion

?>