function CrearTabla(filas, columnas) {
    var table = document.createElement("table");
    table.border = "2";
    table.align = "center";
    table.createTBody();
    for (var i = 0; i < parseInt(filas, 10); i++) {
        var row = table.insertRow(0);
        for (var j = 0; j < parseInt(columnas, 10); j++) {
            var cell = row.insertCell(0);
            cell.height = "50";
            cell.width = "100";
        }
    }
    var nodeSpecialNode = document.getElementById("auxDiv");
    nodeSpecialNode.appendChild(table);
}
