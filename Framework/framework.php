<?php
	/* Import Audio and Video Framework */

		include("media/audio.php");
		include("media/video.php");

	/* Import AtlasUI Main Modules */

		include("main/atlasui_address.php");
		include("main/atlasui_encrypt.php");
		include("main/atlasui_ftp_login.php");
		include("main/atlasui_mysqli_result.php");
		include("main/atlasui_sql_connect.php");
		include("main/atlasui_string_clean.php");
		include("main/opengraph.php");
		include("main/speed_library.php");

	/* Import AtlasUI Browser Interaction Modules */
	
		include("browser/notification.php");
		include("browser/redirect.php");
	
	/* Import Math Framework / Library */
  
		include("math/alibmath.php");

	/* Import Modular Communication Framework & Other Plugins */

		include("plugins/ekiga_button.php"); // Wrapper for Ekiga.Net JavaScript button to determine status of Ekiga.Net user.
		include("plugins/google_maps_static.php");
		include("plugins/paypal.php");
		include("plugins/skype.php");

	/* Import Social Network Framework */

		include("social/facebook.php");
		include("social/flattr_button.php");
		include("social/google_plus.php");
		include("social/reddit.php");
		include("social/spotify.php");
		include("social/twitter.php");
		include("social/youtube.php");

?>