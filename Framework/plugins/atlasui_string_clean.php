<?php
	
	function atlasui_string_clean($uncleanString, $cleaningLevel, $cleanStringTags)
	{
		if ($cleaningLevel = 0 || 1)
		{
			$characterCleaning = str_replace(array("\"", "'", '"'), array("", "&#39;", "&#34;"), $uncleanString);
		}
		elseif ($cleaningLevel = 2)
		{
			$characterCleaning = str_replace(array("\"", "'", ";", '"'), array("","&#39;","&#59;", "&#34"), $uncleanString);
		}
		else{
			$characterCleaning = str_replace(array("\"", "*", "'", ";", "(", ")", '"'), array("", "&#42;", "&#39;", "&#59;","&#34;"), $uncleanString);
		}
		
		if ($cleanStringTags = true)
		{
			$cleanString = strip_tags($characterCleaning, '<pre></pre><ul></ul><ol></ol><li></li><p></p><u></u><b></b><i></i>');
		}
		else{
			$cleanString = $characterCleaning;
		}
		
		return $cleanString;
	}
	
?>
