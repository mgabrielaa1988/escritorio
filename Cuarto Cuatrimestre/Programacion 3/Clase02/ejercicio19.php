<?php

abstract class FiguraGeometrica
{
    protected $_color;
    protected $_perimetro;
    protected $_superficie;

    public function __construct()
    {
        $this->$_color="sin color";
        $this->$_perimetro=0;
        $this->$_superficie=0;
    }

    public function getColor()
    {
        return $this->$_color;
    }

    public function setColor($newColor)
    {
        $this->$_color=$newColor;
    }

    public function ToString()
    {
        $datos = "Color: ".$this->$_color."<br>Perimetro: ".$this->$_perimetro."<br>Superficie: ".$this->$_superficie."<br>";
    }

    public abstract function Dibujar();

    protected abstract function CalcularDatos();
}

class Rectangulo extends FiguraGeometrica
{
    private $_ladoUno;
    private $_ladoDos;

    public function __construct($l1,$l2)
    {
        $this->$_ladoUno=$l1;
        $this->$_ladoDos=$l2;
        CalcularDatos();
    }

    public function ToString()
    {
        return "<br>Rectangulo<br>".parent::ToString();
    }

    public function Dibujar()
    {
        $dibujo="";
       for($i=0;$i<$this->$_ladoUno;$i++)
       {
           for($j=0;j<$this->$_ladoDos;j++)
           {
               $dibujo=$dibujo."*";
           }
           $dibujo=$dibujo."<br>";
       }
       return $dibujo;
    }

    protected function CalcularDatos()
    {
        parent::$_perimetro=($this->$_ladoUno*2+$this->$_ladoDos*2);
        parent::$_superficie=($this->$_ladoUno*$this->$_ladoDos);
    }
}

class Triangulo extends FiguraGeometrica
{
    private $_altura;
    private $_base;

    public function __construct($b,$h)
    {
        $this->$_altura=$h;
        $this->$_base=$b;
        CalcularDatos();
    }

    public function ToString()
    {
        return "<br>Triangulo<br>".parent::ToString();
    }

    public function Dibujar()
    {
       $dibujo="";
       $flag=0;
       for($i=$this->$_altura;$i>0;$i--)
       {
            $dibujo=$dibujo." *";
       }
       return $dibujo;
    }

    protected function CalcularDatos()
    {
        parent::$_perimetro=($this->$_base*3);
        parent::$_superficie=($this->$_base*$this->$_altura);
    }
}

?>