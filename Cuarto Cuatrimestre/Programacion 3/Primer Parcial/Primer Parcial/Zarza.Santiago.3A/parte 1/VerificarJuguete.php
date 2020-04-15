<?php

require_once "./clases/Juguete.php";

$nuevojuguete = new Juguete($_GET["tipo"],202,$_GET["pais"]);

if($nuevojuguete->Verifica($nuevojuguete->Traer())){
    echo $nuevojuguete->ToString();
}
else {
    echo "No existe Ningun Juguete con estas caracteristicas registrado.";
}