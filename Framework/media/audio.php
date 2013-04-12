<?php

  function atlasui_audio($type, $preload, $url){
    print "<audio type=\"audio/$type\" controls=\"controls\" src=\"$url\"";
    if ($preload == "true")
    {
	print "preload=\"auto\"></audio>";
    }
    elseif ($preload == ("false" || ""))
    {
	print "preload=\"none\"></audio>";
    }
  }

?>
