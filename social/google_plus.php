<?php

	function google_plus_badge($googlePlusID, $googlePlusBadgeSize = 300){
		if (isset($googlePlusID)){
			print "<div class=\"g-plus\" data-width=\"$googlePlusBadgeSize\" data-href=\"//plus.google.com/$googlePlusID\" data-rel=\"publisher\"></div>";
			googleIncludeJSScript();
		}
		else{
			print "error_invalid_id";
		}
	}

	function google_plus_one($url = null, $annotation = "bubble", $size = "normal", $width = 120){
		if ($url == null){
			$url = atlasui_url_address();
		}

		print "<div class=\"g-plusone\"";
			print html5GlobalDataAttributes(array("annotation" => $annotation, "size" => $size, "width" => $width, "href" => $url));
		print "</div>";

		googleIncludeJSScript();
	}
	
?>