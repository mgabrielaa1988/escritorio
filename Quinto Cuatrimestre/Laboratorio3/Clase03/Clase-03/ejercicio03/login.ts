if (localStorage.getItem("empleados") == null) {
    localStorage.setItem("empleados", "Juan-123,Rosa-456,Carlos-666");///solo se puede guardar strings
}

function Loguear() {
    var nombre: string = (<HTMLInputElement>document.getElementById("nombre")).value;
    var legajo: string = (<HTMLInputElement>document.getElementById("legajo")).value;

    var emp: string | null = "";
    emp = localStorage.getItem("empleados");
    if (emp != null) {
        var arrayEmp = emp.split(",");
        for (var i = 0; i < arrayEmp.length; i++) {
            var cadaEmp = arrayEmp[i].split("-");
            if (cadaEmp[0] == nombre || cadaEmp[1] == legajo) {
                console.log("Usuario existente");
                alert("Usuario existente");
                window.location.href="principal.html";
                break;
            }
        }
    }
}