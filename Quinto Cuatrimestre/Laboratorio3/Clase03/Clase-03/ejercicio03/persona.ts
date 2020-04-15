namespace Test {
    export abstract class Persona {
        private _apellido: string;
        private _dni: number;
        private _nombre: string;
        private _sexo: string;

        public constructor(nombre: string, apellido: string, dni: number, sexo: string) {
            this._nombre = nombre;
            this._apellido = apellido;
            this._dni = dni;
            this._sexo = sexo;
        }

        public get GetApellido(): string {
            return this._apellido;
        }
        public get GetDNI(): number {
            return this._dni;
        }
        public get GetNombre(): string {
            return this._nombre;
        }
        public get GetSexo(): string {
            return this._sexo;
        }

        public abstract Hablar(idioma: string): string;

        public ToString(): string {
            return (this._apellido + " - " + this._nombre + " - " + this._dni + " - " + this._sexo);
        }
    }
}