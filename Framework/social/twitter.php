<?php

	function twitter_follow($user){
		print "<iframe allowtransparency=\"true\" frameborder=\"0\" scrolling=\"no\"
  			src=\"http://platform.twitter.com/widgets/follow_button.html?screen_name=" . $user . "\"
  			style=\"width:300px; height:20px;\">
  		</iframe>";
	}

	function twitter_tweet($shareUrl = "", $twitterVia = "", $twitterTweet = ""){
		if (isset($twitterVia)){
			print "<a href=\"https://twitter.com/share\" class=\"twitter-share-button\" ";

				if ($shareUrl !== ""){
					print "data-url=\"$shareUrl\" ";
				}

				print "data-via=\"$twitterVia\" ";
				print "data-related=\"$twitterVia\"";
			print ">Tweet</a>";
			print "<script>!function(d,s,id){var js,fjs=d.getElementsByTagName(s)[0];if(!d.getElementById(id)){js=d.createElement(s);js.id=id;js.src=\"//platform.twitter.com/widgets.js\";fjs.parentNode.insertBefore(js,fjs);}}(document,\"script\",\"twitter-wjs\");</script>";
		}
	}

	function twitter_profile($profile, $width, $height, $shell_bg, $shell_text, $tweets_bg, $tweets_text, $tweets_links, $show_hashtags, $show_timestamps, $show_avatars)
	{
		print "<script src=\"http://widgets.twimg.com/j/2/widget.js\"></script>";
		print "<script>";
		print "
			new TWTR.Widget({
			  version: 2,
			  type: 'profile',
			  rpp: 4,
			  interval: 30000,";
		if ($width == "")
		{
			print "width: 250,";
		}
		else{
			print "width: $width,";
		}
		
		if ($height == "")
		{
			print "height: 300,";
		}
		else{
			print "height: $height,";
		}
		print "
			  theme: {
				shell: {";
		if ($shell_bg == "")
		{
			print "background: '#ffffff',";
		}
		else{
			print "background: '#$shell_bg',";
		}
		if ($shell_text == "")
		{
			print "color: '#0099ff'";
		}
		else{
			print "color: '#$shell_text'";
		}
		print "},
				tweets: {";
		
		if ($tweets_bg == "")
		{
			print "background: '#ffffff',";
		}
		else{
			print "background: '#$tweets_bg',";
		}
		
		if ($tweets_text == "")
		{
			print "color: '#333333',";
		}
		else{
			print "color: '#$tweets_text',";
		}
		
		if ($tweets_links == "")
		{
			print "links: '#0099ff'";
		}
		else{
			print "links: '#$tweets_links'";
		}
		print "
				}
			  },
			  features: {
				scrollbar: false,
				loop: false,
				live: false,";
		if ($show_hashtags == ("" || "yes" || "true"))
		{
			print "hashtags: true,";
		}
		else{
			print "hashtags: false,";
		}
		if ($show_timestamps == ("" || "yes" || "true"))
		{
			print "timestamp: true,";
		}
		else{
			print "timestamp: false,";
		}
		
		if ($show_avatars == ("" || "yes" || "true"))
		{
			print "avatars: true,";
		}
		else{
			print "avatars: false,";
		}
		
		print "
				behavior: 'all'
			  }
			}).render().setUser('$profile').start();";
		print "</script>";
	}
?>
