
<?php

/* AgregarJugueteSinFoto.php: Se recibe por POST el tipo, el precio y el paisOrigen. Se invocará al método Agregar.
Si retorna true, se debe de escribir en un archivo de texto la fecha (con horas y minutos) más la información del
juguete (guardarlo en ./archivos/juguetes_sin_foto.txt). Mostrar por pantalla un mensaje de éxito.
Si retorna false, se mostrará por pantalla la información del juguete. */

    require_once "./clases/juguete.php";
    class AgregarSinFoto {
        public static function AgregarJugueteSinFoto() {
            $auxReturn = new stdClass();
            $auxReturn->Exito = false;
            $auxReturn->Mensaje = "No se ha podido agregar";
            $tipo = isset($_POST["tipo"]) ? $_POST["tipo"] : "";
            $precio = isset($_POST["precio"]) ? $_POST["precio"] : "";
            $paisOrigen = isset($_POST["paisOrigen"]) ? $_POST["paisOrigen"] : "";
            $auxJuguete = new Juguete($tipo, $precio, $paisOrigen);
            if($auxJuguete->Agregar()) {
                $auxReturn->Exito = true;
                $auxReturn->Mensaje = "Se ha agregado";

                $archivo=fopen("./archivos/juguetes_sin_foto.txt","a");
                fwrite($archivo, date("d/m/Y-H:i").trim($_POST['tipo'])."-".trim($_POST['precio'])."-".trim($_POST['paisOrigen'])."\r\n"); 
                fclose($archivo);
            }
            return $auxReturn;
        }
    }
?>