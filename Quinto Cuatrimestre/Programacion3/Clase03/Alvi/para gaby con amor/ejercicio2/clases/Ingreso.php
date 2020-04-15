<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Subir una imagen</title>
</head>
<body>
    <form action="../administracion.php" method="post" enctype="multipart/form-data">
    <span>Nombre:</span>
    <input type="text" name="nombre" id="nombre">
    <br>
    <span>Codigo de Barra</span>
    <input type="text" name="codBarra" id="codBarra">
    <br>
    <tr>
    <td>
    <input type="file" name="archivo">
    </td>
    </tr> 
    <tr>
    <td>
    <input type="submit" value="Subir">
    </td>
    </tr>
    <tr>
    <td>
    <input type="reset" value="Limpiar">
    </td>
    </tr>
    <br>
    
    </form>

</body>
</html>