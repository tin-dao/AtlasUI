<?php

	function draw_heart($height_and_width, $same_dir)
	{
		if ($same_dir == "true")
		{
			$path_to_image = "/images/shape_heart.svg";
		}
		elseif ($same_dir == "separate_folder")
		{
			$path_to_image = "../Framework/images/shape_heart.svg";
		}
		elseif ($same_dir == "sub_folder")
		{
			$path_to_image = "Framework/images/shape_heart.svg";
		}
		else{
			$path_to_image = $same_dir . "/images/shape_heart.svg";
		}
		print "<img src=\"$path_to_image\" width=\"" . $height_and_width . "px\" height=\"" . $height_and_width . "px\" />";
	}

?>
