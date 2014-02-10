<?php

	function flattr_button($thingID, $thingName, $thingDescription){
		if (($thingID == null) || ($thingName == null) || ($thingDescription == null)){
			print "You are missing a required variable, please enter it now.";
		}
		else{
			print "<script type=\"text/javascript\" src=\"//api.flattr.com/js/0.6/load.js?mode=auto\"></script>";
			print "
				<a class=\"FlattrButton\" style=\"display:none;\"
					title=\"$thingName\"
					data-flattr-uid=\"$thingID\"
					href=\"" . atlasui_url_address() . "\"
				>
					$thingDescription
				</a>
			";
		}
	}
	
?>