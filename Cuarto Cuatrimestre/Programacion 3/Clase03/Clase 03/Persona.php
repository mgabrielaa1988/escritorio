<?php

class Persona 
{
    public $nombre;
    public $apellido;


    public function __construct($nom = null, $ape = null){
        if($nom != null){$this->nombre = $nom;}
        if($ape != null){$this->apellido = $ape;}
    }

    public function Guardar(){
        # Escribir en modo 'a'
        $retorno = false;
        $archivo = fopen("Nombreyapellido.txt","a");
        
        if($archivo){

            if(fwrite($archivo,$this->ToString()) > 0){
                $retorno = true;
            }
            fclose($archivo);
            echo '<a href="Ingreso.html">Ingrese para volver al Ingreso.</a>';
        }
        else {
            "<br>Ocurrio un error.<br>";
        }
        return $retorno;
    }

    public function Leer(){
        # Leer en modo 'r'
        $retorno = false;
        $archivo = fopen("Nombreyapellido.txt","r");
        if($archivo){
            echo "<br>".fread($archivo,filesize("Nombreyapellido.txt"))."<br>";
            $retorno = true;
            fclose($archivo);
        }

        return $retorno;
    }

    public function ToString(){
        $retorno = $this->nombre."-".$this->apellido."\r\n";
        return $retorno;
    }

    public static function TraerTodasLasPersonas(){
        $retorno = array();
        $archivo = fopen("Nombreyapellido.txt","r");
        if($archivo){
            while (!feof($archivo)) {
                $linea = fgets($archivo);

                if($linea != " " && $linea != ""){
                    $auxarray = explode("-",$linea);

                    $auxpersona = new Persona($auxarray[0],$auxarray[1]);

                    array_push($retorno,$auxpersona);
                }
            }
            fclose($archivo);
        }
        else {
            echo "<br>Hubo in problema al abrir el archivo<br>";
        }

        return $retorno;
    }
}


?>