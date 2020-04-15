<?php
class Producto
{
    private $nombre;
    private $cod_barra;
    private $path_foto;

    public function __construct($n = null, $c = null, $p = null)
    {
        if ($n != null && $c != null && $p != null) {
            $this->nombre = $n;
            $this->cod_barra = $c;
            $this->path_foto = $p;
        }
    }

    public function ToString()
    {
        return $this->cod_barra . "-" . $this->nombre . "-" . $this->path_foto . "\r\n";
    }

    public static function Guardar($obj)
    {
        $retorno = false;
        $archivo = fopen("./archivos/productos.txt", "a+");
        if (fwrite($archivo, $obj->ToString()) != false) {
            $retorno = true;
        }
        fclose($archivo);
        return $retorno;
    }
    public static function TraerTodos()
    {
        $pila =array();
        $archivo = fopen("./archivos/productos.txt", "r+");
        while (!feof($archivo)) {
            $texto = fgets($archivo) . "<br>";
            $array = explode("-", $texto);
            if($array[0]!=""){
                $prod = new Producto($array[0], $array[1],$array[2]);
            array_push($pila, $prod);
            }
        }
        echo $pila;
        fclose($archivo);
        return $pila;
    }
}
