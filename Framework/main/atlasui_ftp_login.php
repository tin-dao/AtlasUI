<?php

	function atlasui_ftp_login($ftpServer, $sslBoolean, $ftpUsername, $ftpPassword){
		$ftpServer = str_replace("ftp://", "ftp.", $ftpServer);
		
		if ($sslBoolean !== true){
			$ftpConnection = ftp_connect($ftpServer);
		}
		else{
			$ftpConnection = ftp_ssl_connect($ftpServer);
		}
		
		if ($ftpConnection !== false){
			if (ftp_login($ftpConnection, $ftpUsername, $ftpPassword) !== false){
				return $ftpConnection;
			}
			else{
				return "atlasui_ftp_login has invalid credentials for connecting to $ftpServer.";
			}
		}
		else{
			return "atlasui_ftp_login couldn't connect to $ftpServer";
		}
		
		/* When using atlasui_ftp_login, remember to assign a variable equal to the function, as the function will
		 * return the ftp_connect should it be correct. This will then allow you to access all ftp features just
		 * as you would with ftp_connect (or ftp_ssl_connect) and ftp_login.
		 */
	}
	
?>
