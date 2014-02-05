<?php

	function reddit($url = ""){
		if ($url == ""){
			$url = atlasui_url_address("", true);
		}
		else{
			$url = atlasui_url_address($url, true);
		}

		print "<a href=\"http://www.reddit.com/submit?url=$url>";
			print "<img src=\"http://www.reddit.com/static/spreddit7.gif\" alt=\"Submit To Reddit!\" border=\"0\" />";
		print "</a>";
	}

?>