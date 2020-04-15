<?php

require_once "IParte 1.php";
require_once "IParte 2.php";


class Juguete implements IParte1, IParte2{
    private $tipo;
    private $precio;
    private $paisOrigen;
    private $pathImagen;

    public function __construct($type, $price, $country, $imgpath = null){
        $this->tipo = $type;
        $this->precio = $price;
        $this->precio += $this->CalcularIVA();
        $this->paisOrigen = $country;
        if ($imgpath != null) {$this->pathImagen = $imgpath;}
    }

    public function ToString(){
        $mostrar = $this->tipo."-".$this->precio."-".$this->paisOrigen;
        if (isset($this->pathImagen)) {
            $mostrar .="-".'<img src="'.$this->pathImagen.'">';
        }
        return $mostrar;
    }

    public function Agregar(){
        $retorno = true;

        try{
        $base = new PDO('mysql:host=localhost;dbname=juguetes_bd;', 'root','');

        $sql = "INSERT INTO juguetes (tipo,precio,pais,foto) VALUES ('".$this->tipo."',".$this->precio.",'".$this->paisOrigen."','".$this->pathImagen."')";

        $recurso = $base->prepare($sql);

        /*$recurso->bindValue(':tipo', $this->tipo, PDO::PARAM_STR);
        $recurso->bindValue(':precio', $this->precio, PDO::PARAM_STR);
        $recurso->bindValue(':pais', $this->paisOrigen, PDO::PARAM_STR);
        $recurso->bindValue(':foto', $this->pathImagen, PDO::PARAM_STR);*/

        $recurso->execute();

        }
        catch (PDOException $e){
            $retorno = false;
        }

        return $retorno;
    }

    public function Traer(){
        $retorno = array();
        
        try{
            $base = new PDO('mysql:host=localhost;dbname=juguetes_bd;', 'root','');
    
            $sql = 'SELECT * FROM juguetes';
    
            $recurso = $base->prepare($sql);

            $recurso->execute();

            $recurso->setFetchMode(PDO::FETCH_OBJ);
            
            foreach ($recurso->fetchall() as $juguete) {
                array_push($retorno,new Juguete($juguete->tipo,$juguete->precio,$juguete->pais,$juguete->foto));
            }
    
            }
            catch (PDOException $e){
                $retorno = false;
            }

        return $retorno;
    }

    public function CalcularIVA(){
        return $this->precio * 0.21;
    }

    public function Verifica($objetos){
        $retorno = false;

        foreach ($objetos as $value) {
            if (strcmp($this->tipo,$value->tipo)==0 && strcmp($this->paisOrigen,$value->paisOrigen)==0) {
                    $retorno = true;
                    break;
            }
        }


        return $retorno;
    }

    public static function MostrarLog(){
        $archivo = fopen("./archivos/juguetes_sin_foto.txt","r");
        if ($archivo != null) {
            echo fread($archivo,filesize("./archivos/juguetes_sin_foto.txt"));
        }
    }

    public function Modificar($tipo,$pais,$precio,$pathFoto){
        $retorno = true;

        try{
        $base = new PDO('mysql:host=localhost;dbname=juguetes_bd;', 'root','');

        $sql = "UPDATE juguetes SET precio=$precio, foto='$pathFoto'
                WHERE tipo='$tipo' AND pais='$pais' ";

        $recurso = $base->prepare($sql);

        $recurso->execute();

        }
        catch (PDOException $e){
            $retorno = false;
        }

        return $retorno;
    }
}
