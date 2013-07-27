<?php

	function google_plus_badge($googlePlusID, $googlePlusBadgeSize = "300"){
		if (isset($googlePlusID)){
			print "<div class=\"g-plus\" data-width=\"$googlePlusBadgeSize\" data-href=\"//plus.google.com/$googlePlusID\" data-rel=\"publisher\"></div>";
			googleIncludeJSScript();
		}
		else{
			print "error_invalid_id";
		}
	}

	function google_plus_one($shareUrl = "", $googlePlusAnnotation = "bubble", $googlePlusSize = "normal", $googlePlusWidth = "120"){
		if ($shareUrl == ""){
			$shareUrl = atlasui_url_address();
		}

		print "<div class=\"g-plusone\"";
		if ($googlePlusAnnotation !== "bubble"){
			print "data-annotation=\"$googlePlusAnnotation\" data-width=\"$googlePlusWidth\" ";
		}

		print "data-href=\"$shareUrl\"></div>";

		googleIncludeJSScript();
	}

	function google_plus_share($shareUrl = "", $googlePlusAnnotation = "horizontal", $googlePlusSize = "medium", $googlePlusWidth = "120"){
		if ($shareUrl == ""){
			$shareUrl = atlasui_url_address();
		}

		print "<div class=\"g-plusone\"";

		if ($googlePlusAnnotation !== "horizontal"){
			print "data-annotation=\"vertical-bubble\" data-width=\"$googlePlusWidth\" ";
		}

		if ($googlePlusSize !== "medium"){
			$googlePlusSize = str_replace(array("small", "large"), array("16", "24"), $googlePlusSize);
			print "data-height=\"$googlePlusSize\" ";
		}

		print "data-href=\"$shareUrl\"></div>";
		googleIncludeJSScript();
	}
	
?>