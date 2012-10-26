<?php

	function atlasui_encrypt($string, $level, $rounds, $hashString)
	{
		if ($level == "low")
		{
			$encrypted_string = md5($string);
			return $encrypted_string;
		}
		elseif ($level == "medium")
		{
			$initial_encryption = md5($string);
			$encrypted_string = sha1($initial_encryption);
			return $encrypted_string;
		}
		else{
			/* Falls back to Default or "Strong" */
			
			$cleanLength = strlen("$6$rounds=" . $rounds . "$" . $hashString . "$");
			$initial_encryption = sha1(md5($string));
			$hash = str_replace(array("/", "\\", '"'), "", crypt($initial_encryption, '$6$rounds=' . $rounds . '$' . $hashString . '$'));
			$encrypted_string = substr($hash, $cleanLength);
			return $encrypted_string;
		}
	}
	
?>
