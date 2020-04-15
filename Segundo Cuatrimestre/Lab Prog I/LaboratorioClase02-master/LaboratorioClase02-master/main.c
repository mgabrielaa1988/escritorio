#include <stdio.h>
#include <stdlib.h>

int main()
{
    char nombre[41];
    char localidad[41];

    printf("Ingrese nombre: ");
    fflush(stdin);
    scanf("%s", nombre);
    printf("\nIngrese localidad: ");
    fflush(stdin);
    scanf("%s", localidad);

    printf("\nUsted se llama %s y vive en %s.", nombre, localidad);

    return 0;
}
