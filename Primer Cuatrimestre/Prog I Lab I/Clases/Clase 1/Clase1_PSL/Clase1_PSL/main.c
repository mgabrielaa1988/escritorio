#include <stdio.h>
#include <stdlib.h>


int main(int argc, char *argv[]) {

	int numero1;
	int numero2;
	int resultado;

	printf(" Ingrese un numero %d\n", numero1);
	scanf("%d", &numero1);
	printf(" Usted ingreso %d\n", numero1);

	while (numero1==0)
    {
        printf(" Ingrese un numero diferente a 0 %d", numero1);
        scanf("%d", &numero1);
        printf(" Usted ingreso %d\n", numero1);
    }

    printf(" Ingrese otro numero %d\n", numero2);
	scanf("%d", &numero2);
	printf(" Usted ingreso %d\n", numero2);

	while (numero2==0)
    {
        printf(" Ingrese un numero diferente a 0 %d", numero2);
        scanf("%d", &numero2);
        printf(" Usted ingreso %d\n", numero2);
    }

    resultado=numero1-numero2;
    printf(" El resultado de la resta es: %d\n", resultado);

    if (resultado>0)
    {
        printf(" Resultado Positivo");
    }
    else if (resultado<0)
    {
        printf(" Resultado Negativo");
    }
	return 0;
}
