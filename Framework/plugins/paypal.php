<?php

	function paypal_button($paypal_email, $item_name, $item_cost, $currency_code, $no_note, $no_shipping, $tax_rate, $shipping_cost)
	{
		print "<form action=\"https://www.paypal.com/cgi-bin/webscr\" method=\"post\">";
		print "<input type=\"hidden\" name=\"cmd\" value=\"_xclick\">";
		print "<input type=\"hidden\" name=\"business\" value=\"$paypal_email\">";
		print "<input type=\"hidden\" name=\"lc\" value=\"US\">";
		print "<input type=\"hidden\" name=\"item_name\" value=\"$item_name\">";
		print "<input type=\"hidden\" name=\"amount\" value=\"$item_cost\">";
		print "<input type=\"hidden\" name=\"currency_code\" value=\"$currency_code\">";
		print "<input type=\"hidden\" name=\"button_subtype\" value=\"services\">";
		print "<input type=\"hidden\" name=\"no_note\" value=\"$no_note\">";
		print "<input type=\"hidden\" name=\"no_shipping\" value=\"$no_shipping\">";
		print "<input type=\"hidden\" name=\"rm\" value=\"1\">";
		
		if ($tax_rate < "0.00")
		{
			$tax_rate = "0.00";
		}
		
		if ($shipping_cost < "0.00")
		{
			$shipping_cost = "0.00";
		}
		
		print "<input type=\"hidden\" name=\"tax_rate\" value=\"$tax_rate\">";
		print "<input type=\"hidden\" name=\"shipping\" value=\"$shipping_cost\">";
		print "<input type=\"hidden\" name=\"bn\" value=\"PP-BuyNowBF:btn_buynowCC_LG.gif:NonHosted\">";
		print "<input type=\"image\" src=\"https://www.paypalobjects.com/en_US/i/btn/btn_buynowCC_LG.gif\" border=\"0\" name=\"submit\" alt=\"PayPal - The safer, easier way to pay online!\">";
		print "<img alt=\"\" border=\"0\" src=\"https://www.paypalobjects.com/en_US/i/scr/pixel.gif\" width=\"1\" height=\"1\">";
		print "</form>";
	}
	
	function paypal_donate($paypal_email, $organization_name, $currency_code, $no_shipping, $cancel_url, $finish_url)
	{
		$currency_array = array("EUR","AUD","BRL","GBP","CAD","CZK","DKK","HKD","HUF","ILS","JPY","MXN","TWD","NZD","NOK","PHP","PLN","SGD","SEK","CHF","THB","USD");
		
		print "<form action=\"https://www.paypal.com/cgi-bin/webscr\" method=\"post\" target=\"_blank\">";
		print "<input type=\"hidden\" name=\"cmd\" value=\"_donations\">";
		print "<input type=\"hidden\" name=\"business\" value=\"$paypal_email\">";
		print "<input type=\"hidden\" name=\"lc\" value=\"US\">";
		print "<input type=\"hidden\" name=\"item_name\" value=\"$organization_name\">";
		print "<input type=\"hidden\" name=\"no_note\" value=\"0\">";
		print "<input type=\"hidden\" name=\"cn\" value=\"Add special instructions to the seller\">";
		
		if ($no_shipping == ("" || "false" || "not required"))
		{
			print "<input type=\"hidden\" name=\"no_shipping\" value=\"1\">";
		}
		elseif ($no_shipping == ("yes" || "true" || "required"))
		{
			print "<input type=\"hidden\" name=\"no_shipping\" value=\"2\">";
		}
		else{
			print "<input type=\"hidden\" name=\"no_shipping\" value=\"1\">";
		}
		print "<input type=\"hidden\" name=\"rm\" value=\"1\">";
		if ($finish_url == "")
		{
			
		}
		else{
			print "<input type=\"hidden\" name=\"return\" value=\"$finish_url\">";
		}
		
		if ($cancel_url == "")
		{
			
		}
		else{
			print "<input type=\"hidden\" name=\"cancel_return\" value=\"$cancel_url\">";
		}
		
		if (strstr($currency_code, $currency_array))
		{
			print "<input type=\"hidden\" name=\"currency_code\" value=\"$currency_code\">";
		}
		else{
			print "<input type=\"hidden\" name=\"currency_code\" value=\"USD\">";
		}
		
		print "<input type=\"hidden\" name=\"bn\" value=\"PP-DonationsBF:btn_donateCC_LG.gif:NonHosted\">";
		print "<input type=\"image\" src=\"https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif\" border=\"0\" name=\"submit\" alt=\"PayPal - The safer, easier way to pay online!\">";
		print "<img alt=\"\" border=\"0\" src=\"https://www.paypalobjects.com/en_US/i/scr/pixel.gif\" width=\"1\" height=\"1\">";
		print "</form>";
	}
	
?>
