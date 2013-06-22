<?php

	function atlasui_opengraph($title, $description, $site_name, $type, $url, $image){
		print "<meta property=\"og:title\" content=\"$title\" />";
		
		if ($description !== ""){
			print "<meta property=\"og:description\" content=\"$description\" />";
		}		
		
		if ($site_name !== ""){
			print "<meta property=\"og:site_name\" content=\"$site_name\" />";
		}
		
		// Determines if the type is actually a location or not as no OpenGraph type is more than 15 characters long
		if (strlen($type)){
			print "<meta property=\"og:type\" content=\"$type\" />";
		}
		else{
			$locationExplode = explode("|", $type, 5);
			list($streetAddress, $locality, $region, $postalCode, $countryName) = $locationExplode;

			print "<meta property=\"og:street-address\" content=\"$streetAddress\" />";
			print "<meta property=\"og:locality\" content=\"$locality\" />";
			print "<meta property=\"og:region\" content=\"$region\" />";
			print "<meta property=\"og:postal-code\" content=\"$postalCode\" />";
			print "<meta property=\"og:country-name\" content=\"$countryName\" />";			
		}
		
		if ($url !== "dynamic"){
			print "<meta property=\"og:url\" content=\"$url\" />";
		}
		else{
			$url = atlasui_url_address("", false);
			print "<meta property=\"og:url\" content=\"$url\" />";
		}
		
		if ($image !== ""){
			print "<meta property=\"og:image\" content=\"$image\" />";
		}
	}

?>
