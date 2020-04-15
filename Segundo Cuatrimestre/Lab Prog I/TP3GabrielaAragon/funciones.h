#ifndef FUNCIONES_H_INCLUDED
#define FUNCIONES_H_INCLUDED

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
void toString(EMovie*);
void listar(EMovie*,int);
char menu();
int newMovie(EMovie*,char*,char*,char*,char*,char*,char*);
void agregarPelicula(EMovie*,int);
void borrarPelicula(EMovie*,int);
void modificarPelicula(EMovie*,int);
char menuModificar();
void modificaTitulo(EMovie*);
void modificaGenero(EMovie*);
void modificaDuracion(EMovie*);
void modificaDescripcion(EMovie*);
void modificaPuntaje(EMovie*);
void modificaLink(EMovie*);
void generarPagina(EMovie*,int);
int guardarEnArchivo(EMovie*,int);


#endif // FUNCIONES_H_INCLUDED

