<?php

$nombre=fopen("texto.txt","r");
$lectura=fopen("texto2.txt","a");
$hora=date("d/M/Y H:i:s");

if($lectura!=0 && $nombre!=0){

    $agregoNombre=fread($nombre,filesize("texto.txt"));
    $contenido=fwrite($lectura,$agregoNombre." ");
    $contenido=fwrite($lectura,$hora);
    echo "Contenido agregado";
    fclose($nombre);
    fclose($lectura);
}
else{
    echo "No se pudo abrir el archivo";
}
?>