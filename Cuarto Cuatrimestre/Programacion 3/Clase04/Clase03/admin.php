
<?php

class Empleado{
    public $apellido;
    public $nombre;
    public $legajo;
    public $sueldo;
    public $pathFoto;

    public function __construct($ap,$nom,$leg,$suel,$foto){
        $this->apellido=$ap;
        $this->nombre=$nom;
        $this->legajo=$leg;
        $this->sueldo=$suel;
        $this->pathFoto=$foto;
    }

    public function ToString(){
        $msj=$this->apellido." - ".$this->nombre." - ".$this->legajo." - ".$this->sueldo." - ".$this->pathFoto."\r\n";
        return $msj;
    }

    public static function AgregarEmpleado($nuevoEmpleado){
        $archivo=fopen("listaDeEmpleados.txt","a");
        fwrite($archivo,$nuevoEmpleado->ToString());
        fclose($archivo);
    }

    public static function TraerTodos(){
        $retorno=array();
        $arch=fopen("listaDeEmpleados.txt","r");
        if($arch){
            while(!feof($arch)){
                $recupero=fgets($arch);
                if($recupero!=""&&$recupero!=" "){
                    $auxArray=explode(" - ",$recupero);
                    array_push($retorno,new Empleado($auxArray[0],$auxArray[1],$auxArray[2],$auxArray[3],$auxArray[4]));
                }
            }
            fclose($arch);
        }
        return $retorno;
    }
}

$path=$_FILES["foto"]["name"];
$empl1=new Empleado($_POST["apellido"],$_POST["nombre"],$_POST["legajo"],$_POST["sueldo"],$path);

Empleado::AgregarEmpleado($empl1);
$destino="fotosEmpleados/".$_POST["legajo"]."_".$_POST["apellido"]."_".$path.".".pathinfo($path,PATHINFO_EXTENSION);
echo move_uploaded_file($_FILES["foto"]["tmp_name"],$destino);

var_dump(Empleado::TraerTodos());

?>