
<?php

$lectura=fopen("texto.txt","r");

if($lectura!=0){

    $contenido=fread($lectura,filesize("texto.txt"));
    echo "Contenido leido: <br/>".$contenido;
    fclose($lectura);
}
else{
    echo "No se pudo abrir el archivo";
}




?>