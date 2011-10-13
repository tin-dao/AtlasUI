<?php

	function atlasui_url_address($clean_for_social_networks)
	{
		$get_url = $_SERVER["SERVER_NAME"].$_SERVER["REQUEST_URI"];
		
		if ($clean_for_social_networks == ("yes" || "true"))
		{
			$unclean_path_parts = array(":","/",);
			$clean_path_parts = array("%3A","%2F",);
			$url = str_replace($unclean_path_parts, $clean_path_parts, $get_url);
		}
		else{
			$url = $get_url;
		}
		
		return $url;
	}
	
?>
