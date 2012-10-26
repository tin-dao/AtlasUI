<?php

	function atlasui_ip_address()
	{
		if (!empty($_SERVER['HTTP_CLIENT_IP']))   //check ip from share internet
		{
			$ipaddress = $_SERVER['HTTP_CLIENT_IP'];
		}
		elseif (!empty($_SERVER['HTTP_X_FORWARDED_FOR']))   //to check ip is pass from proxy
		{
			$ipaddress = $_SERVER['HTTP_X_FORWARDED_FOR'];
		}
		else
		{
			$ipaddress = $_SERVER['REMOTE_ADDR'];
		}

		return $ipaddress;
	}
?>