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

	function facebook_share($title, $description, $message, $app_id, $link, $same_dir)
	{
		$fbcompatibletitle = str_replace(" ", "%20", $title);
		$fbcompatibledescription = str_replace(" ", "%20", $description);
		$fbmessage = str_replace(" ", "%20", $message);

		if ($app_id !== "")
		{
			print "<a href=\"http://www.facebook.com/dialog/feed?app_id=$app_id&link=$link&name=$fbcompatibletitle";
			if ($fbcompatibledescription !== "")
			{
				print "&description=$fbcompatibledescription";
			}
			
			if ($fbmessage !== "")
			{
				print "&message=$fbmessage";
			}

			if ($same_dir == "true")
			{
				$path_to_image = "/images/social/facebook.png";
			}
			elseif ($same_dir == "separate_folder")
			{
				$path_to_image = "../Framework/images/social/facebook.png";
			}
			elseif ($same_dir == "sub_folder")
			{
				$path_to_image = "/Framework/images/social/facebook.png";
			}
			else{
				$path_to_image = $same_dir . "/images/social/facebook.png";
			}

			print "&redirect_uri=http://facebook.com\" target=\"_blank\"><img src=\"$path_to_image\" /></a>";
		}
		else{
			print "You need to add an App ID to facebook_share!";
		}
	}
?>
