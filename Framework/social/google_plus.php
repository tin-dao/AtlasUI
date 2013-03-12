<?php

	function google_plus_asyncInclude(){
		print "<script type=\"text/javascript\">";
			print "(function() {";
		    	print "var po = document.createElement('script'); po.type = 'text/javascript'; po.async = true;";
		    	print "po.src = 'https://apis.google.com/js/plusone.js';";
		    	print "var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(po, s);";
		 	print ""})();";"
		print "</script>";
	}

	function google_plus_badge($googlePlusID, $googlePlusBadgeSize = "300"){
		if (isset($googlePlusID)){
			print "<div class=\"g-plus\" data-width=\"$googlePlusBadgeSize\" data-href=\"//plus.google.com/$googlePlusID\" data-rel=\"publisher\"></div>";
			google_plus_asyncInclude();
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

		google_plus_asyncInclude();
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
		google_plus_asyncInclude();
	}
	
?>