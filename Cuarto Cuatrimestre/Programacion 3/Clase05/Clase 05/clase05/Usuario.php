<?php

class Usuario{
    public $id;
    public $correo;
    public $clave;
    public $nombre;
    public $apellido;
    public $perfil;

    public function __construct($id=null,$correo=null,$clave=null,$nombre=null,$apellido=null,$perfil=null){
        if ($id != null) {$this->id = $id;}
        if ($correo != null) {$this->correo = $correo;}
        if ($clave != null) {$this->clave = $clave;}
        if ($nombre != null) {$this->nombre = $nombre;}
        if ($apellido != null) {$this->apellido = $apellido;}
        if ($perfil != null) {$this->perfil = $perfil;}
    }

    public function Traer($id = null){
        //$retorno = array();
        if($id != null){
            $conexion = BaseDatos::BasedatosConexion();
            if($conexion != null){
                //echo "conexion exitosa.<br/>";
            $sql = "SELECT * FROM usuarios WHERE id={$id}";

            $recurso = mysql_db_query(BaseDatos::$base,$sql,$conexion);

            $usuario = null;
            if ($recurso !== false) {
                while ($fila = mysql_fetch_object($recurso)) {
                    var_dump($fila);
                }

            }
            else {
                echo "<br/>null<br/>";
            }
            //var_dump($_POST);

            BaseDatos::CerrarConexion();
            }
            else {
                echo "no se pudo establecer conexion con la base";
            }

        }
    }

    public function TraerTodos(){
        //$retorno = null;
        $conexion = BaseDatos::BasedatosConexion();
        if($conexion != null){

            $sql = "SELECT * FROM usuarios";

            $recurso = mysql_db_query(BaseDatos::$base,$sql,$conexion);
            
            if($recurso !== false){
                while ($fila = mysql_fetch_object($recurso)) {
                    echo "<br/>";
                    var_dump($fila);
                    echo "<br/>";
                }
            }
            else {
                echo "<br/>null<br/>";
            }

            BaseDatos::CerrarConexion();
        }
        else {
            echo "no se pudo establecer conexion con la base";
        }


    }

    public static function Eliminar(){
        $retorno = false;

        $conexion = BaseDatos::BasedatosConexion();
        if($conexion != null){

            $sql = "DELETE FROM usuarios";

            $recurso = mysql_db_query(BaseDatos::$base,$sql,$conexion);
            if($recurso !== false){
                $retorno = true;
            }
            else {
                echo "<br/>null<br/>";
            }

            BaseDatos::CerrarConexion();
        }
        else {
            echo "no se pudo establecer conexion con la base";
        }

        return $retorno;
    }

    public static function Agregar($obj){
        $retorno = false;
        $conexion = BaseDatos::BasedatosConexion();
        if($conexion != null){
            $sql = "INSERT INTO usuarios (id,correo,clave,nombre,apellido,perfil) VALUES (".$obj->id.",'".$obj->correo."','".$obj->clave."','".$obj->nombre."','".$obj->apellido."',".$obj->perfil.")";

            $recurso = mysql_db_query(BaseDatos::$base,$sql,$conexion);
            if($recurso !== false){
                $retorno = true;
            }
            else {
                echo "<br/>null<br/>";
            }

            BaseDatos::CerrarConexion();
        }
        else {
            echo "no se pudo establecer conexion con la base";
        }

        return $retorno;
    }

    public static function Modificar($obj){
        $retorno = false;
        $conexion = BaseDatos::BasedatosConexion();
        if($conexion != null){
            $sql = "UPDATE usuarios SET correo = 'cambiado@hotmail.com', clave ='otraclave', nombre = 'otrononmbre', apellido = 'otroapellido', perfil = 9
                    WHERE id = {$obj->id}";

            $recurso = mysql_db_query(BaseDatos::$base,$sql,$conexion);
            if($recurso !== false){
                $retorno = true;
            }
            else {
                echo "<br/>null<br/>";
            }

            BaseDatos::CerrarConexion();
        }
        else {
            echo "no se pudo establecer conexion con la base";
        }

        return $retorno;
    }

}

class BaseDatos{
    public static $base="productos";//usuarios
    private static $user="root";//root
    private static $clave="";//""

    public static function BasedatosConexion(){
       return $conec = mysql_connect("localhost",BaseDatos::$user,BaseDatos::$clave);
    }

    public static function CerrarConexion(){
        mysql_close();
    }
}





