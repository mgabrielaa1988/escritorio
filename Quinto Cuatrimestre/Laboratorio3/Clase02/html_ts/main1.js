"use strict";
function Click() {
    alert("desde funcion...");
}
var Manejadora = /** @class */ (function () {
    function Manejadora() {
    }
    Manejadora.Click = function () {
        alert("desde clase...");
    };
    return Manejadora;
}());
//# sourceMappingURL=main1.js.map