<?php

	function facebookIncludeJSScript($applicationID){
		print "<script>(function(d, s, id) {";
			print " var js, fjs = d.getElementsByTagName(s)[0];";
			print "if (d.getElementById(id)) return;";
				print "js = d.createElement(s); js.id = id;";
				print "js.src = \"//connect.facebook.net/en_US/all.js#xfbml=1&appId=" . $applicationID . "\";";
				print " fjs.parentNode.insertBefore(js, fjs);";
			print "}(document, 'script', 'facebook-jssdk'));";
		print "</script>";
	}
	
	function googleIncludeJSScript(){
		print "<script type=\"text/javascript\">";
			print "(function() {";
		    	print "var po = document.createElement('script'); po.type = 'text/javascript'; po.async = true;";
		    	print "po.src = 'https://apis.google.com/js/plusone.js';";
		    	print "var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(po, s);";
		 	print "})();";
		print "</script>";
	}
	
	function html5GlobalDataAttributes(array $dataAttributes){
		$returnedDataAttributes = "";
		
		foreach ($dataAttributes as $dataAttribute => $dataValue){
			if (gettype($dataValue) == "boolean"){
				if ($dataValue == true){
					$dataValue = "true";
				}
				else{
					$dataValue = "false";
				}
			}
			$returnedDataAttributes = $returnedDataAttributes . " data-" . $dataAttribute . "=\"" . $dataValue . "\"";
		}
		return $returnedDataAttributes;
	}
?>