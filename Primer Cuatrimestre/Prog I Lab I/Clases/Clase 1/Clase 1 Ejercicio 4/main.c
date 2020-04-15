#include <stdio.h>
#include <stdlib.h>

int main()
{
    int numero;
    int contador;
    contador=0;
    int contadorPositivos;
    contadorPositivos=0;
    int contadorNegativos;
    contadorNegativos=0;

    while (contador<10)
    {
        printf(" Ingrese un numero: %d\n", numero);
        scanf("%d",&numero);
        contador++;

        if (numero%2==0)
        {
            contadorPositivos++;
        }
        if (numero%2==1)
        {
            contadorNegativos++;
        }
    }

    printf(" La cantidad de numeros positivos es: %d\n", contadorPositivos);
    printf(" La cantidad de numeros negativos es: %d\n", contadorNegativos);
}
