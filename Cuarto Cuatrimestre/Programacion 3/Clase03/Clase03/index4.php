<?php

include_once "persona.php";

$pers1=new Persona();
$pers1->nombre="Gabriela";
$pers1->apellido="Aragon";
$pers1->Guardar();
$pers1->Leer();

?>