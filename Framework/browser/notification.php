<?php

	function atlasui_notification($title, $message){
		print "<link rel=\"stylesheet\" type=\"text/css\" href=\"Framework/all.css\" />";
		print "<div class=\"atlasui_notification\">";
			if ($title !== ""){
				print "<div id=\"atlasui_notification_title\">$title</div>";
			}
			else{
				print "<div id=\"atlasui_notification_title\">Notification</div>";
			}
			print "<div id=\"atlasui_notification_message\">$message</div>";
		print "</div>";
	}

?>
