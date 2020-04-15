
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#include "arraylist.h"
#include "validaciones.h"
#include "funciones.h"

int generarArchivoSueldos(char* fileName,ArrayList* listaEmpleados);

int main()
{
    // Definir lista de empleados
    ArrayList* listaEmpleados=al_newArrayList();

    // Crear lista empledos
    //...

    // Leer empleados de archivo data.csv
    if(parser_parseEmpleados("data.csv",listaEmpleados)==1)
    {
        // Calcular sueldos
        printf("Calculando sueldos de empleados\n");
        al_map(listaEmpleados,em_calcularSueldo);

        // Generar archivo de salida
        if(generarArchivoSueldos("sueldos.csv",listaEmpleados)==1)
        {
            printf("Archivo generado correctamente\n");
        }
        else
            printf("Error generando archivo\n");
    }
    else
        printf("Error leyando empleados\n");


    return 0;
}

int generarArchivoSueldos(char* fileName,ArrayList* listaEmpleados)
{
int retorno = -1;
int i;
    eEmpleado* auxEmpleados = new_Empleado();

    FILE *f = fopen (fileName,"w");
    if(f!=NULL)
    {
        for(i=0; i<listaEmpleados->len(listaEmpleados); i++)
        {
            auxEmpleados = al_get(listaEmpleados,i);

            retorno=fprintf(f,"%d,%s,%d,%.2f\n",auxEmpleados->id,auxEmpleados->nombre,auxEmpleados->horasTrab,auxEmpleados->sueldo);
        }
    }
    fclose(f);
    return retorno;
}
