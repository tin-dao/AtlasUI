<?php

	/* Add Array Of Integers */
	
	function amadd($int_array)
	{
		$overall_int = 0;
		$int_items = explode("|", $int_array);
			
		foreach ($int_items as $key => $int){
			$overall_int = $overall_int + $int;
		}
			
		return $overall_int;
	}

	/* Multiple Integer By π */
	
	function ampie($int)
	{
		return ($int * 3.14);
	}
	
?>