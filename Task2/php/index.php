<?php
if ($handle = opendir('files')) {
    while (false !== ($file = readdir($handle))) { 
        if ($file != "." && $file != "..") { 
            echo "$file ".hash('sha3-256',file_get_contents('files/'.$file))."</br>"; 
        } 
    }
    closedir($handle); 
}
?>