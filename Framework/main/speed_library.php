<?php

	function speed_library($library, $version){ // A utility that allows for easy fetching of Google-hosted web libraries
		$library = strtolower(trim($library)); // Remove whitespace and lowercase the library

		$acceptableIncludes = array( /* An array of currently accepted Google Hosted Libraries */
			"angularjs" => "angular.min.js", "chrome-frame" => "CFInstall.min.js", "dojo" => "dojo/dojo.js", "ext-core" => "ext-core.js",
			"jquery" => "jquery.min.js", "jqueryui" => "jquery-ui.min.js", "mootools" => "mootools-yui-compressed.js", "prototype" => "prototype.js",
			"swfobject" => "swfobject.js", "webfont" => "webfont.js"
		);
		
		print "<script src=\"//ajax.googleapis.com/ajax/libs/" . $library . "/" . $version . "/" . $acceptableIncludes[$library] . "\"></script>";
	}

?>