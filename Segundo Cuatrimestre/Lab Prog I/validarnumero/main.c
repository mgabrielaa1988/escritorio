#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>
#include <string.h>

int lecturayValidacion(char numero[50]);

int main()
{
    float numero;

    printf("Ingrese: ");
    scanf("%f",&numero);

   if(isdigit(numero)==0){
        printf("Reingrese");
    }
    /*char numero[50];
    int auxiliar;
    printf("Ingrese: ");
    fflush(stdin);
    gets(numero);

    auxiliar=lecturayValidacion(numero);
    if(auxiliar==0){
        printf("Numero valido");
    }
    else{
        printf("numero invalido");
    }*/
    return 0;
}

/*int lecturayValidacion(char numero[50])
{
    int i, j, aux=0;

 j=strlen(numero);

    while(i<j&&aux==0){
        if(isdigit(numero[i])!=0){
            i++;
        }
        else{
            aux=1;
        }
    }
    return aux;
}*/
