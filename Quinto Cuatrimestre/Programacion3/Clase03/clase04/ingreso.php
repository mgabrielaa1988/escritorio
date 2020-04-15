<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Clase 02</title>
</head>

<body>
    <FONT face="arial">
        <form action="escribir.php" method="post" enctype="multipart/form-data">
            Nombre: <input type="text" name="nombre" id="nombre"><br>
            Codigo: <input type="text" name="codigo" id="codigo"><br>
            <input type="file" name="archivo"><br>
            <input type="submit" value="Enviar">
            <input type="reset" value="Limpiar">
        </form>
    </FONT>
</body>

</html>