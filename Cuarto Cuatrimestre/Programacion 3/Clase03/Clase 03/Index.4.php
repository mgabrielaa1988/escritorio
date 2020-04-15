<?php  
        require_once "Persona.php";
/*var_dump($_REQUEST);


die();
 $nombre = $_REQUEST["nombre"];
 $apellido = $_REQUEST["apellido"];

 echo $nombre."-".$apellido."<br>";

*/
$personaAguardar = new Persona($_REQUEST["nombre"],$_REQUEST["apellido"]);
$personaAguardar->Guardar();
//var_dump(Persona::TraerTodasLasPersonas());
foreach (Persona::TraerTodasLasPersonas() as $value) {
    echo "<br>".$value->nombre."-".$value->apellido."<br>";
}


?>