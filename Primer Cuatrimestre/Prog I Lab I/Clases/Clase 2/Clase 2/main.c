#include <stdio.h>
#include <stdlib.h>

int main()
{
    int numero;
    int contador = 0;
    float promedio;
    int acumulador = 0;
    int maximo;
    int minimo;
    int flag = 1;

    while (contador<5)
    {
        printf("Ingrese un numero: ");
        scanf("%d", &numero);
        acumulador = acumulador + numero;
        contador++;

        if (flag == 1)
        {
            maximo = numero;
            minimo = numero;
            flag = 0;
        }
        else
        {
            if (numero > maximo)
            {
                maximo = numero;
            }
            if (numero < minimo)
            {
                minimo = numero;
            }
        }
    }

    promedio = (float) acumulador/5;

    printf("\nEl promedio de los numeros ingresados es: %.2f\n", promedio);
    printf("El numero maximo es: %d\n", maximo);
    printf("El numero minimo es: %d", minimo);
}
