<?php

	function atlasui_opengraph($title, $description, $site_name, $type, $url = null, $image = null){
		print "<meta property=\"og:title\" content=\"$title\" />";
		print "<meta property=\"og:description\" content=\"$description\" />";
		print "<meta property=\"og:site_name\" content=\"$site_name\" />";

		if (gettype($type) == "string"){ // If the OpenGraph type is defined as a string
			print "<meta property=\"og:type\" content=\"$type\" />";
		}
		else{
			list($streetAddress, $locality, $region, $postalCode, $countryName) = $type; // If is defined as an array, then assume location info.

			print "<meta property=\"og:street-address\" content=\"$streetAddress\" />";
			print "<meta property=\"og:locality\" content=\"$locality\" />";
			print "<meta property=\"og:region\" content=\"$region\" />";
			print "<meta property=\"og:postal-code\" content=\"$postalCode\" />";
			print "<meta property=\"og:country-name\" content=\"$countryName\" />";			
		}
		
		if ($url == null){ // If the URL is NOT defined, generate it. Else, use defined one.
			$url = atlasui_url_address();
		}

		print "<meta property=\"og:url\" content=\"$url\" />";

		if ($image !== null){ // If an OpenGraph image is defined, use it.
			print "<meta property=\"og:image\" content=\"$image\" />";
		}
	}

?>
