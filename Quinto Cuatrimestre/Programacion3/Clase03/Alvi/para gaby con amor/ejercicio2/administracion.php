<?php

require_once "./clases/Producto.php";
require_once "./clases/Archivo.php";

$op="Alta";
    switch ($op) {
        case 'Alta':
            $path=$_FILES["archivo"]["name"];
            $p=new Producto($_REQUEST["nombre"],$_REQUEST["codBarra"],$path);
            if(Producto::Guardar($p) && Archivo::Subir())
            {
                echo"Se guardo";
            }
            else
            {
                echo"No se guardo";
            }
            break;
        case 'Mostrar':
            /*echo("<br>Productos:<br>");
            foreach(Producto::TraerTodosLosProductos() as $p)
            {
                echo($p->ToString());
                echo("<img src= Archivos/".$p->_path_foto.">");
                echo("<br>");
            }*/
            break;    
        default:
        echo"estoy en el default";
            break;
    }
?>