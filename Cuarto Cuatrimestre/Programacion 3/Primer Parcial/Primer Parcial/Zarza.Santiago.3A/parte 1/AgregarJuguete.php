<?php


require_once "clases/Juguete.php";


$auxtipo = $_POST["tipo"];
$auxprecio = $_POST["precio"];
$auxpais = $_POST["pais"];
$auxfoto = $_POST["foto"];

$auxdestino = "juguetes/imagenes/".$auxtipo.".".$auxpais.".".date("His").".".pathinfo($auxfoto,PATHINFO_EXTENSION);

$auxjuguete = new Juguete($auxtipo,$auxprecio,$auxpais,$auxdestino);

if (!$auxjuguete->Verifica($auxjuguete->Traer())) {
    if($auxjuguete->Agregar()){
        echo '<br/><br/><a href="Listado.php">Ir al Listado</a>';
         echo copy($auxfoto,$auxdestino); # esto de aca funciona
    }
    else {
        echo "<br/><br/>No se pudo Agregar a la base de datos.";
    }
}
else {
    echo "El Juguete ya existe en la base de datos.";
}