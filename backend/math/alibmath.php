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

	/* Multiply Array Of Integers */
	
	function ammulti($int_array)
	{
		$overall_multi_int = 1;
		$multi_int_items = explode("|", $int_array);
		
		foreach ($multi_int_items as $key => $multi_int){
			$overall_multi_int = $overall_multi_int * $multi_int;
		}
		
		return $overall_multi_int;
	}
	
	/* Multiple Integer By π */
	
	function ampi($int)
	{
		return ($int * 3.14);
	}
	
	function apower($int, $power)
	{
		return (pow($int, $power));
	}
	
	function isOdd($integer)
	{
		return ($integer%2) ? TRUE : FALSE;
	}

?>