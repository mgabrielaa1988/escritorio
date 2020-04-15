
<?php

/**Listado.php: Se mostrará el listado completo de los juguetes (obtenidos de la base de datos) en una tabla (con
cabecera). Invocar al método Traer.
Nota: preparar la tabla para que muestre la imagen de la foto (si es que la tiene). */

require_once("./clases/juguete.php");
$array=Juguete->Traer();
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Listado</title>
</head>
<body>
    <table border="1" align="center">
        <tr>
            <td><h4>Tipo</h4></td>
            <td><h4>Precio</h4></td>
            <td><h4>Precio con IVA</h4></td>
            <td><h4>Pais</h4></td>
            <td><h4>Foto</h4></td>
        </tr>
        <?php
        foreach($array as $juguete)
        {
            ?> <tr>
                <td>
                    <?php echo $juguete->_tipo;?>
                </td>
                <td>
                    <?php echo $juguete->_precio; ?>
                </td>
                <td>
                    <?php echo $juguete->CalcularIva(); ?>
                </td>
                <td>
                    <?php echo $juguete->_paisOrigen; ?>
                </td>
                <td>
                if(juguete->_path!=""){
                    if(file_exists("imagenes/".$juguete->_pathImagen)){
                        <img src="<?php echo $juguete->_pathImagen;?>" alt="asd" height="100px" width="100px">
                    }
                    else{
                        <?php echo "No se encontro el archivo"; ?>
                    }
                }
                else{
                    <?php echo "No hay foto"; ?>
                }
                </td>
            </tr>
        <?php
        }
        ?>        
    </table>
</body>
</html>
