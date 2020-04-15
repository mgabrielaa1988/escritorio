<?php

require_once "BaseDatos.php";

class Envio{
    
    /**Numero del Proveedor */
    public $_numero;
    /**Numero del Producto */
    public $_pNumero;
    /**Cantidad Total*/
    public $_cantidad;

    public function __construct($numProvee= null, $numProdu= null, $cant = null){
        if($numProvee != null){$this->_numero = $numProvee;}
        if($numProdu != null){$this->_pNumero = $numProdu;}
        if($cant != null){$this->_cantidad = $cant;}
    }

    public static function TraerTodos(){
        $retorno = array();

        $conexion = BaseDatos::Conectar();
        if ($conexion != null) {
        $consulta = "SELECT * FROM envios";

        $recurso = mysql_db_query(BaseDatos::$base,$consulta,$conexion);
            if ($recurso !== false) {
                while($envio = mysql_fetch_object($recurso)){
                $aux = get_object_vars($envio);
                array_push($retorno,new Envio($aux["Numero"],$aux["pNumero"],$aux["Cantidad"]));
                }
                
            }
        
        BaseDatos::Desconectar();
        }

        return $retorno;
    }

}

?>