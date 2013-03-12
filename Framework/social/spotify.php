<?php

	function spotifyFollow($username){
		print "<a href=\"http://open.spotify.com/user/$username\">";
			print "<img alt=\"Follow me on Spotify\" src=\"https://d2c87l0yth4zbw.cloudfront.net/i/social-badge-en.png\" title=\"Follow me on Spotify\">";
		print "</a>";
	}

	function spotifyPlay($spotifyUrl, $spotifyPlayerSize = "large", $spotifyPlayerTheme = "black", $spotifyPlayerView = "list"){
		if (isset($spotifyUrl)){
			if ($spotifyPlayerSize !== "large"){
				$spotifyPlayerHeight = "80";
				$spotifyPlayerTheme = "black";
				$spotifyPlayerView = "list";
			}
			else{
				$spotifyPlayerHeight = "380";
			}
			print "<iframe src=\"https://embed.spotify.com/?uri=$spotifyUrl&theme=$spotifyPlayerTheme&view=$spotifyPlayerView\" ";
				print "width=\"300\" height=\"$spotifyPlayerHeight\" frameborder=\"0\" allowtransparency=\"true\">";
			print "/iframe>";
		}
		else{
			print "error_empty_spotifyurl";
		}		 
	}
	
?>