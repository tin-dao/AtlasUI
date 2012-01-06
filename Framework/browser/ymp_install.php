<?php

	/* Ymp Install is a plugin that is oriented to those using OpenSuse's YMP / One-Click Install
	Standards. This particular plugin is targeted towards ISVs (Independent Software Vendors). For
	more information on this standard, visit http://en.opensuse.org/openSUSE:One_Click_Install

		Also note this plugin was added to the Browser folder due to the fact it directly works with the
	browser and OS (operating system).
	*/

	function ymp_install($path)
	{
		if ($path !== "")
		{
			print "<a href=\"$path\" class=\"ymp_install\"></a>";
		}
		else{

		}
	}

?>