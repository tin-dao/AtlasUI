<?php

	function contactForm($recipient_email, $name_input, $email_input, $subject_input, $button_name)
	{
		$domain = $_SERVER["SERVER_NAME"];
		$rand_domain_email = "contactform@" . $domain;
		print "<form action=\"#\" method=\"POST\" class=\"atlasui_contact_form\">";
			print "<input type=\"hidden\" name=\"recipient\" value=\"$recipient_email\" />";
			
			if ($name_input == ("yes" || "true"))
			{
				print "<input type=\"text\" name=\"contact_name\" placeholder=\"Your Name...\" />";
			}
			else{
			
			}
			if ($email_input == ("yes" || "true"))
			{
				print "<input type=\"text\" name=\"contact_email\" placeholder=\"Your Email...\" />";
			}
			else{
				print "<input type=\"hidden\" name=\"contact_email\" value=\"$rand_domain_email\" />";
			}
			if ($subject_input == ("yes" || "true"))
			{
				print "<input type=\"text\" name=\"subject\" placeholder=\"Subject...\" />";
			}
			else{
				
			}
			print "<textarea cols=\"50\" rows=\"10\" name=\"message\" placeholder=\"Your Message...\"></textarea>";
			if ($button_name !== "")
			{
				print "<button type=\"submit\">$buttonName</button>";
			}
			else{
				print "<button type=\"submit\">Send</button>";
			}
		print "</form>";
		
		$recipient = $_POST["recipient"];
		$uncleanname = $_POST["contact_name"];
		$uncleanemail = $_POST["contact_email"];
		$uncleansubject = $_POST["subject"];
		$uncleanmessage = $_POST["message"];
		$badarray = array("#","$","%","^","&","*","{","}","[","]","|","=","+","-","~","`","<",">","viagra","cialis", "##", "&=");
		$name = str_replace($badarray, "", $uncleanname);
		$email = str_replace($badarray, "", $uncleanemail);
		$subject = str_replace($badarray, "", $uncleansubject) . " by $name";
		$message = str_replace($badarray, "", $uncleanmessage);
		
		mail($recipient, $subject , $message, "From: " . $email);
		if ($message !== "")
		{
			print "<meta http-equiv=\"refresh\" content=\"0.5;url=#\" />";
		}
		else{
			
		}
	}
	
?>
