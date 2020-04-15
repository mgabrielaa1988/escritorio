/// <reference path="Ajax.ts" />
//import { Ajax } from "./Ajax";
var Funciones;
(function (Funciones) {
    function MostrarProductos() {
        var objeto = new Ajax();
        objeto.Get("accion=1", Funciono, Error);
    }
    Funciones.MostrarProductos = MostrarProductos;
    function ProveedoresQuilmes() {
        var objeto = new Ajax();
        objeto.Get("accion=2", Funciono, Error);
    }
    Funciones.ProveedoresQuilmes = ProveedoresQuilmes;
    function EnviosEntre200y300() {
        var objeto = new Ajax();
        objeto.Get("accion=3", Funciono, Error);
    }
    Funciones.EnviosEntre200y300 = EnviosEntre200y300;
    function ProductosEnviados() {
        var objeto = new Ajax();
        objeto.Get("accion=4", Funciono, Error);
    }
    Funciones.ProductosEnviados = ProductosEnviados;
    function Primeros3Productos() {
        var objeto = new Ajax();
        objeto.Get("accion=5", Funciono, Error);
    }
    Funciones.Primeros3Productos = Primeros3Productos;
    function ProveedoresyProductosEnviados() {
        var objeto = new Ajax();
        objeto.Get("accion=6", Funciono, Error);
    }
    Funciones.ProveedoresyProductosEnviados = ProveedoresyProductosEnviados;
    function MontoTotalEnvios() {
        var objeto = new Ajax();
        objeto.Get("accion=7", Funciono, Error);
    }
    Funciones.MontoTotalEnvios = MontoTotalEnvios;
    function MontoDeProducto1PorProveedor102() {
        var objeto = new Ajax();
        objeto.Get("accion=8", Funciono, Error);
    }
    Funciones.MontoDeProducto1PorProveedor102 = MontoDeProducto1PorProveedor102;
    function ProductosPorProveedoresdeAvellaneda() {
        var objeto = new Ajax();
        objeto.Get("accion=9", Funciono, Error);
    }
    Funciones.ProductosPorProveedoresdeAvellaneda = ProductosPorProveedoresdeAvellaneda;
    function DatosDeProveedoresConLetraI() {
        var objeto = new Ajax();
        objeto.Get("accion=10", Funciono, Error);
    }
    Funciones.DatosDeProveedoresConLetraI = DatosDeProveedoresConLetraI;
    function Funciono(respuesta) {
        document.getElementById("muestra").innerHTML = respuesta;
    }
    function Error() {
        alert("A ocurrido un error.");
    }
})(Funciones || (Funciones = {}));
