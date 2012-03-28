<!DOCTYPE html>
<html
	xmlns="http://www.w3.org/1999/xhtml"
	xmlns:og="http://ogp.me/ns#"
	prefix="bibo: http://purl.org/ontology/bibo/
		cal: http://www.w3.org/2002/12/cal/ical#
		dc: http://purl.org/dc/terms/
		foaf: http://xmlns.com/foaf/0.1/"
>
	<head>
			<link rel="stylesheet" type="text/css" href="Framework/all.css" />
			<link rel="stylesheet" type="text/css" href="Framework/custom.css" />
	</head>
	<body>
		<!-- AtlasUI Web Framework is 100% free as in freedom and 100% free as in cost, licensed under the FreeSoft Licensing.
			To view the licensing, go to http://freesoft.aosdt.com. To download and distribute your own
			copy of AtlasUI Web Framework, go to http://github.com/JoshStrobl/AtlasUI for more information -->
	
		<?php
			
			error_reporting(E_ERROR | E_WARNING | E_PARSE);
			
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
				include("browser/ymp_install.php");
			
			/* Import Math Framework / Library */
		  
				include("math/alibmath.php");

			/* Import Modular Communication Framework & Other Plugins */

				include("plugins/atlasui_encrypt.php");
				include("plugins/atlasui_ftp_login.php");
				include("plugins/atlasui_ip_address.php");
				include("plugins/atlasui_sql_connect.php");
				include("plugins/atlasui_string_clean.php");
				include("plugins/atlasui_url_address.php");
				include("plugins/ekiga_button.php"); // Wrapper for Ekiga.Net JavaScript button to determine status of Ekiga.Net user.
				include("plugins/opengraph.php");
				include("plugins/google_maps_static.php");
				include("plugins/paypal.php");
				include("plugins/powered_by.php"); // Powered by AtlasUI Web Framework banner - integration is completely optional of course //

			/* Import Social Network Framework */

				include("social/facebook.php");
				include("social/flattr_button.php");
				include("social/google_buzz.php");
				include("social/google_plus_badge.php");
				include("social/google_plus_one.php");
				include("social/evovid.php");
				include("social/reddit.php");
				include("social/spotify.php");
				include("social/twitter.php");
				include("social/youtube.php");

		?>
		
	</body>
</html>
