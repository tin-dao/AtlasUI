<?php

	function atlasui_ftp_login($ftp_server, $ssl_or_not, $username, $password){
		$clean_ftp_location = str_replace("ftp://", "ftp.", $ftp_server);
		if ($ssl_or_not !== true){
			$ftp_connection_passed = ftp_connect($clean_ftp_location) or die("atlasui_ftp_login failed to connect.");
		}
		else{
			$ftp_connection_passed = ftp_ssl_connect($clean_ftp_location) or die("atlasui_ftp_login failed to connect.");
		}
		
		if (gettype($ftp_connection_passed) !== "string"){
			if (ftp_login($ftp_connection_passed, $username, $password) == false){
				return "atlasui_ftp_login has invalid credentials. Trying to connect to $ftp_server (clean: $clean_ftp_location) with $username and $password";
			}
		}
		return $ftp_connection_passed;
		
		/* When using atlasui_ftp_login, remember to assign a variable equal to the function, as the function will
		 * return the ftp_connect should it be correct. This will then allow you to access all ftp features just
		 * as you would with ftp_connect and ftp_login.
		 */
	}
	
?>
