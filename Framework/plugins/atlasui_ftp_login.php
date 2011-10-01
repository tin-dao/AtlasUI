<?php

	function atlasui_ftp_login($ftp_server, $ssl_or_not, $username, $password)
	{
		$clean_ftp_location = str_replace("ftp://", "ftp.", $ftp_server);
		if ($ssl_or_not == "")
		{
			$ftp_connection_passed = ftp_connect($clean_ftp_location, "21", "30") or die("atlasui_ftp_login failed to connect.");
		}
		else{
			$ftp_connection_passed = ftp_ssl_connect($clean_ftp_host, "21", "30") or die("atlasui_ftp_login failed to connect.");
		}
		ftp_login($ftp_connection_passed, $username, $password) or die("atlasui_ftp_login has invalid credentials.");
		return $ftp_connection_passed;
		
		/* When using atlasui_ftp_login, remember to assign a variable equal to the function, as the function will
		 * return the ftp_connect should it be correct. This will then allow you to access all ftp features just
		 * as you would with ftp_connect and ftp_login.
		 */
	}
	
?>
