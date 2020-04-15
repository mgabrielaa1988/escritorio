#include <stdio.h>
#include <stdlib.h>
#include <conio.h>


int main()
{
    char opcion;
    float numero [2];
    int i;
    float acumulador = 0;
    double resultado;

    printf("---------------------------------");
    printf("---BIENVENIDO/A LA CALCULADORA---\n");
    printf("---------------------------------");

    do
    {
        system("cls");

        printf("  1- Ingresar 1er numero (A=0)\n");
        printf("  2- Ingresar 2do numero (B=0)\n");
        printf("  3- Calcular la suma (A+B)\n");
        printf("  4- Calcular la resta (A-B)\n");
        printf("  5- Calcular la division (A/B)\n");
        printf("  6- Calcular la multiplicacion (A*B)\n");
        printf("  7- Calcular el factorial (A!)\n");
        printf("  8- Calcular todas las operaciones\n");
        printf("  9- Salir\n");
        opcion = getche();

        switch (opcion)
        {
            case '1':
                for (i=0;; )
                {
                    printf("  Ingrese el 1er numero: ");
                    scanf("%f", &numero[i]);
                }
                break;
            case '2':
                for (i=1; ; )
                {
                    printf("  Ingrese el 2do numero: ");
                    scanf("%f", &numero[i]);
                }
                break;
            case '3':
                for (i=0;i<2;i++)
                {
                    acumulador += numero[i];
                }
                break;
            case '4':
                for (i=0;i<2;i++)
                {
                    resultado = numero[0] - numero[1];
                }
                break;
            case '5':
                for (i=0;i<2;i++)
                {
                    if (numero[1]==0)
                    {
                        printf("  No se puede dividir entre cero!!!\n  Reingrese otro divisor");
                    }
                    resultado = numero[0] / numero[1];
                }
                break;
            case '6':
                for (i=0;i<2;i++)
                {
                    resultado = numero[0] * numero[1];
                }
                break;
            case '7':
                        long long int factorial (int a)
            {
                long long int total;
                if (a==0)
                {
                    return 1;
                }
                total = a * factorial(a - 1);
                return total;

                break;
            case '8':

                break;

        system("pause");

    }
    while (opcion !='9');



    return 0;
}
