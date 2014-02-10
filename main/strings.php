<?php

	function atlasui_random_string($maxLength = 10){ // Function to generate random hash
		function randomString(){ // Function to generate random string
			global $maxLength;

			$alphabet = array("a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"); // Alphabet, obviously
			$randomString = ""; // Random string generated
			$repetitionCount = 0; // Repetition count, max is 20/21

			while($repetitionCount < $maxLength){ // While the repetitionCount is less than 20 (last repetition is on int 19)
				$randomString = $randomString . $alphabet[rand(0, 23)]; // randomString PLUS a random letter (array[random 0 to 23])
				$repetitionCount = $repetitionCount + 1;
			}

			return $randomString; // Return the random string
		}

		$randomNumber = settype(rand(100000, 999999), "string"); // Generate a random number as a string
		$randomString = randomString(); // Generate a random string

		$randomHash_Long = atlasui_hashing($randomNumber . $randomString, 50000, time()); // Generate an sha512 hash / string that is comprised of the random number + random string with the salt as UNIX epoch time
		return substr(str_replace(".", "", $randomHash_Long), 0, $maxLength); // Return hash
	}

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