<?php

require_once "FiguraGeometrica.php";

class Rectangulo extends FiguraGeometrica{
    private $_ladoUno;
    private $_ladoDos;

    public function __construct($l1,$l2){
        $this->$_ladoUno=$l1;
        $this->$_ladoDos=$l2;
        CalcularDatos();
    }
protected function CalcularDatos(){
    parent::$_perimetro=($this->$_ladoUno*2+$this->$_ladoDos*2);
    parent::$_superficie=($this->$_ladoUno*$this->$_ladoDos);
}
public function Dibujar(){
    $dibujo="";
    for($i=0;$i<$this->$_ladoUno;$i++)
    {
        for($j=0;j<$this->$_ladoDos;$j++)
        {
            $dibujo=$dibujo."*";
        }
        $dibujo=$dibujo."<br>";
    }
    return $dibujo;
}
public function ToString(){
    return "<br>Rectangulo<br>".parent::ToString();
}

}