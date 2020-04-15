
class Ajax {

    private xttps : XMLHttpRequest;
    private static DONE : number;
    private static OK : number;


    public constructor() {
        this.xttps = new XMLHttpRequest();
        Ajax.DONE = 200;
        Ajax.OK = 4;
    }

    /**
     * Get
     */
    public Get(params:string = "", exito :Function, error?: Function ) {
        var parametros : string = params.length > 0 ? "?"+params : "";
        var ruta = "administrar.php";
        ruta = parametros.length > 0 ? ruta += parametros : ruta;

        this.xttps.open("GET",ruta);

        this.xttps.send();

        this.xttps.onreadystatechange = () =>{
            if(this.xttps.status == Ajax.DONE && this.xttps.readyState == Ajax.OK){
                if(this.xttps.responseText != ""){
                    exito(this.xttps.responseText);
                }
                else{
                    if(error !== undefined){
                        error();
                    }
                }
            }
        }


    }
}