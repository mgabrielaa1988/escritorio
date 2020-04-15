<?php

$destino= "archivos/".$_FILES["archivo"]["name"];

function Subir()
{
    if(move_uploaded_file($_FILES["archivo"]["tmp_name"], $destino))
    {
        echo"<br>El archivo se subio";
    }
    else
    {
        echo"El archivo no se subio";
    }

}

?>