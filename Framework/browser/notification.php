<?php

	function notification($title, $message)
	{
		print "<div class=\"atlasui_notification\">";
			if ($title !== "")
			{
				print "<div id=\"atlasui_notification_title\">$title</div>";
			}
			else{
				print "<div id=\"atlasui_notification_title\">Notification</div>";
			}
			print "<div id=\"atlasui_notification_message\">$message</div>";
		print "</div>";
	}
	
?>
