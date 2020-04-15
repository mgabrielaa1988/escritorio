<?php

require_once "clases/Juguete.php";

$auxtipo = $_POST["tipo"];
$auxprecio = $_POST["precio"];
$auxpais = $_POST["pais"];
$auxfoto = $_POST["foto"];

$auxnuevodestino = "juguetesModificados/".$auxtipo.".".$auxpais.".modificado.".date("His").".".pathinfo($auxfoto,PATHINFO_EXTENSION);
$auxjuguete = new Juguete($auxtipo,$auxprecio,$auxpais,$auxnuevodestino);

if ($auxjuguete->Modificar($auxtipo,$auxpais,$auxprecio,$auxnuevodestino)) {


    if(copy($auxfoto,$auxnuevodestino)){
        echo '<a href="Listado.php">Ver Listado</a>';
    }
    else {
        echo "Se Pudo Modificar en La base de Datos, pero No se Pudo mover a la carpera 'juguetesModificados/'.";
    }
}
else {
    echo "El Juguete no se pudo modificar en la base de datos.";
}

