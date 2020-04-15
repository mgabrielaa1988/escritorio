
<?php

/**Juguete.php. 
Crear, en ./clases, la clase Juguete con atributos privados (tipo, precio, paisOrigen y pathImagen),
constructor (con pathImagen como parámetro opcional), un método de instancia ToString(), que retorna los
datos de la instancia (separado por un guión medio). */

/* Crear, en ./clases, la interface IParte1. Esta interface poseerá los métodos:
● Agregar: agrega, a partir de la instancia actual, un nuevo registro en la tabla juguetes (id, tipo, precio, pais,
foto), de la base de datos juguetes_bd. Retorna true, si se pudo agregar, false, caso contrario.
● Traer: retorna un array de objetos de tipo Juguete, recuperados de la base de datos.
● CalcularIVA: retorna el precio del juguete más el 21%.
● Verificar: retorna true, si la instancia actual no existe en el array de objetos de tipo Juguete que recibe
como parámetro. Caso contrario retorna false.
Implementar la interface en la clase Juguete.*/

require_once "./IParte1.php";
require_once "./AccesoDatos.php";

class Juguete implements IParte1
{
    private $_tipo;
    private $_precio;
    private $_paisOrigen;
    private $_pathImagen;

    public function __construct($tipo,$precio,$paisOrigen,$path=null){
        $this->_tipo=$tipo;
        $this->_precio=$precio;
        $this->_paisOrigen=$paisOrigen;
        $this->_path = $path != null ? $path : "";
    }

    public function ToString(){
        return `{$this->_tipo}-{$this->_precio}-{$this->_paisOrigen}-{$this->_pathImagen}`;
    }

    public function Agregar() {
        $objetoDatos = AccesoDatos::ObtenerObjetoAcceso();
        $consulta =$objetoDatos->RetornarConsulta("INSERT INTO juguetes (tipo, precio, pais, foto)"
                                                    . "VALUES(:tipo, :precio, :pais, :foto)"); 
        
        $consulta->bindValue(':tipo', $this->_tipo, PDO::PARAM_INT);
        $consulta->bindValue(':precio', $this->_precio, PDO::PARAM_INT);
        $consulta->bindValue(':pais', $this->_paisOrigen, PDO::PARAM_INT);
        $consulta->bindValue(':foto', $this->_pathImagen, PDO::PARAM_STR);
        return $consulta->execute();
    }

    public function Traer() {
        $auxReturn = array();
        $objetoDatos = AccesoDatos::ObtenerObjetoAcceso();
        $consulta = $objetoDatos->RetornarConsulta('SELECT * FROM juguetes'); 
        $consulta->execute();
        $consulta->setFetchMode(PDO::FETCH_LAZY);
        foreach ($consulta as $juguete) {
            $auxJuguete = new Juguete($juguete->_tipo,$juguete->_precio,$juguete->_paisOrigen,$juguete->_pathImagen);
            array_push($auxReturn, $auxJuguete);
        }
        return $auxReturn;
    }

    public function CalcularIva() {
        $auxIva = $this->_precio *21 /100;            
        return $this->_precio + $auxIva;
    }

    public function Verificar($juguete) {
        $array=Juguete->Traer();
        $retorno=false;
        if($array!=null){
            foreach($array as $jug){
                if($jug->_tipo==$juguete->_tipo && $jug->_paisOrigen==$juguete->_paisOrigen){
                    $retorno=true;
                }
            }
        }
        return $retorno;
    }


    public static function MostrarLog(){
        $retorno="";
        $archivo=fopen("./archivos/juguetes_sin_foto.txt","r");
        if($archivo!=false){
            while(!feof($archivo)){
                $retorno.=fgets($archivo);
                $retorno.="<br>";
            }
        }
        fclose($archivo);
        return $retorno;
    }
}

?>