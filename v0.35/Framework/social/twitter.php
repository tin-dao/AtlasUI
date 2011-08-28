<?php

	function twitter_follow($user)
	{

		print "<iframe allowtransparency=\"true\" frameborder=\"0\" scrolling=\"no\"
  src=\"http://platform.twitter.com/widgets/follow_button.html?screen_name=" . $user . "\"
  style=\"width:300px; height:20px;\"></iframe>";

	}

	function twitter_tweet($url, $via, $tweet_text){

		print "<iframe allowtransparency=\"true\" frameborder=\"0\" scrolling=\"no\"
  src=\"http://platform.twitter.com/widgets/tweet_button.html?screen_name=$via&amp;";
		if ($url !== "page_url")
		{
			$stripcolons = str_replace(":","%3A", $url);
			$tweeturl = str_replace("/","%2F", $stripcolons);
			print "url=$tweeturl";
		}
		else{
			$url = $_SERVER["SERVER_NAME"].$_SERVER["REQUEST_URI"];
			$stripcolons = str_replace(":", "%3A", $url);
			$tweeturl = str_replace("/","%2F", $stripcolons);
			print "url=$tweeturl";
		}
		if ($tweet_text == "")
		{
			print "&amp;related=AtlasUI\"";
		}
		else{
			print "&amp;text=$tweet_text&amp;related=AtlasUI\" ";
		}
		print "style=\"width:300px; height:20px;\"></iframe>";

	}

?>
