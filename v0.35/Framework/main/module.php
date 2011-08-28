<?php

	function module($height, $width, $class_or_theme, $title, $code){

		if ($class_or_theme == "elegant")
		{
			print "<div class=\"elegant_module\" ";
		}
		elseif ($class_or_theme == ("minimalistic" || "minimal"))
		{
			print "<div class=\"minimalistic_module\" ";
		}
		elseif ($class_or_theme !== ("elegant" || "minimalistic" || "minimal"))
		{
			print "<div class=\"$class_or_theme\" ";
		}
		if ($height && $width !== "")
		{
			print "style=\"height: $height" . "px; width: $width". "px;\">";
		}
		else{
			print "style=\"height: 400px; width: 400px;\">";
		}
			if ($title !== "")
			{
				print "<label>$title</label>";
			}
			else{

			}
			if ($code !== "")
			{
				print $code;
			}
			else{

			}
		print "</div>";
	}

?>
