function CrearOpciones(opciones) {
    var auxString = document.getElementById("txtOpciones").value;
    var splitString = auxString.split("\n");
    var selectNode = document.createElement("select");
    splitString.forEach(function (elementAux) {
        var auxOption = document.createElement("option");
        auxOption.text = elementAux;
        selectNode.add(auxOption);
        document.getElementById("txtOpciones").value = "";
    });
    var nodeSpecialNode = document.getElementById("auxDiv");
    nodeSpecialNode.appendChild(selectNode);
    console.log(document.getElementById("txtOpciones").value);
}
