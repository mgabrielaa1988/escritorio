/**7. Se necesita mostrar por consola los primeros 20 números primos. Para ello realizar una función . 
Nota : Utilizar console.log() */

function NumerosPrimos() {
    var cantPrimos = 0;
    for (let i = 2; i < 100; i++) {
        var primo = true;
        var contador = 2;
        while (contador <= i / 2 && primo) {
            if (i % contador == 0) {
                primo = false;
            }
            contador++;
        }
        if (primo) {
            console.log(i);
            cantPrimos++;
        }
        if (cantPrimos == 20) {
            break;
        }
    }
}

NumerosPrimos();