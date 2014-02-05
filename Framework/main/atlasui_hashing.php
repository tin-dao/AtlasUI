<?php

	function atlasui_hashing($string, $rounds = 50000, $hashString = "atlasui"){
		$cleanLength = strlen('$6$rounds=' . $rounds . "$" . $hashString . "$");
		$initial_encryption = sha1(md5($string));
		$hash = str_replace(array("/", '\"', '"'), "", crypt($initial_encryption, '$6$rounds=' . $rounds . '$' . $hashString . '$'));
		$encrypted_string = substr($hash, $cleanLength);
		return $encrypted_string;
	}
	
?>
