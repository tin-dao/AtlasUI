<?php

	function google_plus_share($annotationType, $size, $url){
		if ($url !== ""){
			if ($url == "dynamic"){
				$url = atlasui_url_address("yes");
			}
			
			print "<script type=\"text/javascript\" src=\"https://apis.google.com/js/plusone.js\"></script>";
			print "<div class=\"g-plus\" data-action=\"share\" data-annotation=\$annotationType\" data-height=\"$size\"></div>";
			
		}
	}
?>
