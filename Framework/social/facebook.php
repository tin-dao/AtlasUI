<?php

	function facebook_like($applicationID, $shareUrl = false, $buttonColors = "light", $buttonLayout = "button_count", $buttonSend = "false", $buttonShowFaces, "false", $buttonHeight = "21", $buttonWidth = "55"){
		if (strlen($applicationID) > 0){
			print "<iframe src=\"//www.facebook.com/plugins/like.php?href=";

				if ($shareUrl === false){
					$shareUrl = atlasui_url_address();
				}
				else{
					$shareUrl = atlasui_url_address($shareUrl, true);
				}

				print "$shareUrl&amp;send=$buttonSend&amp;layout=$buttonLayout&amp;width=$buttonWidth&amp;show_faces=$buttonShowFaces&amp;font=segoe+ui&amp;colorscheme=$buttonColors&amp;action=like&amp;height=21&amp;appId=$applicationID\" 
					scrolling=\"no\" frameborder=\"0\" style=\"border:none; overflow:hidden; width:$buttonWidth" . "px; height:$buttonHeight" . "px;\" allowTransparency=\"true\">";
			print "</iframe>";
		}
		else{
			print "error_empty_appid";
		}
	}

	function facebook_share($applicationID, $shareTitle, $shareDescription = "", $shareUrl = false){
		if (isset($applicationID)){
			$fbTitle = str_replace(" ", "%20", $shareTitle);
			$fbSescription = str_replace(" ", "%20", $description);

			if ($shareUrl === false){
				$shareUrl = atlasui_url_address("", false);
			}

			print "<a href=\"http://www.facebook.com/dialog/feed?app_id=$applicationID&link=$shareUrl&name=$fbTitle";
				if ($fbDescription !== "")
				{
					print "&description=$fbDescription";
				}
				
				print "&redirect_uri=$shareUrl\" target=\"_blank\"";
				print "style=\"
					height: 28px;
					width: 75px;
					font-family: arial;
					font-size: 14px;
					color: #fafafa;
					line-height: 28px;
					text-align: center;
					text-decoration: none;
					background-color: #3b5998 !important;
					border: 0px;\"";
			print ">Share</a>";
		}
		else{
			print "error_empty_appid";
		}
	}
	
?>