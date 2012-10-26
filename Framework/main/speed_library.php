<?php

	function speed_library($library, $version){
		$acceptableLibraries = array("AngularJS",  "Chromeframe", "Dojo", "ExtCore", "jQuery", "jQuery UI", 
		"MooTools", "Prototype", "script.aculo.us", "SWFObject", "WebFont");
		$acceptableIncludes = array("angularjs||angular.min.js", "chrome-frame||CFInstall.min.js", "dojo||dojo/dojo.js", "ext-core||ext-core.js",
		"jquery||jquery.min.js", "jqueryui||jquery-ui.min.js", "mootools||mootools-yui-compressed.js", "prototype||prototype.js",
		"swfobject||swfobject.js", "webfont||webfont.js");

		$determineLibrary = str_replace($acceptableLibraries, $acceptableIncludes, $library);
		$determineLibrary_ExplodeToInterpret = explode("||", $determineLibrary);
		
		$include = $determineLibrary_ExplodeToInterpret[0] . "/$version/" . $determineLibrary_ExplodeToInterpret[1];
		
		print "<script src=\"//ajax.googleapis.com/ajax/libs/$include\"></script>";
		
	}

?>