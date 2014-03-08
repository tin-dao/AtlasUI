<?php

	/* AtlasUI Browser Interaction Modules */
	include("backend/browser/atlasui_http_request.php");
	include("backend/browser/redirect.php");

	/* AtlasUI Main Modules */
	include("backend/main/atlasui_address.php");
	include("backend/main/atlasui_ftp_login.php");
	include("backend/main/atlasui_hashing.php");
	include("backend/main/atlasui_mysqli_result.php");
	include("backend/main/atlasui_sql_connect.php");
	include("backend/main/atlasui_unique_array.php");
	include("backend/main/opengraph.php");
	include("backend/main/speed_library.php");
	include("backend/main/strings.php");

	/* Math Framework / Library */
	include("backend/math/alibmath.php");

	/* Audio and Video Framework */
	include("frontend/media/audio.php");
	include("frontend/media/video.php");

	/* Modular Communication Framework & Other Plugins */
	include("frontend/plugins/ekiga_button.php"); // Wrapper for Ekiga.Net JavaScript button to determine status of Ekiga.Net user.
	include("frontend/plugins/google_maps_static.php");
	include("frontend/plugins/paypal.php");
	include("frontend/plugins/skype.php");

	/* Social Network Framework */
	include("frontend/social/facebook.php");
	include("frontend/social/flattr_button.php");
	include("frontend/social/google_plus.php");
	include("frontend/social/reddit.php");
	include("frontend/social/spotify.php");
	include("frontend/social/twitter.php");
	include("frontend/social/utilities.php");
	include("frontend/social/youtube.php");

?>
