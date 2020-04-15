#include <stdio.h>
#include <stdlib.h>
#include "ArrayList.h"
#include "empleados.h"
#include "registros.h"
#include "multiple.h"
#include "generic.h"

sRegistro* obtenerDatosRegistro(ArrayList* registrosList, ArrayList* empleadosList)
{
    int idRegistro,idEmpleado,codTrabajo,cantHoras,precioUnitario=0,idValido,nValido=1;
    sRegistro* auxRegistro=NULL;

    if(registrosList!=NULL && empleadosList!=NULL)
    {
        listarEmpleados(empleadosList);

        do
        {
            do
            {
                nValido=getInt(&idEmpleado, "Ingrese el id del Empleado: ", 15, 100, 10000);
                printNextLine();
            }
            while(nValido!=1);

            idValido=verificarEmpleado(empleadosList,idEmpleado);
        }
        while(idValido!=1);

        do
        {
            nValido=getInt(&codTrabajo, "Ingrese el Codigo de la Tarea (10-20-30-40-50):", 15, 10, 50);
            printNextLine();

            if(codTrabajo!=10 && codTrabajo!=20 && codTrabajo!=30 && codTrabajo!=40 && codTrabajo!=50)
            {
                nValido=0;
            }
        }
        while(nValido!=1);

        do
        {
            nValido=getInt(&cantHoras, "Ingrese la cantidad de Horas del Empleado: ", 15,1, 10000);
            printNextLine();
        }
        while(nValido!=1);

        if(codTrabajo==10)
        {
            precioUnitario=252.23;
        }
        else
        {
            if(codTrabajo==20)
            {
                precioUnitario=295.55;
            }
            else
            {
                if(codTrabajo==30)
                {
                    precioUnitario=252.23;
                }
                else
                {
                    if(codTrabajo==40)
                    {
                        precioUnitario=215.22;
                    }
                    else
                    {
                        if(codTrabajo==50)
                        {
                            precioUnitario=295.55;
                        }
                    }
                }
            }
        }

        idRegistro=obtenerId(registrosList);
        auxRegistro=new_Registro_Parameters(idRegistro, idEmpleado, codTrabajo, cantHoras,precioUnitario);
    }
    return auxRegistro;
}

int registrarDia(ArrayList* registrosList, ArrayList* empleadosList)
{
    int returnAux=-1;
    sRegistro* auxRegistro;

    if(registrosList!=NULL && empleadosList!=NULL)
    {
        returnAux=0;

        auxRegistro=obtenerDatosRegistro(registrosList,empleadosList);
        if(auxRegistro!=NULL)
        {
            if(!registrosList->add(registrosList,auxRegistro))
            {
                listarRegistro(auxRegistro);
                returnAux=1;
            }

        }
    }

    return returnAux;
}
