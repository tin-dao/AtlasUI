<?php

	function twitter_follow($user){
		print "<iframe allowtransparency=\"true\" frameborder=\"0\" scrolling=\"no\"
  			src=\"https://platform.twitter.com/widgets/follow_button.html?screen_name=" . $user . "\"
  			style=\"width:300px; height:20px;\">
  		</iframe>";
	}

	function twitter_profile($profile, $widgetID, $width = 250, $height = 300, $themeColor = "light", $tweetsLinkColor = "#0099ff", $language = "EN"){
		print "<a class=\"twitter-timeline\" href=\"https://twitter.com/twitterapi\" width=\"$width\" height=\"$height\" lang=\"$language\" ";
		print html5GlobalDataAttributes(
			array(
				"widget-id" => $widgetID,
				"theme" => $themeColor,
				"link-color" => $tweetsLinkColor,
				"related" => $profile,
				"aria-polite" => "assertive"
			)
		);
		print ">";
		print "Tweets by $profile";
		print "</a>";

		print "<script src=\"https://platform.twitter.com/widgets.js\"></script>";
	}

	function twitter_tweet($twitterVia = "", $twitterTweet = ""){
		if (($twitterVia !== null) && ($twitterTweet !== null)){
			print "<a href=\"https://twitter.com/share\" class=\"twitter-share-button\" ";
				print html5GlobalDataAttributes(array("via" => $twitterVia, "related" => $twitterVia, "text" => $twitterTweet));
			print ">Tweet</a>";
			print "<script src=\"https://platform.twitter.com/widgets.js\"></script>";
		}
	}

?>