<?php

echo 'Hola ';
echo 'Mundo!';
echo "<br>";

$nombre="gabriela";
$apellido="aragon";
echo $nombre." ".$apellido;
echo "<br>";

$nombre=strtolower($nombre);
$nombre=ucfirst($nombre);
$apellido=strtolower($apellido);
$apellido=ucfirst($apellido);
echo $nombre." ".$apellido;

?>