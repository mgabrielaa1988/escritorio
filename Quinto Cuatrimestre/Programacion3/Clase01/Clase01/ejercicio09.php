<?php

/**Aplicación Nº 9 (Carga aleatoria)
Definir un Array de 5 elementos enteros y asignar a cada uno de ellos un número (utilizar la
función rand ). Mediante una estructura condicional, determinar si el promedio de los números
son mayores, menores o iguales que 6. Mostrar un mensaje por pantalla informando el
resultado. */

$vec=array();
$acumulador=0;
$promedio;

for ($i=0; $i < 5; $i++) { 
    $vec[$i]=rand(1,10);
    //array_push($vec,rand(1,10));
    $acumulador+=$vec[$i];
    echo $vec[$i]."<br>";
}
$promedio=$acumulador/5;
echo "Promedio: ".$promedio."<br>";
if($promedio==6){
 echo "El promedio es igual a 6";
}
elseif($promedio<6){
    echo "El promedio es menor a 6";
}
else{
    echo "El promedio es mayor a 6";
}

?>