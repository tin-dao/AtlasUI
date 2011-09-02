<?php

	function topbar($class_or_theme, $code){

		if ($class_or_theme == "elegant")
		{
			print "<div class=\"elegant_topbar\">";
		}
		elseif ($class_or_theme == ("minimalistic" || "minimal"))
		{
			print "<div class=\"minimalistic_topbar\">";
		}
		elseif ($class_or_theme !== ("elegant" || "minimalistic" || "minimal"))
		{
			print "<div class=\"$class_or_theme\">";
		}
			print $code;
		
		print "</div>";

	}

?>
