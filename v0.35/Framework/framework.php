<!DOCTYPE html>

<?php

  /* Import Framework Stylesheets */

    print "<link rel=\"stylesheet\" type=\"text/css\" href=\"/Framework/all.css\" />";
    print "<link rel=\"stylesheet\" type=\"text/css\" href=\"/Framework/custom.css\" />";
    print "<link rel=\"stylesheet\" type=\"text/css\" href=\"../Framework/all.css\" />";
    print "<link rel=\"stylesheet\" type=\"text/css\" href=\"../Framework/custom.css\" />";

  /* Import Audio and Video Framework */

    include("media/audio.php");
    include("media/video.php");

  /* Import AtlasUI Main Modules */

    include("main/module.php");
    include("main/search.php");
    include("main/topbar.php");

  /* Import AtlasUI Browser Interaction Modules */
    
    /* To be included on a further date - include("browser/notification.php"); */

    include("browser/redirect.php");

  /* Import Modular Communication Framework */

  /* Import Social Network Framework */

    include("social/facebook.php");
    include("social/evovid.php");
	include("social/reddit.php");
    include("social/twitter.php");
    include("social/youtube.php");

?>
