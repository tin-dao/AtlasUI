<?php

	function atlasui_encrypt($string, $level)
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
			$encrypted_string = $initial_encryption . "e" . crypt($initial_encryption, 'a7');
			return $encrypted_string;
		}
	}
	
?>
