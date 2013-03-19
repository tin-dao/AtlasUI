<?php

	function atlasui_string_check($haystackString, $needleStringArray){
		$haystackContainsNeedleBoolean = false;
		foreach($needleStringArray as $key => $needleString){
			if (strpos($haystackString, $needleString) !== false){
				$haystackContainsNeedleBoolean = true;
			}
		}

		return $haystackContainsNeedleBoolean;
	}

	function atlasui_string_clean($uncleanString, $cleaningLevel = 1, $cleanStringTags = true){
		if ($cleaningLevel = (0 || 1)){
			$characterCleaning = str_replace(array('"', "*", "'"), array("","&#39;", "&#42;", "&#34"), $uncleanString);
		}
		else{
			$characterCleaning = str_replace(array('"', "*", "'", "(", ")"), array("&#34;", "&#42;", "&#39;", "&#40;", "&#41;"), $uncleanString);
		}
		
		if ($cleanStringTags == true){
			$cleanString = strip_tags($characterCleaning, '<pre></pre><ul></ul><ol></ol><li></li><p></p><u></u><b></b><i></i>');
		}
		else{
			$cleanString = $characterCleaning;
		}
		
		return $cleanString;
	}

?>