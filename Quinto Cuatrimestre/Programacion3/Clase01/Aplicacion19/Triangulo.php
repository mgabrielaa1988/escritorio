<?php

require_once "FiguraGeometrica.php";

class Triangulo extends FiguraGeometrica{
    protected $_base;
    protected $_altura;

    public function __construct($b,$h){
        $this->$_altura=$h;
        $this->$_base=$b;
        CalcularDatos();
    }
    protected function CalcularDatos(){
        parent::$_perimetro=($this->$_base*3);
        parent::$_superficie=($this->$_base*$this->$_altura);
    }
    public function Dibujar(){
        $dibujo="";
        $flag=0;
        for($i=$this->$_altura;$i>0;$i--)
        {
             $dibujo=$dibujo." *";
        }
        return $dibujo;
    }
    public function ToString(){
        return "<br>Triangulo<br>".parent::ToString();
    }
}
