<?php

    $archivo = fopen("saludo.txt","a");
    
    $nombre = $_REQUEST['nombre'];
    $apellido = $_REQUEST['apellido'];
    fwrite($archivo,$nombre."\r\n");
    fwrite($archivo,$apellido."\r\n");
    fclose($archivo);

    echo "REQUEST<br/>";
    var_dump($_REQUEST);
