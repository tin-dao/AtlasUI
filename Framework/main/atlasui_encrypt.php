<?php

	function atlasui_encrypt($string, $rounds, $hashString){		
		$cleanLength = strlen("$6$rounds=" . $rounds . "$" . $hashString . "$");
		$initial_encryption = sha1(md5($string));
		$hash = str_replace(array("/", '\"', '"'), "", crypt($initial_encryption, '$6$rounds=' . $rounds . '$' . $hashString . '$'));
		$encrypted_string = substr($hash, $cleanLength);
		return $encrypted_string;
	}
	
?>