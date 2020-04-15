
<?php

/**MostrarLog.php: Muestra por pantalla todo lo registrado en el archivo de texto “juguetes_sin_foto.txt”. Para ello,
agregar un método estático (en Juguete), llamado MostrarLog. */

require_once("./clases/juguete.php");
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>MostrarLog</title>
</head>
<body>
    <?php
        echo Juguete::MostrarLog();
    ?>
</body>
</html>

