<?php

$nombre="Gabriela Aragon";
$archivo=fopen("texto.txt","w");

if($archivo!=0){
    fwrite($archivo,$nombre);
    echo "Se creo el archivo";
    fclose($archivo);
}
else{
    echo "No se pudo abrir el archivo";
}


?>