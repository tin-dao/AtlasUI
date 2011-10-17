<?php

	/* DEPENDENCIES:
	 * browser/redirect.php
	 */
	  
	function search($type_of_form, $filepath_or_uniqueid, $input_box_message, $search_button_message, $class){
		
		$nodes_query = $_POST["nodesquery"];
		$nodes_type = $_POST["nodestype"];
		$search_input = $_POST["search_input"];

		if ($type_of_form == ("form" || ("Nodes|Metasearch" || "Nodes|Metalink")))
		{
			if ($type_of_form == ("Nodes|Metasearch" || "Nodes|Metalink"))
			{
				print "<form action=\"\" method=\"POST\" target=\"_blank\"";
			}
			else{
				print "<form action=\"$filepath_or_uniqueid\" method=\"POST\"";
			}
			if ($class == ""){
				print "class=\"search_module\">";
			}
			else{
				print "class=\"$class\">";
			}
				if ($type_of_form == ("Nodes|Metasearch" || "Nodes|Metalink"))
				{
					print "<input type=\"hidden\" name=\"nodesquery\" value=\"catchme\" />";
					if ($type_of_form == "Nodes|Metasearch")
					{
						print "<input type=\"hidden\" name=\"nodestype\" value=\"metasearch\" />";
					}
					else{
						print "<input type=\"hidden\" name=\"nodestype\" value=\"metalink\" />";
					}
				}
				else{
					
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
		elseif ($type_of_form == "cse")
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

		if ($nodes_query == "catchme")
		{
			if ($nodes_type == "metasearch")
			{
				$url = "http://nodes.net/index.html?" . $search_input;
			}
			elseif ($nodes_type == "metalink")
			{
				$url = "http://" . $search_input . ".nodes.net";
			}
			print "<meta http-equiv=\"refresh\" content=\"0.5;url=" . $url . "\" />";
		}
		else{

		}
	}

?>
