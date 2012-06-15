<?php

	function atlasui_encrypt($string, $level, $hashString)
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
			$initial_encryption = sha1(md5($string));
			$hash = crypt($initial_encryption, '$6$rounds=10000$' . $hashString . '$');
			$encrypted_string = str_replace('$6$rounds=10000$' . $hashString . '$', '', $hash);
			return $encrypted_string;
		}
	}
	
?>
