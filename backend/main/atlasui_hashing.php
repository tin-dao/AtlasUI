<?php

	function atlasui_hashing($string, $rounds = 50000, $specifiedSalt = "atlasui"){
		$cryptPrefix = '$6$rounds=' . $rounds . "$" . $specifiedSalt . "$"; // Create a salt string of sha512, rounds specified, and the specifiedSalt provided
		$hashRemovalLength = strlen($cryptPrefix); // Determine how much of the string we'll need to remove, otherwise the hash will be prefixed with the type
		
		$initialHashing = sha1(md5($string)); // Do an initial hashing of the string by sha1'ing the md5 of the string
		$fullLengthHashing = str_replace(array("/", '\"', '"'), "", crypt($initialHashing, $cryptPrefix)); // Run the string through crypt, remove forward and back slashes as well as double quote
		$hashedString = substr($fullLengthHashing, $hashRemovalLength); // Remove the string in front of the hash that exposes the type of crypt used
		return $hashedString;
	}
	
?>
