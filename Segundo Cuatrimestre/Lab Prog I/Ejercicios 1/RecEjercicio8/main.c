#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main()
{
    char seguir;
    char nombre[21];
    int paginas;
    int ventas;
    char tema[21];
    int librosConPagPares=0;
    int librosConPagImpares=0;
    int ceroVentas=0;
    int acumVentas=0;
    float promedioVentas;
    int pagProgram=0;
    int i=0;

    do{
    printf("Ingrese nombre del libro: ");
    fflush(stdin);
    scanf("%s",&nombre);

    printf("Ingrese cantidad de paginas: ");
    scanf("%d",&paginas);

    printf("Numero de ventas: ");
    scanf("%d",&ventas);

    printf("Tema: <robotica> <programacion> <patrones> <base de datos>");
    fflush(stdin);
    scanf("%s",&tema);

    acumVentas=acumVentas+ventas;
    i++;

    if(paginas%2==0){
        librosConPagPares++;
    }
    else{
        librosConPagImpares++;
    }

    if(ventas==0){
        ceroVentas++;
    }

    if(strcmp(tema,"programacion")){
        pagProgram=pagProgram+paginas;
    }

    printf("Desea cargar otro libro? <s=si>");
    }while(seguir=='s');

    promedioVentas=acumVentas/i;

    return 0;
}
