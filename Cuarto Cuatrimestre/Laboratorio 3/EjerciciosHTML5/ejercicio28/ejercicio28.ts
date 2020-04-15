
function CrearTabla(filas: string, columnas: string)
{
    var table: HTMLTableElement = (<HTMLTableElement>document.createElement("table"));
    (<HTMLTableElement>table).border = "2";
    (<HTMLTableElement>table).align ="center";
    (<HTMLTableElement>table).createTBody();

    for(let i=0; i<parseInt(filas, 10);i++)
    {
        let row: HTMLTableRowElement =(<HTMLTableElement>table).insertRow(0);

       for(let j=0; j<parseInt(columnas, 10);j++)
        {
            let cell: HTMLTableDataCellElement = (<HTMLTableRowElement>row).insertCell(0);
            (<HTMLTableDataCellElement>cell).height = "50";
            (<HTMLTableDataCellElement>cell).width = "100";
        }
    }

    var nodeSpecialNode: HTMLElement = (<HTMLElement> document.getElementById("auxDiv"));
    (<HTMLElement>nodeSpecialNode).appendChild((<HTMLElement>table));
}
