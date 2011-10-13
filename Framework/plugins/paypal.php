<?php

	function paypal_button($paypal_email, $item_name, $item_cost, $currency_code, $no_note, $no_shipping, $tax_rate, $shipping_cost)
	{
		print "<form action=\"https://www.paypal.com/cgi-bin/webscr\" method=\"post\">";
		print "<input type=\"hidden\" name=\"cmd\" value=\"_xclick\">";
		print "<input type=\"hidden\" name=\"business\" value=\"$paypal_email\">";
		print "<input type=\"hidden\" name=\"lc\" value=\"US\">;
		print "<input type=\"hidden\" name=\"item_name\" value=\"$item_name\">";
		print "<input type=\"hidden\" name=\"amount\" value=\"$item_cost\">";
		print "<input type=\"hidden\" name=\"currency_code\" value=\"$currency_code\">
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
	
?>
