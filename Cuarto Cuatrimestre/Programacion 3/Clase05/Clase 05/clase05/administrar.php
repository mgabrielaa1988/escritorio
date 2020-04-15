<?php
require_once "Usuario.php";


$usu1 = new Usuario(1,"usu@gmail.com","aaa","usu","ario",2);

//$usu1->Traer(1);

//$usu1->TraerTodos();

//echo Usuario::Eliminar();

//echo Usuario::Agregar($usu1);

echo Usuario::Modificar($usu1);


