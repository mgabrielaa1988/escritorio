<?php

class Persona
{
    public $nombre;
    public $apellido;

    public function Guardar(){
        $escritura=fopen("persona.txt","a");
        $pers=$this->ToString();
        if($escritura!=0){
            $contenido=fwrite($escritura,$pers);
            echo "Contenido agregado<br/>";
            fclose($escritura); 
            return true;
        }
        else{
            return false;
        }
    }

    public function Leer(){
        $lectura=fopen("persona.txt","r");
        if($lectura!=0){
            $contenido=fread($lectura,filesize("persona.txt"));
            echo "Contenido leido<br/>";
            fclose($lectura); 
            return true;
        }
        else{
            return false;
        }
    }

    public function ToString(){
        $retorno=$this->nombre." - ".$this->apellido."\r\n";
        return $retorno;
    }

    public function TraerTodasLasPersonas(){
        
    }
}



?>