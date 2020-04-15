namespace Empleados
{
    export abstract class Persona
    {
        private _apellido:string;
        private _nombre:string;
        private _dni:number;
        private _sexo:string;

        public constructor(nombre:string,apellido:string,dni:number,sexo:string) {
            this._nombre=nombre;
            this._apellido=apellido;
            this._dni=dni;
            this._sexo=sexo;
        }

        public GetApellido():string {
            return this._apellido;
        } 

        public GetDNI():number {
            return this._dni;
        } 

        public GetNombre():string {
            return this._nombre;
        } 

        public GetSexo():string {
            return this._sexo;
        } 

        public abstract HablarIdioma(idioma:string):string;

        public ToString():string{
            return "Nombre: "+this._apellido+" - "+this._nombre+" - DNI: "+this._dni+" - Sexo: "+this._sexo+"\n";
        }
    }
}
