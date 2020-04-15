<?php

function potencias(){
    for($i=1;$i<5;$i++){
        echo "Numero:".$i." Cuadrado:".pow($i,2)." Cubo:".pow($i,3)." A la cuarta:".pow($i,4)."<br>";
    }
}

function invertirPalabra($palabra){
    echo "<br>".strrev($palabra)."<br>";
}
/*
function validarPalabra($palabra,$max){

}*/
?>