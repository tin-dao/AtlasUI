<?php

	function atlasui_ip_address(){
		if (!empty($_SERVER['HTTP_CLIENT_IP']))   //check ip from share internet
		{
			$ipaddress = $_SERVER['HTTP_CLIENT_IP'];
		}
		elseif (!empty($_SERVER['HTTP_X_FORWARDED_FOR']))   //to check ip is pass from proxy
		{
			$ipaddress = $_SERVER['HTTP_X_FORWARDED_FOR'];
		}
		else{
			$ipaddress = $_SERVER['REMOTE_ADDR'];
		}

		return $ipaddress;
	}

	function atlasui_url_address($inputUrl = "", $urlEncode = true){
		if (!isset($inputUrl) || ($inputUrl == "")){
			$inputUrl = $_SERVER["SERVER_NAME"].$_SERVER["REQUEST_URI"];
		}

		if ($urlEncode == true){
			$outputUrl = rawurlencode($inputUrl);
		}
		else{
			$outputUrl = $inputUrl;
		}
		
		return $outputUrl;
	}

?>