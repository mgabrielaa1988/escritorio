/// <reference path="Ajax.ts" />

//import { Ajax } from "./Ajax";


namespace Funciones{

    export function MostrarProductos() {
        var objeto : Ajax = new Ajax();

        objeto.Get("accion=1",Funciono,Error);
    }

    export function ProveedoresQuilmes() {
        var objeto : Ajax = new Ajax();

        objeto.Get("accion=2",Funciono,Error);
    }

    export function EnviosEntre200y300() {
        var objeto : Ajax = new Ajax();

        objeto.Get("accion=3",Funciono,Error); 
    }

    export function ProductosEnviados() {
        var objeto : Ajax = new Ajax();

        objeto.Get("accion=4",Funciono,Error);
    }

    export function Primeros3Productos() {
        var objeto : Ajax = new Ajax();

        objeto.Get("accion=5",Funciono,Error);
    }

    export function ProveedoresyProductosEnviados() {
        var objeto : Ajax = new Ajax();

        objeto.Get("accion=6",Funciono,Error);
    }

    export function MontoTotalEnvios() {
        var objeto : Ajax = new Ajax();

        objeto.Get("accion=7",Funciono,Error);
    }

    export function MontoDeProducto1PorProveedor102() {
        var objeto : Ajax = new Ajax();

        objeto.Get("accion=8",Funciono,Error);
    }

    export function ProductosPorProveedoresdeAvellaneda() {
        var objeto : Ajax = new Ajax();

        objeto.Get("accion=9",Funciono,Error);
    }

    export function DatosDeProveedoresConLetraI() {
        var objeto : Ajax = new Ajax();

        objeto.Get("accion=10",Funciono,Error);
    }

    function Funciono(respuesta:string) {
        (<HTMLTableElement>document.getElementById("muestra")).innerHTML = respuesta;
    }

    function Error() {
        alert("A ocurrido un error.");
    }
}