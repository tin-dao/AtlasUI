<?php

	function google_static_map($street_address, $city, $state, $country, $width, $height, $type, $marker)
	{
		$location = $street_address . ", " . $city . ", " . $state . ", " . $country;
		
		$width = str_replace("px", "", $width);
		$height = str_replace("px", "", $height);
		
		if ($width == "")
		{
			$width == "400";
		}
		else{
			$width = $width;
		}
		if ($height == "")
		{
			$height = "250";
		}
		else{
			$height = $height;
		}
		
		if ($marker == "")
		{
			$size = "normal";
			$color = "blue";
		}
		else{
			$explodemarker = explode("|", $marker);
			$size = $explodemarker["0"];
			$color = $explodemarker["1"];
		}
		
		print "<img src=\"http://maps.google.com/maps/api/staticmap?center=" . $location . "&zoom=16&size=" . $width . "x" . $height . "&maptype=" . $type . "&markers=size:" . $size . "|color:" . $color . "|" . $street_address . "," . $state ."\
&markers=size:" . $size . "|color:" . $color . "|label:A|" . $city . "," . $state . "&sensor=false\">";

	}
	
?>
