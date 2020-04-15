#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>

int main()
{
    char dia[11];

    printf("Ingrese un dia de la semana: ");
    fflush(stdin);
    scanf("%s",dia);

    for(int i=0; i<11; i++)
    {
        dia[i]=(char)tolower(dia[i]);
    }

    switch(dia)
    {
    case "lunes":
        printf("A trabajar");
        break;
    case "martes":
        printf("A trabajar");
        break;
    case "miercoles":
        printf("A trabajar");
        break;
    case "jueves":
        printf("A trabajar");
        break;
    case "viernes":
        printf("A trabajar");
        break;
    case "sabado":
        printf("Buen finde");
        break;
    case "domingo":
        printf("Buen finde");
        break;
    default:
        printf("Ingreso no valido");
    }
    return 0;
}
