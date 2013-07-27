<?php

	function flattr_button($thingID, $thingName){
		if ($thingID == ""){
			print "You are missing a required variable, please enter it now.";
		}
		elseif ($thingName == "")	{
			print "You are missing a required variable, please enter it now.";
		}
		else{
			print "<a href=\"http://flattr.com/thing/" . $thingID . "/" . $thingName . "\" target=\"_blank\">";
				print "<img src=\"http://api.flattr.com/button/flattr-badge-large.png\" alt=\"Flattr this\" title=\"Flattr this\" border=\"0\" />";
			print "</a>";
		}
	}
	
?>
