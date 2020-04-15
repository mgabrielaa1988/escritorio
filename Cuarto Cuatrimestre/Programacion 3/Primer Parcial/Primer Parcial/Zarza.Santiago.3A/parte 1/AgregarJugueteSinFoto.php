<?php

    require_once "./clases/Juguete.php";

    $nuevojuguete = new Juguete($_POST["tipo"],$_POST["precio"],$_POST["pais"]);

    if($nuevojuguete->Agregar()){
        $archivo = fopen("archivos/juguetes_sin_foto.txt","a");
        if ($archivo != null) {
            if(fwrite($archivo,date("H:i")."-".$nuevojuguete->ToString()."\r\n")){
                echo "se logro agregar exitosamente a la base y al archivo.";
            }

            fclose($archivo);
        }
    }
    else {
        echo $nuevojuguete->ToString();
    }
