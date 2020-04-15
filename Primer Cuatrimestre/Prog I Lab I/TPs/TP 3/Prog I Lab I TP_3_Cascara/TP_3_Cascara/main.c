#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>
#include <string.h>
#include <conio.h>
#include "TP3 Funciones.h"
#define TAM 15


int main()
{
    EMovie movie[TAM];
    char seguir='s';
    char guardar;
    if (cargarArchivo(movie,TAM)){
        printf("\nNo se pudo abrir el fichero\n\n");
        system("pause");
        system("cls");
    }
    else{
        printf("\nDatos cargados correctamente\n\n");
        system("pause");
        system("cls");
    }
    inicializarPeliculas(movie,TAM);

    do
    {
        switch(menu())
        {
        case '1':
            agregarPelicula(movie,TAM);
            system("pause");
            break;
        case '2':
            borrarPelicula(movie,TAM);
            system("pause");
            break;
        case '3':
            modificarPelicula(movie,TAM);
            system("pause");
            break;
        case '4':
            generarPagina(movie,TAM);
            system("pause");
            break;
        case '5':
            listar(movie,TAM);
            system("pause");
            break;
        case '6':
            printf("\nGuardar cambios S/N ?: ");
            fflush(stdin);
            guardar = tolower(getche());
            guardar = validarGuardar(guardar);

            if(guardar == 's')
            {
                if(guardarEnArchivo(movie,TAM))
                {
                    printf("\nNo se pudo guardar el archivo\n");
                }
                else
                {
                    printf("\nSe guardo la informacion con exito\n");
                }
            }
            seguir = 'n';
            break;
        }
    }
    while (seguir != 'n');
    printf("\n");
    return 0;
}
