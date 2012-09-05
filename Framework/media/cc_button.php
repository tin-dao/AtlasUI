<?php

	function cc_button($optional_info, $commercial_use, $allow_modifications)
	{
		print "<div class=\"cc_button\">";
			if ($optional_info !== "")
			{
				$info = explode("|", $optional_info);
				$title = $info[0];
				$attribute_name = $info[1];
				$attribute_url = $info[2];
				$source_url = $info[3];
			}
			else{
				
			}

			if ($commercial_use == "yes" && $allow_modifications == "yes")
			{
				$license_url = "http://creativecommons.org/licenses/by/3.0/";
				$license_image = "http://i.creativecommons.org/l/by/3.0/88x31.png";
				$license_name = "Creative Commons Attribution 3.0 Unported License";
			}
			elseif ($commercial_use == "yes" && $allow_modifications == "sharealike")
			{
				$license_url = "http://creativecommons.org/licenses/by-sa/3.0/";
				$license_image = "http://i.creativecommons.org/l/by-sa/3.0/88x31.png";
				$license_name = "Creative Commons Attribution-ShareAlike 3.0 Unported License";
			}
			elseif ($commercial_use == "yes" && $allow_modifications == "no")
			{
				$license_url = "http://creativecommons.org/licenses/by-nd/3.0/";
				$license_image = "http://i.creativecommons.org/l/by-nd/3.0/88x31.png";
				$license_name = "Creative Commons Attribution-NoDerivs 3.0 Unported License";
			}
			elseif ($commercial_use == "no" && $allow_modifications == "yes")
			{
				$license_url = "http://creativecommons.org/licenses/by-nc/3.0/";
				$license_image = "http://i.creativecommons.org/l/by-nc/3.0/88x31.png";
				$license_name = "Creative Commons Attribution-NonCommercial 3.0 Unported License";
			}
			elseif ($commercial_use == "no" && $allow_modifications == "sharealike")
			{
				$license_url = "http://creativecommons.org/licenses/by-nc-sa/3.0/";
				$license_image = "http://i.creativecommons.org/l/by-nc-sa/3.0/88x31.png";
				$license_name = "Creative Commons Attribution-NonCommercial-ShareAlike 3.0 Unported License";
			}
			elseif ($commercial_use == "no" && $allow_modifications == "no")
			{
				$license_url = "http://creativecommons.org/licenses/by-nc-nd/3.0/";
				$license_image = "http://i.creativecommons.org/l/by-nc-nd/3.0/88x31.png";
				$license_name = "Creative Commons Attribution-NonCommercial-NoDerivs 3.0 Unported License";
			}
			
			print "<a rel=\"license\" href=\"$license_url\"><img alt=\"Creative Commons License\" style=\"border-width:0\" src=\"$license_image\" /></a>";
			if ($title !== "")
			{
				print "<br /><span xmlns:dct=\"http://purl.org/dc/terms/\" property=\"dct:title\">$title</span>";
			}
					
			if ($attribute_name && $attribute_url !== "")
			{
				print " by <a xmlns:cc=\"http://creativecommons.org/ns#\" href=\"$attribute_url\" target=\"_blank\" property=\"cc:attributionName\" rel=\"cc:attributionURL\">$attribute_name</a> ";
			}
			print "is licensed under a <a rel=\"license\" href=\"$license_url\">$license_name</a>.";
					
			if ($source_url !== "")
			{
				print "<br />Based on a work at <a xmlns:dct=\"http://purl.org/dc/terms/\" href=\"$source_url\" rel=\"dct:source\">$source_url</a>.";
			}
		print "</div>";
	}
		
?>
