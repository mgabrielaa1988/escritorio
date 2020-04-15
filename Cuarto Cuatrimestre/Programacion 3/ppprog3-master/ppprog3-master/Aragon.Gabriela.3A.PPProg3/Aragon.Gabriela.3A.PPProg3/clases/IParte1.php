
<?php

/**Crear, en ./clases, la interface IParte1. Esta interface poseerá los métodos:
● Agregar: agrega, a partir de la instancia actual, un nuevo registro en la tabla juguetes (id, tipo, precio, pais,
foto), de la base de datos juguetes_bd. Retorna true, si se pudo agregar, false, caso contrario.
● Traer: retorna un array de objetos de tipo Juguete, recuperados de la base de datos.
● CalcularIVA: retorna el precio del juguete más el 21%.
● Verificar: retorna true, si la instancia actual no existe en el array de objetos de tipo Juguete que recibe
como parámetro. Caso contrario retorna false.
Implementar la interface en la clase Juguete. */


    interface IParte1 {
        public function Agregar();
        public function Traer();
        public function CalcularIva();
        public function Verificar();
    }
?>