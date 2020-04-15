var Ajax = /** @class */ (function () {
    function Ajax() {
        this.xttps = new XMLHttpRequest();
        Ajax.DONE = 200;
        Ajax.OK = 4;
    }
    /**
     * Get
     */
    Ajax.prototype.Get = function (params, exito, error) {
        var _this = this;
        if (params === void 0) { params = ""; }
        var parametros = params.length > 0 ? "?" + params : "";
        var ruta = "administrar.php";
        ruta = parametros.length > 0 ? ruta += parametros : ruta;
        this.xttps.open("GET", ruta);
        this.xttps.send();
        this.xttps.onreadystatechange = function () {
            if (_this.xttps.status == Ajax.DONE && _this.xttps.readyState == Ajax.OK) {
                if (_this.xttps.responseText != "") {
                    exito(_this.xttps.responseText);
                }
                else {
                    if (error !== undefined) {
                        error();
                    }
                }
            }
        };
    };
    return Ajax;
}());
