<!DOCTYPE html>
<html xmlns:og="http://ogp.me/ns#">
	<head>
			<link rel="stylesheet" type="text/css" href="../all.css" />
			<link rel="stylesheet" type="text/css" href="../custom.css" />
			<link rel="stylesheet" type="text/css" href="../Framework/all.css" />
			<link rel="stylesheet" type="text/css" href="../Framework/custom.css" />
			<link rel="stylesheet" type="text/css" href="Framework/all.css" />
			<link rel="stylesheet" type="text/css" href="Framework/custom.css" />
			<meta http-equiv="X-UA-Compatible" content="chrome=1">
	</head>
	<body>
		<!-- AtlasUI Web Framework is 100% free as in freedom and 100% free as in cost, licensed under the FreeSoft Licensing.
			To view the licensing, go to http://freesoft.aosdt.com. To download and distribute your own
			copy of AtlasUI Web Framework, go to http://github.com/JoshStrobl/AtlasUI for more information -->
	
		<?php
		  /* Import Audio and Video Framework */

			include("media/atlasui_cc_buttons.php");
			include("media/audio.php");
			include("media/video.php");
			
		  /* Import AtlasUI Drawing and Graphics Framework */
			
			include("drawing/draw_heart.php");

		  /* Import AtlasUI Main Modules */

			include("main/contactform.php");
			include("main/menubar.php");
			include("main/module.php");
			include("main/search.php");
			include("main/topbar.php");

		  /* Import AtlasUI Browser Interaction Modules */
			
			include("browser/notification.php");
			include("browser/redirect.php");
			
		  /* Import Math Framework / Library */
		  
			include("math/alibmath.php");

		  /* Import Modular Communication Framework & Other Plugins */

			include("plugins/atlasui_encrypt.php");
			include("plugins/atlasui_ftp_login.php");
			include("plugins/atlasui_sql_connect.php");
			include("plugins/atlasui_url_address.php");
			include("plugins/opengraph.php");
			include("plugins/google_maps_static.php");
			include("plugins/paypal.php");
			include("plugins/powered_by.php"); // Powered by AtlasUI Web Framework banner - integration is completely optional of course //

		  /* Import Social Network Framework */

			include("social/facebook.php");
			include("social/flattr_button.php");
			include("social/google_plus_one.php");
			include("social/google_buzz.php");
			include("social/evovid.php");
			include("social/reddit.php");
			include("social/spotify.php");
			include("social/twitter.php");
			include("social/youtube.php");

		?>
		
	</body>
</html>
