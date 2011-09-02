<?php

  function video($type, $preload, $url, $height, $width)
  {

      print "<video type=\"video/$type\" controls=\"controls\"";

      if ($preload == "true")
      {
	  print "preload=\"auto\" ";
      }
      elseif ($preload == ("false" || ""))
      {
	  print "preload=\"none\" ";
      }

      if ($height !== "")
      {
	  print "height=\"$height\" ";
      }
      else{
	  print "height=\"480px\" ";
      }
      
      if ($width !== "")
      {
	  print "width=\"$width\" ";
      }
      else{
	  print "width=\"640px\" ";
      }

      print ">Your browser does not support HTML5 video.</video>";

  }

?>
