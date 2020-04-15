#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

typedef struct{
    int dni;
    char nombre[20];
    float altura;
} ePersona;

int newPersona(ePersona*, int, char[], float);
void personaToString(ePersona*);
void alta(ePersona*);
void mostrar(ePersona*);
void ordenar(ePersona*);

int main()
{
       ePersona listaPersonas[5];

       char opcion;
    printf("MENU DE OPCIONES\n");
    printf("1- Alta");
    printf("2- Mostrar");
    printf("3- Ordenar");
    fflush(stdin);
    opcion = getche();

    switch(opcion)
    {
    case '1':
        alta(&listaPersonas);
        break;
    case '2':
        mostrar(&listaPersonas);
        break;
    case '3':
ordenar(&listaPersonas->nombre);
        break;
    }
    return 0;
}

void alta(ePersona* listaPersonas)
{
   int i;
    int dni;
    char nombre[50];
    float altura;

    for(i=0; i<5; i++)
    {
        printf("Ingrese el dni: ");
        scanf("%d", &dni);
        printf("Ingrese nombre: ");
        fflush(stdin);
        gets(nombre);
        printf("Ingrese la altura: ");
        scanf("%f", &altura);

        if(newPersona(listaPersonas+i, dni, nombre, altura))
        {
            printf("Persona generada con exito!!!");
        }
        else
        {
            printf("Carga fallida");
        }

    }
}

int  newPersona(ePersona* miPersona, int dni, char nombre[], float altura)
{
    int retorno=0;
    if(miPersona!=NULL)
    {
        miPersona->dni = dni;
        strcpy(miPersona->nombre, nombre);
        miPersona->altura = altura;
        retorno = 1;
    }
    return retorno;
}

void mostrar(ePersona* listaPersonas)
{
    int i;
    printf("**************LISTA DE PERSONAS****************");
    for(i=0; i<5; i++)
    {
        personaToString(listaPersonas+i);
    }
}

void personaToString(ePersona* miPersona)
{
    printf("%d--%s--%.2f\n",  miPersona->dni,  miPersona->nombre,  miPersona->altura);
}

ordenar(ePersona listaPersonas->)
{
    char auxNombre[20];
    int i,j;

    for (i=0;i<5-1;i++)
    {
        for (j=i+1;j<5;j++)
        {
            if ()
        }
    }
}
