<?php
    require_once "./clases/Juguete.php";

$nuevojuguete = new Juguete("videojuego",125,"españa");


$auxmostrar = "<table>";

foreach ($nuevojuguete->Traer() as $juguete) {
    $auxmostrar .= "<tr><td>".$juguete->ToString()."</td></tr>";
}
$auxmostrar .= "</table>";


echo $auxmostrar;

