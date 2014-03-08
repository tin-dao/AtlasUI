<?php
	function atlasui_unique_array(array $searchArray, array $compareArray){ // Compare searchArray and compareArray and find unique key/vals from searchArray
		foreach ($compareArray as $compareKey){ // For each item in the compareArray (the items we are remove if they exist)
			unset($searchArray[$compareKey]); // Remove the item
		}

		return $searchArray;
	}
?>