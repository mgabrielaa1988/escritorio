<?php

require_once "./clases/producto.php";

$op = "MOSTRAR";
switch ($op) {
    case 'ALTA':
        $p = new Producto($_REQUEST['nombre'],$_REQUEST['codigo']);
        if(Producto::Guardar($p))
        {
            echo "se guardo exitosamente";
        }
        else
        {
            echo "no se puedo guardar";
        }
        break;
    case 'MOSTRAR':
        Producto::TraerTodos();
    default:
        # code...
        break;
}