#include <stdio.h>
#include <stdlib.h>

int main()
{
    char nombre [21];
    char localidad [21];

    printf("Ingrese nombre: ");
    fflush(stdin);
    scanf("%s",&nombre);
    printf("Ingrese localidad: ");
    fflush(stdin);
    scanf("%s",&localidad);

    printf("\nUsted es %s y vive en la localidad de %s\n",nombre,localidad);
    return 0;
}
