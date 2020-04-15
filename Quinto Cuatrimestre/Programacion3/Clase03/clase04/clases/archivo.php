<?php

class Archivo
{
    public static function Subir()
    {
        $destino = "/clase04/archivos/" . $_FILES["archivo"]["name"];

        if (file_exists($destino)) {
            echo "El archivo ya existe. Verifique!!!";
            $uploadOk = FALSE;
        }

        if ($uploadOk === FALSE) {

            echo "<br/>NO SE PUDO SUBIR EL ARCHIVO.";
            return false;
        } else {
            //MUEVO EL ARCHIVO DEL TEMPORAL AL DESTINO FINAL
            if (move_uploaded_file($_FILES["archivo"]["tmp_name"], $destino)) {
                echo "<br/>El archivo " . basename($_FILES["archivo"]["name"]) . " ha sido subido exitosamente.";
                return true;
            } else {
                echo "<br/>Lamentablemente ocurri&oacute; un error y no se pudo subir el archivo.";
                return false;
            }
        }
    }
}