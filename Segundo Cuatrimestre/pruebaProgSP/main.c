#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct{
    char nombre[20];
}ePersona;

void muestra(int *x,int *y);
void persona_setNombre(ePersona persona, char *nombre);

int main()
{
    /*char letra1 = 'X';
    char letra2 = 'Y';
    char *p = &letra1;
    letra1 = 'Z';
    letra2 = *p;
    printf("letra1: %c    letra2:%c",letra1,letra2);*/

    /*int vec[5]={1,2,3,4,5}, *p, i;
    p=vec;
    for(i=0;i<5;i++){
        printf("puntero 1: %d\n",*(p+i));
        printf("vector 1: %d\n",vec[i]);
        printf("puntero 2: %d\n",p+i);
        printf("vector 2: %d\n",&vec[i]);
    }*/

    /*int x,y;
    x = 17;
    y = 71;
    muestra(&x,&y);
    printf("\nFuncion main: x vale %d - y vale %d\n",x,y);*/

    ePersona nueva;
    char auxNombre[20];
    printf("Ingrese nombre: ");
    fflush(stdin);
    scanf("%s",auxNombre);
    persona_setNombre(nueva,auxNombre);
    printf("nombre: %s",*(nueva.nombre));


    return 0;
}

void persona_setNombre(ePersona persona, char *nombre){
   // int retorno =-1;

        strcpy(persona.nombre,nombre);
        //retorno =0;

    //return retorno;
}

void muestra(int *x,int *y){
    *x = *y;
    printf("\nFuncion muestra: x vale %d - y vale %d\n",*x,*y);
}
