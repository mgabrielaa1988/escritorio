#include <stdio.h>
#include <stdlib.h>

int main()
{
    int numeroUno;
    int numeroDos;
    float division;
    int suma;

    printf("Ingrese el primer numero: ");
    scanf("%d",&numeroUno);
    printf("Ingrese el segundo numero: ");
    scanf("%d",&numeroDos);

    if(numeroUno==numeroDos){
        printf("Son iguales: %d%d",numeroUno,numeroDos);
    }

    if(numeroUno>numeroDos){
        division=(float)numeroUno/numeroDos;
        printf("El primer numero es mas grande: %.2f",division);
    }

    if(numeroDos>numeroUno){
        suma=numeroUno+numeroDos;
        printf("El segundo numero es mas grande");
        if(suma<50){
            printf("\nLa suma es %d y es menor a 50",suma);
        }
    }

    return 0;
}
