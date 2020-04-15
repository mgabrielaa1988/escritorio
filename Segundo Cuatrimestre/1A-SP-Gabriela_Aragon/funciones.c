#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>
#include <string.h>
#include <conio.h>

#include "arraylist.h"
#include "validaciones.h"
#include "funciones.h"


eEmpleado* new_Empleado()
{
    eEmpleado* retorno = NULL;

    retorno=(eEmpleado*)malloc(sizeof(eEmpleado));
    if(retorno!=NULL)
    {
        strcpy(retorno->nombre,"");
        retorno->id=0;
        retorno->horasTrab=0;
        retorno->sueldo=0;
    }
    return retorno;
}

eEmpleado* empleado_New_Parameters(int id, char* nombre,int hsTrab)
{
    eEmpleado* retorno = NULL;

    retorno = new_Empleado();
    if(retorno!=NULL)
    {
        strcpy(retorno->nombre,nombre);
        retorno->id=id;
        retorno->horasTrab=hsTrab;
    }
    return retorno;
}

int mostrar_Empleado(eEmpleado* auxEmpleado)
{
    int retorno=-1;

    if(auxEmpleado!=NULL)
    {
        printf("ID:%d\tNombre:%s\tHoras:%d\n",auxEmpleado->id,auxEmpleado->nombre,auxEmpleado->horasTrab);
        retorno=0;
    }
    return retorno;
}

int parser_parseEmpleados(char* fileName, ArrayList* listaEmpleados)
{
    char id[5],nombre[50],hsTrb[5];
    int auxId,auxHsT;
    int retorno=-1;
    eEmpleado* auxEmpleado;

    FILE* f = fopen (fileName,"r");

    if(f!=NULL)
    {
        retorno =0;
    }
    while(!feof(f))
    {
        fscanf(f, "%[^,],%[^,],%[^\n]\n",id,nombre,hsTrb);
        auxId=atoi(id);
        auxHsT=atoi(hsTrb);

        auxEmpleado = empleado_New_Parameters(auxId,nombre,auxHsT);
        mostrar_Empleado(auxEmpleado);

        if(listaEmpleados->add(listaEmpleados,auxEmpleado)==0);
        {
            retorno=1;
        }
    }
    fclose(f);
    return retorno; // OK
}

void em_calcularSueldo(void* p)
{
    if(((eEmpleado*)p)!=NULL){
        if(((eEmpleado*)p)->horasTrab<=176){
            ((eEmpleado*)p)->sueldo = ((eEmpleado*)p)->horasTrab * 180;
        }
        if(((eEmpleado*)p)->horasTrab>176 && ((eEmpleado*)p)->horasTrab<=208){
            ((eEmpleado*)p)->sueldo = ((eEmpleado*)p)->horasTrab * 270;
        }
        if(((eEmpleado*)p)->horasTrab>208 && ((eEmpleado*)p)->horasTrab<=240){
            ((eEmpleado*)p)->sueldo = ((eEmpleado*)p)->horasTrab * 360;
        }
    }
}
