<?php
class Producto
{
    private $nombre;
    private $cod_barra;

    public function __construct($n = null, $c = null)
    {
        if($n!=null && $c!=null)
        {
            $this->nombre=$n;
            $this->cod_barra=$c;   
        }
        
    }

    public function ToString()
    {
        return $this->cod_barra." - ".$this->nombre."\r\n";
    }

    public static function Guardar($obj)
    {
        $retorno = false;
        $archivo = fopen("./archivos/productos.txt","a");
        if(fwrite($archivo,$obj->ToString()) != false)
        {
            $retorno = true;
        }
        fclose($archivo);
        return $retorno;

    }
    public static function TraerTodos()
    {
        $archivo = fopen("./archivos/productos.txt","r");
        while(!feof($archivo))
        {
            $texto = fgets($archivo)."<br>";	
            $array = explode ( " - " , $texto);
            $prod = new Producto($array[0],$array[1]);
            array_push($pila, $array[0], $array[1]);
        }
        echo $pila;
        fclose($archivo);
    }
}