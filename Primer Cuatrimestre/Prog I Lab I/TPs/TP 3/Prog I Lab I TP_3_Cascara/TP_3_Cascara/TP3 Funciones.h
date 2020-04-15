#ifndef TP3_FUNCIONES_H_INCLUDED
#define TP3_FUNCIONES_H_INCLUDED

typedef struct{
    char titulo[100];
    char genero[200];
    int duracion;
    char descripcion[1000];
    float puntaje;
    char linkImagen[500];
} EMovie;

int cargarArchivo(EMovie*,int);
void inicializarPeliculas(EMovie*,int);
char menu();
int buscarLibre(EMovie*,int);
int esAlfaNumerico(char*);
int validarTamStr(char*,int);
int getInt(char*);
int esNumerico(char*);
float getFloat(char*);
int esNumericoFlotante(char*);
void getString(char*,char*);
int newMovie(EMovie*,char*,char*,char*,char*,char*,char*);
void agregarPelicula(EMovie*,int);
void borrarPelicula(EMovie*,int);
void modificarPelicula(EMovie*,int);
char menuModificar();
char modificaTitulo(EMovie*);
char modificaGenero(EMovie*);
char modificaDuracion(EMovie*);
char modificaDescripcion(EMovie*);
char modificaPuntaje(EMovie*);
char modificaLink(EMovie*);
void generarPagina(EMovie*,int);
void listar(EMovie*,int);
char validarGuardar(char);
int guardarEnArchivo(EMovie*,int);
void toString(EMovie*);

#endif // FUNCIONES_H_INCLUDED

