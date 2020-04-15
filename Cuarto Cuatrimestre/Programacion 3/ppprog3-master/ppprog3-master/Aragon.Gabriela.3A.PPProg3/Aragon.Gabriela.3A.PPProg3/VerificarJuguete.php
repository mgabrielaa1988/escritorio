
<?php

/*VerificarJuguete.php: Se recibe por GET el tipo y el paisOrigen, si coincide con algún registro de la base de datos
(invocar al método Traer) retornar los datos del objeto (invocar al ToString) más su precio con Iva incluído. Caso
contrario informar: si no coincide el tipo o el paisOrigen o ambos.*/

require_once "./clases/juguete.php";

if(isset($_GET['tipo']) && isset($_GET['pais']))
{
    $array=Juguete->Traer();
    $seEncontro=false;
    foreach($array as $juguete)
    {
        if($juguete->_tipo==$_GET['tipo'] && $juguete->_paisOrigen==$_GET['pais'])
        {
            $seEncontro=true;
            echo $juguete->ToString();
        }
    }
    if(!$seEncontro)
    echo "No se encontro";
}

?>