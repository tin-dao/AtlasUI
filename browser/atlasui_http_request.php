<?php

	function atlasui_http_request($httpRequestUrl, $httpRequestMethod =  "POST", $httpRequestData = null, $httpRequestFiles = null, $httpRequestOptions = null){
		$httpRequest = curl_init();

		/* Setting some essential cURL options */
		curl_setopt($httpRequest, CURLOPT_CUSTOMREQUEST, $httpRequestMethod); // Useful if the method is DELETE or something more obscure.
		curl_setopt($httpRequest, CURLOPT_CONNECTTIMEOUT, 15); // If the URL doesn't respond within 15 seconds, then we'll assume there is an issue (like the site being slow).
		curl_setopt($httpRequest, CURLOPT_FAILONERROR, true); // Fails if HTTP code is 400 or greater (other examples: 403, 500)
		curl_setopt($httpRequest, CURLOPT_FOLLOWLOCATION, true); // Follows PHP location header or redirects.
		curl_setopt($httpRequest, CURLOPT_MAXREDIRS, 3); // If there is more than 3 redirects from a URL, we assume it's the start of an infinite loop and we break it.
		curl_setopt($httpRequest, CURLOPT_RETURNTRANSFER, true); // Make sure to return as a string value rather than output it.
		curl_setopt($httpRequest, CURLOPT_SSL_VERIFYPEER, false);

		if ($httpRequestData !== null){ // If the request data (whether it is POST, DELETE, GET, UPDATE, etc) is not NULL
			if (gettype($httpRequestData) == "array"){
				$httpRequestData = http_build_query($httpRequestData); // Build a query out of it. for instance array("3" => "hi", "4" => "goodbye") would be 3=hi&4=goodbye
			}
			$httpRequestHeaders = array("Content-length: " . strlen($httpRequestData)); // Set the content length.
		}
		else{
			$httpRequestHeaders = array();
		}

		if ($httpRequestOptions !== null){ // If the request header options are not NULL
			if (gettype($httpRequestOptions) == "array"){
				foreach($httpRequestOptions as $key => $httpRequestOptionValue){
					if (is_int($key) == true){
						curl_setopt($httpRequest, $key, $httpRequestOptionValue);
					}
					else{
						if ($httpRequestOptionValue !== null){
							$httpRequestHeaders[] = $key . ": " . $httpRequestOptionValue;
						}
						else{
							$httpRequestHeaders[] = $key;
						}
					}
				}
			}
			else{
				$httpRequestHeaders[] = $httpRequestOptions;
			}
		}

		if (count($httpRequestHeaders) > 0){
			curl_setopt($httpRequest, CURLOPT_HTTPHEADER, $httpRequestHeaders); // Set the CURLOPT_HTTPHEADER to our value.
		}

		if ($httpRequestMethod == "GET"){
			curl_setopt($httpRequest, CURLOPT_URL, $httpRequestUrl . "?" . $httpRequestData); // Set the CURLOPT_URL to be the $httpRequestUrl plus the name/value pairs for GET.
		}
		else{
			curl_setopt($httpRequest, CURLOPT_URL, $httpRequestUrl); // Set the CURLOPT_URL to be the $httpRequestUrl
			curl_setopt($httpRequest, CURLOPT_POSTFIELDS, $httpRequestData); // Since the method is not GET, we'll be putting the data in POST fields (doesn't mean the method is POST however)
		}

		$httpResponse = curl_exec($httpRequest); // Execute the request and save it in response.
		$httpRequestError = curl_error($httpRequest) ; // Get the error (or if there isn't an error, it returns 0) of the curl_init / http request.
		curl_close($httpRequest); // Close CURL

		if ($httpRequestError == 0){ // If there isn't an error
			return $httpResponse; // Return the response
		}
		else{ // If there is an error
			$curlErrorCodes = array(
				"3" => "URL_MALFORMAT", "7" => "COULDNT_CONNECT", "18" => "PARTIAL_FILE",  "47" => "TOO_MANY_REDIRECTS", "63" => "FILESIZE_EXCEEDED", "67" => "LOGIN_DENIED"
			); // Basically, create an array with common CURL errors that'd be related to actions performed when doing HTTP requests.
			$curlErrorCodeReturned = settype($httpRequestError, "string"); // Convert the curl error from an integer to a string.
			return $curlErrorCodes[$curlErrorCodeReturned]; // Return the error message.
		}
	}

?>
