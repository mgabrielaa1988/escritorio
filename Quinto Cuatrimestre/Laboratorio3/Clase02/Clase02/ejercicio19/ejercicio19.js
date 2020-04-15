"use strict";
function MostrarSeleccionado() {
    /* Para obtener el valor del elemento seleccionado */
    var cod = document.getElementById("chbx").value;
    alert("Valor: " + cod);
    /* Para obtener el texto de la opcion  seleccionada*/
    var combo = document.getElementById("chbx");
    var selected = combo.options[combo.selectedIndex].text;
    alert("Opcion elegida: " + selected);
}
//# sourceMappingURL=ejercicio19.js.map