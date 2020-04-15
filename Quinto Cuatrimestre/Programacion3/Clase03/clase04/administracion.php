<?php

require_once "./clases/producto.php";

$nombre=$_POST["nombre"];
$codBarra=$_POST["codigo"];
$ruta_foto=$_FILES["archivo"]["name"];

$op = "ALTA";
switch ($op) {
    case 'ALTA':
        $producto = new Producto($nombre,$codBarra,$ruta_foto);
        if(Producto::Guardar($producto->ToString())==true && Archivo::Subir()==true)
        {
            echo "se guardo exitosamente";
        }
        else
        {
            echo "no se puedo guardar";
        }
        echo ($producto->ToString().".");
        break;
    case 'MOSTRAR':
        echo ("<br><br>Lista de Productos<br>");
        echo ("<table><tr><td>Nombre</td><td>Cod.Barra</td><td>Foto</td></tr>");
        foreach(Producto::TraerTodos()as $prod){
            echo ("<tr><td>".$prod->ToString()."</td>");
            echo ("<td><img src='./archivos/'".$prod->path_foto."></td></tr>");
        }
        echo ("</table>");
    default:
        # code...
        break;
    }
