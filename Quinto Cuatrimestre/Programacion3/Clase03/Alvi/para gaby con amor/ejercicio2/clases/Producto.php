<?php

include_once "Archivo.php";

class Producto
{
    private $_nombre;
    private $_codBarra;
    public $_path_foto;

    public function __construct($n=null, $c=null, $p=null)
    {
        if($n!=null && $c!=null)
        {
            $this->_nombre=$n;
            $this->_codBarra=$c;
            $this->_path_foto=$p;
        }
    }

    public function ToString()
    {
        $retorno = $this->_codBarra." - ".$this->_nombre." - ".$this->_path_foto."\r\n";
        return $retorno;
    }
    
    public static function Guardar($obj)
    {
        $archivo=fopen("Archivos/producto.txt", "a");
        $escribio=fwrite($archivo, $obj->ToString());
        $retorno=null;
        if($escribio!= false)
        {
            echo"<br> Escribio ";
            $retorno=true;
        }
        else
        {
            echo"<br> Noup";
        }
        return $retorno;
        fclose($archivo);
    }

    public static function TraerTodosLosProductos()
    {   
        $archivo=fopen("Archivos/producto.txt", "r");
        $productos=array();
        while(!feof($archivo))
        {
            $productosAux=explode(" - ",fgets($archivo));
            if(isset($productosAux[1]))
            {
                $obj=new Producto($productosAux[0], $productosAux[1], $productosAux[2]);
                array_push($productos, $obj);
            }
        }
        return $productos;
    }
}

?>