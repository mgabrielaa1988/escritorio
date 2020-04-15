#include <stdio.h>
#include <stdlib.h>

int main()
{
    int nota;
    printf("Ingrese la nota: ");
    scanf("%d",&nota);

    while(nota<0||nota>10)
    {
        printf("Nota invalida. Reingrese: ");
        scanf("%d",&nota);
    }

    switch(nota)
    {
    case 0:
        printf("La proxima se puede...");
        break;
    case 1:
        printf("La proxima se puede...");
        break;
    case 2:
        printf("La proxima se puede...");
        break;
    case 3:
        printf("La proxima se puede...");
        break;
    case 4:
        printf("Raspando...");
        printf("\nDebes preocuparte mas");
        break;
    case 5:
        printf("Raspando...");
        break;
    case 6:
        printf("Raspando...");
        break;
    case 7:
        printf("Aprobo");
        break;
    case 8:
        printf("Aprobo");
        break;
    case 9:
        printf("Aprobo");
        printf("\nMuy bien");
        break;
    case 10:
        printf("Aprobo");
        printf("\nMuy bien");
        break;
    }
    return 0;
}
