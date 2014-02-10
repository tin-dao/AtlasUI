<?php

	function google_static_map($street_address, $city, $state, $country, $width = "400", $height = "250", array $marker = null){
		$location = $street_address . ", " . $city . ", " . $state . ", " . $country;
		
		$width = str_replace("px", "", $width);
		$height = str_replace("px", "", $height);

		if ($marker == null)	{
			$size = "normal";
			$color = "blue";
		}
		else{
			$size = $marker[0];
			$color = $marker[1];
		}
		
		print "<img src=\"http://maps.google.com/maps/api/staticmap?center=" . $location . "&zoom=16&size=" . $width . "x" . $height . "&markers=size:" . $size . "|color:" . $color . "|" . $location ."
		&sensor=false\">";

	}
	
?>
