<?php

	function search($form_or_cse, $filepath_or_uniqueid, $input_box_message, $search_button_message, $class){

		if ($form_or_cse == "form")
		{
			print "<form action=\"$filepath_or_uniqueid\" method=\"POST\"";
			if ($class == ""){
				print "class=\"search_module\">";
			}
			else{
				print "class=\"$class\">";
			}

				print "<input type=\"text\" name=\"search_input\" ";
				if ($input_box_message == ""){
					print "placeholder=\"Search...\" />";
				}
				else{
					print "placeholder=\"$input_box_message\" />";
				}

				print "<button type=\"submit\">";
					if ($search_button_message == ""){
						print "Search";
					}
					else{
						print $search_button_message;
					}
				print "</button>";
		}
		elseif ($form_or_cse == "cse")
		{
			print "<script src=\"http://www.google.com/jsapi\" type=\"text/javascript\"></script>";
			print "<script type=\"text/javascript\">";
			print "google.load('search', '1', {language : 'en'});";
			print "google.setOnLoadCallback(function() {";
				print "var customSearchControl = new google.search.CustomSearchControl('$filepath_or_uniqueid');";
				print "customSearchControl.setResultSetSize(google.search.Search.FILTERED_CSE_RESULTSET);";
				print "var options = new google.search.DrawOptions();";
				print "options.enableSearchboxOnly(\"http://www.google.com/cse?cx=" . $filepath_or_uniqueid . "\", null, true);";
				print "customSearchControl.draw('cse-search-form', options);";
			print "}, true);";
			print "</script>";
			print "<link rel=\"stylesheet\" href=\"http://www.google.com/cse/style/look/default.css\" type=\"text/css\" />";
			print "<div id=\"cse-search-form\" style=\"width: 100%;\">Loading</div>";
		}

	}

?>