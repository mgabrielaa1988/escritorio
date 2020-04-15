<?php

require_once "BaseDatos.php";

class Producto{
    public $_pNumero;
    public $_pNombre;
    public $_precio;
    public $_tamano;

    public function __construct($num = null,$nom = null,$pre = null,$tam = null){
        if($num != null){$this->_pNumero = $num;}
        if($nom != null){$this->_pNombre = $nom;}
        if($pre != null){$this->_precio = $pre;}
        if($tam != null){$this->_tamano = $tam;}
    }
    
    public static function Traer($numero = null){
        $retorno = null;

        if ($numero != null) {
            $conexion = BaseDatos::Conectar();
            if ($conexion != null) {
            $consulta = "SELECT * FROM productos WHERE pNumero = {$numero}";

            $recurso = mysql_db_query(BaseDatos::$base,$consulta,$conexion);
                if ($recurso !== false) {
                    $producto = mysql_fetch_object($recurso);

                    $aux = get_object_vars($producto);
                    
                    $retorno = new Producto($aux["pNumero"],$aux["pNombre"],$aux["Precio"],$aux["Tamano"]);
                }
            
            BaseDatos::Desconectar();
            }
        }

        return $retorno;
    }

    public static function TraerTodos(){
        $retorno = array();

        $conexion = BaseDatos::Conectar();
        if ($conexion != null) {
        $consulta = "SELECT * FROM productos";

        $recurso = mysql_db_query(BaseDatos::$base,$consulta,$conexion);
            if ($recurso !== false) {
                while($producto = mysql_fetch_object($recurso)){
                $aux = get_object_vars($producto);

                array_push($retorno,new Producto($aux["pNumero"],$aux["pNombre"],$aux["Precio"],$aux["Tamano"]));
                }
                
            }
        
        BaseDatos::Desconectar();
        }

        return $retorno;
    }
}

?>