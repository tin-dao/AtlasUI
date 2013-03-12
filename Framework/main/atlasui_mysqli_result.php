<?php

	function atlasui_mysqli_result($query, $row = 0, $column = null){
		mysqli_data_seek($query, $row) or die("row_does_not_exist");
		$rowData = mysqli_fetch_array($query, MYSQLI_BOTH);
		return $rowData[$column];
		mysqli_free_result($query);
	}
	
?>