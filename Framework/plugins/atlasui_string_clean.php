<?php
	
	function atlasui_string_clean($uncleanString, $cleaningLevel, $cleanStringTags)
	{
		if ($cleaningLevel = 0 || 1)
		{
			$characterCleaning = str_replace(array("\"", "'", '"'), "", $uncleanString);
		}
		elseif ($cleaningLevel = 2)
		{
			$characterCleaning = str_replace(array("\"", "'", ";", '"'), "", $uncleanString);
		}
		else{
			$characterCleaning = str_replace(array("\"", "*", "'", ";", "(", ")", '"'), "", $uncleanString);
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
