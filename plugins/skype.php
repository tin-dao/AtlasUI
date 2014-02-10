<?php

	function skype($username, $chatOrCall){
		if ($chatOrCall == ("call" || "chat")){
			print "<a href=\"skype:$username?$chatOrCall\">";
				if ($chatOrCall == "call"){
					print "<img src=\"http://download.skype.com/share/skypebuttons/buttons/call_blue_white_124x52.png\" border=\"0\" />";
				}
				else{
					print "<img src=\"http://download.skype.com/share/skypebuttons/buttons/chat_blue_white_164x52.png\" border=\"0\" />";
				}
			print "</a>";
		}
	}
?>