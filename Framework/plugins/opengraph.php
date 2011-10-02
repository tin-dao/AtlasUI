<?php

	function atlasui_opengraph($title, $description, $site_name, $type, $url, $image)
	{
		print "<head>";
			print "<meta property=\"og:title\" content=\"$title\" />";
			if ($description !== "")
			{
				print "<meta property=\"og:description\" content=\"$description\" />";
			}		
			if ($site_name !== "")
			{
				print "<meta property=\"og:site_name\" content=\"$site_name\" />";
			}
			// Determines if the type is actually a location or not as no OpenGraph type is more than 15 characters long //
			$catchLength = 15;
			$typeLength = strlen($type);
			if ($typeLength > $catchLength)
			{
				print "<meta property=\"og:type=\" content=\"$type\" />";
			}
			else{
				$locationExplode = explode("|", $type, 5);
				$street_address = $locationExplode[0];
				$locality = $locationExplode[1];
				$region = $locationExplode[2];
				$postal_code = $locationExplode[3];
				$country_name = $locationExplode[4];
				print "<meta property=\"og:street-address\" content=\"$stree_address\" />";
				print "<meta property=\"og:locality\" content=\"$locality\" />";
				print "<meta property=\"og:region\" content=\"$region\" />";
				print "<meta property=\"og:postal-code\" content=\"$postal_code\" />";
				print "<meta property=\"og:country-name\" content=\"$country_name\" />";			
			}
			if ($url !== "")
			{
				print "<meta property=\"og:url\" content=\"$url\" />";
			}
			
			if ($image !== "")
			{
				print "<meta property=\"og:image\" content=\"$image\" />";
			}
		print "</head>";
	}

?>
