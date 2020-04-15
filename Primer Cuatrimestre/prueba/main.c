#include <stdio.h>
#include <stdlib.h>
#include <time.h>

typedef struct{
int codigo;
char marca[20];
char modelo[20];
int capacidad;
}ePendrive;

ePendrive* new_pendrive();
ePendrive* new_pendrive_param(int codigo,char* marca, char* modelo, int capacidad);

int main()
{
    ePendrive* new_pendrive();

    int num;
    int* puntero;
    puntero = &num;
    *puntero = 5;
    printf("%d", num);

    time_t tiempo = time(0);
    struct tm *tlocal = localtime(&tiempo);
    char output[128];
    strftime(output,128,"%d/%m/%y",tlocal);
    printf("\nFecha: %s",output);

    return 0;
}

ePendrive* new_pendrive()
{
    ePendrive* returnAux = NULL;
    returnAux = (ePendrive*) malloc(sizeof(ePendrive));
    return returnAux;
}


