<?php
        require_once "Persona.php";

/*
$nombreApellido = "santiago zarza";

    $arch1 = fopen("Archivo1.txt","w");


    if($arch1){
        echo "se creo exitosamente";
        fwrite($arch1,$nombreApellido);
        fclose($arch1);
    }
    else {
        echo "no se creo";
    }

    $arch2 = fopen("Archivo1.txt","r");

    if($arch2){
        echo "se leyo exitosamente<br>";
        echo fread($arch2,filesize("Archivo1.txt"));
        fclose($arch2);
    }
    else {
        echo "no se leyo<br>";
    }


    $arch3 = fopen("archivo2.txt","a");
    $horario = date('h:i:s')."\r\n";
    if($arch3){
        $aux = fwrite($arch3,$horario);
        echo "Se escribio exitosamente";
        fclose($arch3);
    }
    else {
        echo "no se creo ni se escribio";
    }
*/
/*
    $perso1 = new Persona();
    $perso2 = new Persona();
    $perso3 = new Persona();
    $perso4 = new Persona();

    $perso1->_nombre = "juan";
    $perso1->_apellido = "perez";

    $perso2->_nombre = "carlos";
    $perso2->_apellido = "rodriguez";

    $perso3->_nombre = "ana";
    $perso3->_apellido = "juarez";

    $perso4->_nombre = "saraza";
    $perso4->_apellido = "saraza";



    if($perso1->Guardar()){
        echo "<br>Se Escrbio Existosamente.<br>";
    }
    else{
        echo "<br>No se creo<br>";
    }
    if($perso1->Leer()){
        echo "<br>Se Leyo exitosamente<br>";
    }
    else {
        echo "<br>No se leyo<br>";
    }
    */
    var_dump(Persona::TraerTodasLasPersonas());

?>