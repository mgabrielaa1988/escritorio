function MostrarSeleccionado(): void {
    /* Para obtener el valor del elemento seleccionado */
    var cod: string = (<HTMLInputElement>document.getElementById("chbx")).value;
    alert("Valor: " + cod);

    /* Para obtener el texto de la opcion  seleccionada*/
    var combo: any = document.getElementById("chbx");

    var selected = combo.options[combo.selectedIndex].text;
    alert("Opcion elegida: " + selected);
}