<?php

	function reddit($shareUrl = ""){
		if ($shareUrl == ""){
			$shareUrl = atlasui_url_address("", true);
		}
		else{
			$shareUrl = atlasui_url_address($shareUrl, true);
		}

		print "<a href=\"http://www.reddit.com/submit?url=$shareUrl>";
			print "<img src=\"http://www.reddit.com/static/spreddit7.gif\" alt=\"Submit To Reddit!\" border=\"0\" />";
		print "</a>";
	}

?>