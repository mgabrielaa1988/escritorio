#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#define TAMC 5
#define TAMA 6
#define AMOLADORA 101
#define MEZCLADORA 102
#define TALADRO 103
#define VENDEDOR1MATIAS 3001
#define VENDEDOR2HECTOR 3002
#define ALQUILADO -1
#define FINALIZADO 0

typedef struct{
int idCliente;
int dni;
char nombre [30];
char apellido [30];
}eCliente;

typedef struct{
int idAlquiler;
int idCliente;
int equipo;
int tiempoEstimado;
int operador;
int estado;
}eAlquiler;

void inicializarCliente (eCliente lista[],int tam);
void altaCliente (eCliente lista[],int tam);
void modificarCliente (eCliente lista[],int tam);
void bajaClientes (eCliente lista[], int tam);
void inicializarAlquiler (eAlquiler lista[],int tam);
void nuevoAlquiler (eAlquiler lista[],int tam);
void finalizarAlquiler (eAlquiler listaA[],int tamA,eCliente listaC[],int tamC);

int main()
{
    eCliente listaClientes[TAMC];
    eAlquiler listaAlquileres[TAMA];

    char opcionMenu;

    printf("1- Alta de cliente");
    printf("2- Modificaciones");
    printf("3- Baja de cliente");
    printf("4- Nuevo alquiler");
    printf("5- Fin de alquier");
    printf("6- Informe");
    opcionMenu = getche();

    switch (opcionMenu)
    {
    case '1':
        inicializarCliente(listaClientes, TAMC);
        altaCliente(listaClientes, TAMC);
        break;
    case '2':
        modificarCliente(listaClientes, TAMC);
        break;
    case '3':
        bajaClientes(listaClientes, TAMC);
        break;
    case '4':
        inicializarAlquiler(listaAlquileres, TAMA);
        nuevoAlquiler(listaAlquileres, TAMA);
        break;
        case '5':
            break;
    }

    return 0;
}

void inicializarCliente (eCliente lista[],int tam)
{
    int i;
    int id[]={1,2,3,4,5};
    int dni[]={11111111,22222222,33333333,44444444,-1};
    char nombre[][30]={"Juan","Maria","Susana","Dario"};
    char apellido[][30]={"Perez","Gonzalez","Aguirre","Lopez"};

    for (i=0;i<tam;i++)
    {
        lista[i].idCliente = id[i];
        lista[i].dni = dni[i];
        strcpy(lista[i].nombre,nombre[i]);
        strcpy(lista[i].apellido,apellido[i]);
    }
}

void altaCliente (eCliente lista[],int tam)
{
    int i;

    for (i=0;i<tam;i++)
    {
        if (lista[i].dni == -1)
        {
            printf("Ingrese nombre: ");
            fflush(stdin);
            gets(lista[i].nombre);
            printf("Ingrese apellido: ");
            fflush(stdin);
            gets(lista[i].apellido);
            printf("Ingrese DNI: ");
            scanf("%d", lista[i].dni);
            break;
        }
    }
}

void modificarCliente (eCliente lista[],int tam)
{
    int i;
    int auxDni;

    printf("Ingrese el DNI del cliente que desea modificar: ");
    scanf("%d", auxDni);

    for (i=0;i<tam;i++)
    {
        if (lista[i].dni == auxDni)
        {
            printf("Cliente encontrado: ");
            printf(lista[i].idCliente);
            printf(lista[i].apellido, lista[i].nombre);

            printf("Ingrese los nuevos datos: ");
            printf("Ingrese nombre: ");
            fflush(stdin);
            gets(lista[i].nombre);
            printf("Ingrese apellido: ");
            fflush(stdin);
            gets(lista[i].apellido);
            printf("Ingrese DNI: ");
            scanf("%d", lista[i].dni);
            break;
        }
        else
        {
            printf("Cliente no encontrado");
            break;
        }
    }
}

void bajaClientes (eCliente lista[], int tam)
{
    int i;
    int auxDni;

    printf("Ingrese el DNI del cliente a dar de baja: ");
    scanf("%d", auxDni);

    for (i=0;i<tam;i++)
    {
        if (lista[i].dni == auxDni)
        {
            printf("Cliente encontrado:");
            printf(lista[i].idCliente);
            printf(lista[i].apellido, lista[i].nombre);
            lista[i].dni = -1;
        }
        else
        {
            printf("Cliente no encontrado");
        }
    }
}

void inicializarAlquiler (eAlquiler lista[],int tam)
{
    int i;
    int idAlquiler ={101,102,103,104,105};
    int idCliente ={3,2,4,1,5};
    int equipo ={AMOLADORA,TALADRO,AMOLADORA,MEZCLADORA,TALADRO};
    int tiempoEstimado ={24,48,72,24,48};
    int operador ={VENDEDOR1MATIAS,VENDEDOR1MATIAS,VENDEDOR2HECTOR,VENDEDOR1MATIAS,VENDEDOR2HECTOR};
    int estado ={ALQUILADO,ALQUILADO,ALQUILADO,ALQUILADO,ALQUILADO};

    for (i=0;i<tam;i++)
    {
        lista[i].idAlquiler = idAlquiler;
        lista[i].idCliente = idCliente;
        lista[i].equipo = equipo;
        lista[i].tiempoEstimado = tiempoEstimado;
        lista[i].operador = operador;
        lista[i].estado = estado;
    }
}

void nuevoAlquiler (eAlquiler lista[],int tam)
{
    int i;

    for (i=0;i<tam;i++)
    {
        if (lista[i].estado != ALQUILADO && lista[i].estado != FINALIZADO)
        {
            printf("Ingrese el ID del cliente: ");
            scanf("%d",lista[i].idCliente);
            printf("Ingrese el codigo del equipo: ");
            scanf("%d",lista[i].equipo);
            printf("Ingrese el tiempo estimado: ");
            scanf("%d",lista[i].tiempoEstimado);
            printf("Ingrese el codigo del operador: ");
            scanf("%d",lista[i].operador);
        }
        else
        {
            printf("No se pueden efectuar mas alquileres");
        }
    }
}
void finalizarAlquiler (eAlquiler listaA[],int tamA,eCliente listaC[],int tamC)
{
    int i;
    int j;
    int auxIdCliente;
    printf("Ingrese el ID del cliente: ");
    scanf("%d",auxIdCliente);
    int auxIdAlquiler;

    for (i=0;i<tamC;i++)
    {
     if (listaC[i].idCliente == auxIdCliente)
     {
         printf("Cliente encontrado");

     for (j=0;j<tamA;j++)
     {
         printf(listaA[j].idCliente,listaA[j].equipo,listaA[j].tiempoEstimado,listaA[j].operador);
         printf("Ingrese el id del alquiler a dar de baja: ");
         scanf("%d",auxIdAlquiler);
         if (listaA[j].idAlquiler == auxIdAlquiler)
         {
             listaA[j].estado == FINALIZADO;
             printf("Alquiler finalizado");
         }
     }

     }
    }
}
