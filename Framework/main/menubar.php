<?php

	function menubar($menu_list)
	{
		print "<div class=\"dark_menubar\">";
			$menu_items = explode("||",$menu_list, 9);
			
			foreach ($menu_items as $key => $menuItemNonExplode){
				$menuContent = explode("#", $menuItemNonExplode);
				$menuItemName = $menuContent[0];
				$menuLocation = $menuContent[1];	
				print "<a href=\"$menuLocation\">$menuItemName</a>";
			}
			unset($menuItemNonExplode);
			
		print "</div>";
	}
	
?>
