<?php

	function powered_by($same_dir)
	{
		if ($same_dir == "true")
		{
			$path_to_image = "/images/powered_by.png";
		}
		elseif ($same_dir == "separate_folder")
		{
			$path_to_image = "../Framework/images/powered_by.png";
		}
		elseif ($same_dir == "sub_folder")
		{
			$path_to_image = "/Framework/images/powered_by.png";
		}
		else{
			$path_to_image = $same_dir . "/images/powered_by.png";
		}
		
		print "<a href=\"http://atlasui.aosdt.com\" target=\"_blank\"><img src=\"$path_to_image\" border=\"0px\" /></a>";
	}
	
?>
