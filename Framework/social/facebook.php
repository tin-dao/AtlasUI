<?php

	function facebook_like($set_or_dynamic_url, $url, $width){

		print "<iframe src=\"http://www.facebook.com/plugins/like.php?app_id=183840781689259&amp;";
		if ($set_or_dynamic_url == "set")
		{
			$stripcolons = str_replace(":","%3A", $url);
			$fburl = str_replace("/","%2F", $stripcolons);
			print "href=$fburl";
		}
		elseif ($set_or_dynamic_url == "dynamic")
		{
			$fburl = atlasui_url_address("yes");
			print "href=$fburl";
		}
		if ($width == "")
		{
			print "&amp;send=false&amp;layout=standard&amp;width=450&amp;show_faces=true&amp;action=like&amp;colorscheme=light&amp;font=segoe+ui&amp;height=80\" scrolling=\"no\" frameborder=\"0\" style=\"border:none; overflow:hidden; width:450px; height:80px;\" allowTransparency=\"true\"></iframe>";
		}
		else{
			print "&amp;send=false&amp;layout=standard&amp;width=" . $width . "&amp;show_faces=true&amp;action=like&amp;colorscheme=light&amp;font=segoe+ui&amp;height=80\" scrolling=\"no\" frameborder=\"0\" style=\"border:none; overflow:hidden; width:" . $width . "px; height:80px;\" allowTransparency=\"true\"></iframe>";
		}

	}

?>
