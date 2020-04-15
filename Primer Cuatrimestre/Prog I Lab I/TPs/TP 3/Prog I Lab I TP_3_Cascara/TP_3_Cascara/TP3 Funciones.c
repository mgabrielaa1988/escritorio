#include<stdio.h>
#include<string.h>
#include<stdlib.h>
#include<ctype.h>
#include<conio.h>
#include "TP3 Funciones.h"

char validarGuardar(char respuesta)
{
    while(respuesta!= 's' && respuesta!= 'n')
    {
        printf("\nSolo son validos los caracteres S=SI / N=NO\n");
        printf("Reingrese:  ");
        fflush(stdin);
        scanf("%c",&respuesta);
        respuesta = tolower(respuesta);
    }
    return respuesta;
}

void inicializarPeliculas(EMovie* movie,int tam)
{
    int i;
    for (i=0; i<tam; i++)
    {
        strcpy((movie+i)->titulo,"");
        strcpy((movie+i)->genero,"");
        strcpy((movie+i)->descripcion,"");
        strcpy((movie+i)->linkImagen,"");
        (movie+i)->duracion = 0;
        (movie+i)->puntaje = -1;
    }
}

char menu()
{
    char opcion;
    printf("\n  ╔════════════════════╗\n");
    printf("  ║--------MENU--------║\n");
    printf("  ╚════════════════════╝\n");
    printf("  1- Agregar pelicula\n");
    printf("  2- Borrar pelicula\n");
    printf("  3- Modificar pelicula\n");
    printf("  4- Generar pagina web\n");
    printf("  5- Listar\n");
    printf("  6- Salir\n");
    printf("  Elija una opcion: ");
    fflush(stdin);
    scanf("%c",&opcion);

    while((int)c < 49 || (int)c > 54)
    {
        printf("\n\nReingrese una opcion valida: ");
        fflush(stdin);
        scanf("%c",&opcion);
    }
    return opcion;
}

/**
 * \brief Verifica si el valor recibido contiene solo letras y números
 * \param str Array con la cadena a ser analizada
 * \return 1 si contiene solo espacio o letras y números, y 0 si no lo es
 *
 */
int esAlfaNumerico(char* str)
{
    int i=0;
    while((str+i) != '\0')
    {
        if(((str+i) != ' ') && ((str+i) != '.') && ((str+i) != ',') && ((str+i) < 'a' || (str+i) > 'z') && ((str+i) < 'A' || (str+i) > 'Z') && ((str+i) < '0' || (str+i) > '9'))
            return 0;
        i++;
    }
    return 1;
}

/**
 * \brief Solicita un texto al usuario y lo devuelve
 * \param mensaje Es el mensaje a ser mostrado
 * \param input Array donde se cargará el texto ingresado
 * \return void
 */
void getString(char* mensaje,char* input)
{
    printf("%s\n", *mensaje);
    fflush(stdin);
    scanf ("%s", input);
}

int validarTamStr(char* texto,int tam)
{
    int retorno =0;
    if(strlen(*texto)<tam)
    {
        retorno = 1;
    }
    return retorno;
}

/**
 * \brief Solicita un número al usuario y devuelve el resultado
 * \param mensaje Es el mensaje a ser mostrado
 * \return El número ingresado por el usuario
 *
 */
int getInt(char* mensaje)
{
    int auxiliar;
    printf("%s",mensaje);
    scanf("%d",&auxiliar);
    return auxiliar;
}

/**
 * \brief Verifica si el valor recibido es numérico
 * \param str Array con la cadena a ser analizada
 * \return 1 si es númerico y 0 si no lo es
 *
 */

int esNumerico(char* str)
{
    int i=0;
    while((str+i) != '\0')
    {
        if((str+i) < '0' || (str+i) > '9')
            return 0;
        i++;
    }
    return 1;
}

/**
 * \brief Solicita un número al usuario y devuelve el resultado
 * \param mensaje Es el mensaje a ser mostrado
 * \return El número ingresado por el usuario
 *
 */
float getFloat(char* mensaje)
{
    float auxiliar;
    printf("%s",mensaje);
    scanf("%f",&auxiliar);
    return auxiliar;
}

/**
 * \brief Verifica si el valor recibido es numérico aceptando flotantes
 * \param str Array con la cadena a ser analizada
 * \return 1 si es númerico y 0 si no lo es
 *
 */

int esNumericoFlotante(char* str)
{
    int i=0;
    int cantidadPuntos=0;
    while((str+i) != '\0')
    {
        if ((str+i) == '.' && cantidadPuntos == 0)
        {
            cantidadPuntos++;
            i++;
            continue;

        }
        if((str+i) < '0' || (str+i) > '9')
            return 0;
        i++;
    }
    return 1;
}

void agregarPelicula(EMovie* movie,int tam)
{
    char titulo[500];
    char genero[1000];
    char duracion[10];
    char descripcion[1500];
    char puntaje[10];
    char linkImagen[1000];
    int index;

    index = buscarLibre(movie,tam);
    if (index != -1)
    {
        printf("  Ingrese los datos de la nueva pelicula\n");
        getString("Titulo: ",titulo);
        getString("Genero: ",genero);
        getString("Duracion: ",duracion);
        getString("Descripcion: ",descripcion);
        getString("Puntaje: ",puntaje);
        getString("Link a imagen: ",linkImagen);
    }

    if(newMovie(movie,titulo,genero,duracion,descripcion,puntaje,linkImagen))
    {
        printf("\n  Pelicula agregada!\n");
    }
    else
    {
        printf("\n  ERROR... carga de datos fallida\n");
    }
}

int buscarLibre (EMovie* movie,int tam)
{
    int index = -1;
    int i;

    for (i=0; i<tam; i++)
    {
        if ((movie+i)->puntaje == -1)
        {
            index = i;
            break;
        }
    }
    return index;
}

int newMovie(EMovie* movie,char* titulo,char* genero,char* duracion,char* descripcion,char* puntaje,char* link)
{
    int retorno = 0;
    int tamCorrecto = 0;
    int auxDuracion;
    float auxPuntaje;

    if(esAlfaNumerico(titulo))
    {
        if(validarTamStr(titulo,100))
        {
            tamCorrecto = tamCorrecto + 1;
        }
        else
        {
            printf("\nTitulo: La cantidad de caracteres excede el espacio disponible");
        }
    }
    else
    {
        printf("\nTitulo: Ingreso caracteres no validos");
    }


    if(esAlfaNumerico(genero))
    {
        if(validarTamStr(genero,200))
        {
            tamCorrecto = tamCorrecto + 1;
        }
        else
        {
            printf("\nGenero: La cantidad de caracteres excede el espacio disponible");
        }
    }
    else
    {
        printf("\nGenero: Ingreso caracteres no validos");
    }

    if(esNumerico(duracion))
    {
        auxDuracion = atoi(duracion);
        if(auxDuracion>0 && auxDuracion<=300)
        {
            tamCorrecto = tamCorrecto + 1;
        }
        else
        {
            printf("\nDuracion: El tiempo de duracion no es real");
        }
    }
    else
    {
        printf("\nDuracion: Ingreso caracteres no validos");
    }


    if(esAlfaNumerico(descripcion))
    {
        if(validarTamStr(descripcion))
        {
            tamCorrecto = tamCorrecto + 1;
        }
        else
        {
            printf("\nDescripcion: La cantidad de caracteres excede el espacio disponible");
        }
    }
    else
    {
        printf("\nDescripcion: Ingreso caracteres no validos");
    }

    if(esNumericoFlotante(puntaje))
    {
        auxPuntaje = atof(puntaje);
        if(auxPuntaje>0 && auxPuntaje<=10)
        {
            tamCorrecto = tamCorrecto + 1;
        }
        else
        {
            printf("\nEl puntaje no es real");
        }
    }
    else
    {
        printf("\nPuntaje: Ingreso caracteres no validos");
    }

    if(validarTamStr(link,500))
    {
        tamCorrecto = tamCorrecto + 1;
    }
    else
    {
        printf("\nLink: La cantidad de caracteres excede el espacio disponible");
    }

    if(movie!=NULL && tamCorrecto==6)
    {
        strcpy(movie->titulo,titulo);
        strcpy(movie->genero,genero);
        movie->duracion = auxDuracion;
        strcpy(movie->descripcion,descripcion);
        movie->puntaje = auxPuntaje;
        strcpy(movie->linkImagen,link);
        retorno = 1;
    }
    return retorno;
}

void toString(EMovie* movie)
{
    printf("\n%s\n%s\n%d\n%s\n%d\n%s\n",movie->titulo,movie->genero,movie->duracion,movie->descripcion,movie->puntaje,movie->linkImagen);
}

void borrarPelicula(EMovie* movie,int tam)
{
    char auxTitulo[500];
    char opcion;
    int i;
    int flag =0;
    printf("  Ingrese el titulo de la pelicula que desea eliminar: \n");
    fflush(stdin);
    scanf("%s",auxTitulo);

    for (i=0; i<tam; i++)
    {
        if(stricmp((movie+i)->titulo,auxTitulo)==0)
        {
            printf("  Pelicula a eliminar: \n");
            toString((movie + i));
            printf("  Confirma eliminar pelicula (s para si): \n");
            fflush(stdin);
            scanf("%c",&opcion);

            if (opcion == 's')
            {
                (movie+i)->puntaje = -1;
                printf("  Pelicula borrada!\n");
            }
            else
            {
                printf("  La pelicula no fue eliminada\n");
            }
            flag = 1;
            break;
        }
    }
    if (flag == 0)
    {
        printf("  Pelicula inexistente\n");
    }
}

char menuModificar()
{
    char opcion;
    system("cls");
    printf("\n  ╔════════════════════════╗\n");
    printf("  ║-MENU DE MODIFICACIONES-║\n");
    printf("  ╚════════════════════════╝\n");
    printf("  Que desea modificar?\n");
    printf("  A- Titulo\n");
    printf("  B- Genero\n");
    printf("  C- Duracion\n");
    printf("  D- Descripcion\n");
    printf("  E- Puntaje\n");
    printf("  F- Link a Imagen\n");
    printf("  G- Salir\n");
    printf("  Elija una opcion: ");
    fflush(stdin);
    scanf("%c",&opcion);
    opcion = tolower(opcion);

    while((int)c < 97 || (int)c > 103)
    {
        printf("\n\nReingrese una opcion valida: ");
        fflush(stdin);
        scanf("%c",&opcion);
    }
    return opcion;
}

void modificarPelicula(EMovie* movie, int tam)
{
    char auxTitulo[500];
    char seguir = 's';
    int i;
    int flag = 0;
    EMovie* auxMovie;
    char titulo[100];
    char genero[200];
    int duracion;
    char descripcion[1000];
    float puntaje;
    char linkImagen[500];

    printf("  Ingrese el titulo de la pelicula que desea modificar: \n");
    fflush(stdin);
    scanf("%s",auxTitulo);

    for (i=0; i<tam; i++)
    {
        if((stricmp((movie+i)->titulo,auxTitulo)==0) && (movie+i)->puntaje !=-1)
        {
            printf("  Pelicula encontrada:\n");
            toString((movie + i));
            auxMovie = (movie + i);
            system("pause");
            flag = 1;
            break;
        }
    }
    if (flag == 0)
    {
        printf("  Pelicula inexistente");
    }

    do
    {
        switch(menuModificar())
        {
        case 'a':
            modificaTitulo(auxMovie);
            system("pause");
            break;
        case 'b':
            system("pause");
            break;
        case 'c':
            system("pause");
            break;
        case 'd':
            system("pause");
            break;
        case 'e':
            system("pause");
            break;
        case 'f':
            system("pause");
            break;
        case 'g':
            seguir = 'n';
        }
    }
    while(seguir != 'n' && flag ==1)
    }

void modificaTitulo(EMovie* movie)
{
    char auxTitulo[500];
    getString("\nIngrese el nuevo TITULO: ",auxTitulo);
    char confirma;
    while(!esAlfaNumerico(auxTitulo))
    {
        printf("\nIngreso caracteres no validos");
        getString("\nReingrese: ",auxTitulo);
    }
    while(!validarTamStr(auxTitulo,100))
    {
        printf("\nLa cantidad de caracteres del titulo excede el espacio disponible");
        getString("\nReingrese: ",auxTitulo);
    }
    printf("\nORIGINAL: %s",movie->titulo);
    printf("\nMODIFICACION: %s",auxTitulo);
    printf("\nCambiar? S=SI OTRA TECLA=cancelar accion\n");
    fflush(stdin);
    scanf("%c",&confirma);
    if(confirma == 's')
    {
        strcpy(movie->titulo,auxTitulo);
    }
    else
    {
        printf("\nAccion cancelada");
    }
}

void modificaGenero(EMovie* movie)
{
    char auxGenero[1000];
    getString("\nIngrese el nuevo GENERO: ",auxGenero);
    char confirma;
    while(!esAlfaNumerico(auxGenero))
    {
        printf("\nIngreso caracteres no validos");
        getString("\nReingrese: ",auxGenero);
    }
    while(!validarTamStr(auxGenero,200))
    {
        printf("\nLa cantidad de caracteres del genero excede el espacio disponible");
        getString("\nReingrese: ",auxGenero);
    }
    printf("\nORIGINAL: %s",movie->genero);
    printf("\nMODIFICACION: %s",auxGenero);
    printf("\nCambiar? S=SI OTRA TECLA=cancelar accion\n");
    fflush(stdin);
    scanf("%c",&confirma);
    if(confirma == 's')
    {
        strcpy(movie->genero,auxGenero);
    }
    else
    {
        printf("\nAccion cancelada");
    }
}
void modificaDuracion(EMovie* movie)
{
    char auxDuracion[10];
    getString("\nIngrese la nueva DURACION: ",auxDuracion);
    char confirma;
    while(!esNumerico(auxDuracion))
    {
        printf("\nIngreso caracteres no validos");
        getString("\nReingrese: ",auxDuracion);
    }
    while(!validarTamStr(auxDuracion,3))
    {
        printf("\nLa cantidad de caracteres de la duracion excede el espacio disponible");
        getString("\nReingrese: ",auxDuracion);
    }
    printf("\nORIGINAL: %s",movie->duracion);
    printf("\nMODIFICACION: %s",auxDuracion);
    printf("\nCambiar? S=SI OTRA TECLA=cancelar accion\n");
    fflush(stdin);
    scanf("%c",&confirma);
    if(confirma == 's')
    {
        strcpy(movie->duracion,auxDuracion);
    }
    else
    {
        printf("\nAccion cancelada");
    }
}
void modificaDescripcion(EMovie* movie)
{
    char auxDescripcion[1500];
    getString("\nIngrese la nueva DESCRIPCION: ",auxDescripcion);
    char confirma;
    while(!esAlfaNumerico(auxDescripcion))
    {
        printf("\nIngreso caracteres no validos");
        getString("\nReingrese: ",auxDescripcion);
    }
    while(!validarTamStr(auxDescripcion,1000))
    {
        printf("\nLa cantidad de caracteres de la descripcion excede el espacio disponible");
        getString("\nReingrese: ",auxDescripcion);
    }
    printf("\nORIGINAL: %s",movie->descripcion);
    printf("\nMODIFICACION: %s",auxDescripcion);
    printf("\nCambiar? S=SI OTRA TECLA=cancelar accion\n");
    fflush(stdin);
    scanf("%c",&confirma);
    if(confirma == 's')
    {
        strcpy(movie->descripcion,auxDescripcion);
    }
    else
    {
        printf("\nAccion cancelada");
    }
}
void modificaPuntaje(EMovie* movie)
{
    char auxPuntaje[10];
    getString("\nIngrese el nuevo PUNTAJE: ",auxPuntaje);
    char confirma;
    while(esNumericoFlotante(auxPuntaje))
    {
        printf("\nIngreso caracteres no validos");
        getString("\nReingrese: ",auxPuntaje);
    }
    while(!validarTamStr(auxPuntaje,6))
    {
        printf("\nLa cantidad de caracteres de la duracion excede el espacio disponible");
        getString("\nReingrese: ",auxPuntaje);
    }
    printf("\nORIGINAL: %s",movie->puntaje);
    printf("\nMODIFICACION: %s",auxPuntaje);
    printf("\nCambiar? S=SI OTRA TECLA=cancelar accion\n");
    fflush(stdin);
    scanf("%c",&confirma);
    if(confirma == 's')
    {
        strcpy(movie->puntaje,auxPuntaje);
    }
    else
    {
        printf("\nAccion cancelada");
    }
}
void modificaLink(EMovie* movie)
{
    char auxLink[1000];
    getString("\nIngrese el nuevo LINK A IMAGEN: ",auxLink);
    char confirma;
    while(!validarTamStr(auxLink,200))
    {
        printf("\nLa cantidad de caracteres del link excede el espacio disponible");
        getString("\nReingrese: ",auxLink);
    }
    printf("\nORIGINAL: %s",movie->linkImagen);
    printf("\nMODIFICACION: %s",auxLink);
    printf("\nCambiar? S=SI OTRA TECLA=cancelar accion\n");
    fflush(stdin);
    scanf("%c",&confirma);
    if(confirma == 's')
    {
        strcpy(movie->linkImagen,auxLink);
    }
    else
    {
        printf("\nAccion cancelada");
    }
}

void generarPagina(EMovie* movie, int tam)
{
    int i;
    FILE* pFile;
    pFile=fopen("index.html","w");
    if(pFile==NULL)
    {
        printf("\nError al abrir el archivo\n");
    }
    else
    {
        fprintf(htmlMovies,"<!DOCTYPE html>\n<html lang='en'>\n<head>\n<meta charset='utf-8'>\n<meta http-equiv='X-UA-Compatible' content='IE=edge'>\n<meta name='viewport' content='width=device-width, initial-scale=1'>\n<title>Lista peliculas</title>\n<link href='css/bootstrap.min.css' rel='stylesheet'>\n<link href='css/custom.css' rel='stylesheet'>\n</head>\n");
        fprintf(htmlMovies,"<body>\n<div class='container'>\n<div class='row'>\n");
        for(i=0; i<tam; i++)
        {
            if((movie+i)->puntaje!=-1)
            {
                fprintf(pFile,"<article class='col-md-4 article-intro'> <a href='#'><img class='img-responsive img-rounded' src='%s' alt=''>",(movie+i)->linkImagen);
                fprintf(pFile,"</a><h3><a href='#'> %s</a></h3><ul>",(movie+i)->titulo);
                fprintf(pFile,"<li>Genero: %s</li><li>Duracion: %d minutos.</li><li>Descripcion: %s</li><li>Puntaje: %d</li></ul>",(movie+i)->genero,(movie+i)->duracion,(movie+i)->descripcion,(movie+i)->puntaje);
            }
        }
    }
    fclose(pFile);
    printf("\nPagina creada!");
}

int guardarEnArchivo(EMovie* cambios,int tam)
{
    FILE* archivo;

    archivo=fopen("bin.dat","wb");
    if(archivo == NULL)
    {
        printf("  Error al abrir el archivo");
        return 1;
    }

    fwrite(cambios,sizeof(EMovie),tam,archivo);
    printf("  Archivo guardado");
    fclose(archivo);

    return 0;
}

int cargarArchivo(EMovie* movie,int tam)
{
    int flag =0;
    FILE* archivo;
    archivo=fopen("bin.dat","rb");
    if(archivo==NULL)
    {
        archivo=fopen("bin.dat","wb");
        if(archivo==NULL)
        {
            return 1;
        }
        flag =1;
    }
    if(flag == 0)
    {
        fread(movie,sizeof(EMovie),tam,archivo);
    }
    fclose(archivo);
    return 0;
}

void listar(EMovie* movie,int tam)
{
    int i;

    if(movie!=NULL && tam>0)
    {
        for(i=0; i<tam; i++)
        {
            if(movie[i].puntaje!=0)
            {
                printf("\n\tTitulo: %s\n\tGenero: %s\n\tDuracion: %d\n\tPuntaje: %d\n\tDescripcion: %s\n\tLink de Imagen: %s\n",movie[i].titulo,movie[i].genero,movie[i].duracion,movie[i].puntaje,movie[i].descripcion,movie[i].linkImagen);
            }
        }
    }
}
