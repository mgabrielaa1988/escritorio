<?php

class BaseDatos{

    public static $base = "utn";
    public static $user = "root";
    public static $password = "";
   
    public static function Conectar(){
        return mysql_connect("localhost",BaseDatos::$user,BaseDatos::$password);
    }

    public static function Desconectar(){
        mysql_close();
    }
}
