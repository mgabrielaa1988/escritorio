#include <stdio.h>
#include <stdlib.h>

int main()
{
    int base;
    int altura;
    int perimetro;
    float area;

    printf("Calculo de perimetro y area de un triangulo equilatero\n");
    printf("Ingrese la base: ");
    scanf("%d",&base);
    printf("Ingrese la altura: ");
    scanf("%d",&altura);

    perimetro=base*3;
    printf("\nPerimetro: %d",perimetro);

    area=(base*altura)/2.0;
    printf("\nArea: %.2f\n",area);

    return 0;
}
