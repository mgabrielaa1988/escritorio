<?php

    class Archivo
    {   
        public static function Subir()
        {
            $destino="Archivos/".$_FILES["archivo"]["name"];
            $subio=FALSE;
            if(file_exists($destino)==FALSE)
            {
                move_uploaded_file($_FILES["archivo"]["tmp_name"], $destino);
                echo"<br>El archivo se subio<br>";
                $subio=TRUE;
            }
            else
            {
                echo"El archivo no se subio";
            }
            return $subio;
        }
    }

?>