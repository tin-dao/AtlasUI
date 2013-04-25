<?php

	function atlasui_mysqli_result($query, $row = 0, $column = null){
		$numberOfRows = mysqli_num_rows($query);

		if ($numberOfRows > 0){
			mysqli_data_seek($query, $row);
			$rowData = mysqli_fetch_array($query, MYSQLI_BOTH);
			return $rowData[$column];
		}
		else{
			return "row_does_not_exist";
		}
		mysqli_free_result($query);
	}
	
?>