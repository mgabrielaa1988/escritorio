<?php

abstract class FiguraGeometrica{
    protected $_color;
protected $_superficie;
protected $_perimetro;

public function __construct(){
$this->_color="black";
$this->_superficie=0;
$this->_perimetro=0;
}

public function GetColor(){
return $this->_color;
}

public function SetColor($strColor){
$this->_color=$strColor;
}

protected abstract function CalcularDatos();

public abstract function Dibujar();

public function ToString(){
    $datos = "Color: ".$this->$_color."<br>Perimetro: ".$this->$_perimetro."<br>Superficie: ".$this->$_superficie."<br>";
    return $datos;
}
}
