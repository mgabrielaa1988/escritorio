#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>
#include <string.h>
#include "ArrayList.h"
#include "registros.h"
#include "generic.h"

sRegistro* new_Registro()
{
    sRegistro* returnAux = NULL;

    returnAux=(sRegistro*)malloc(sizeof(sRegistro));
    if(returnAux!=NULL)
    {
        returnAux->id_registro=0;
        returnAux->id_registro=0;
        returnAux->codTarea=0;
        returnAux->cantidadHoras=0;
        returnAux->precioUnitario=0;
    }
    return returnAux;
}

sRegistro* new_Registro_Parameters(int idNew,int idEmpleadoNew,int codTareaNew,int cantHorasNew, float precioUnitarioNew)
{
    sRegistro* returnAux = NULL;

    returnAux=new_Registro();
    if(returnAux!=NULL)
    {
        returnAux->id_registro=idNew;
        returnAux->id_empleado=idEmpleadoNew;
        returnAux->codTarea=codTareaNew;
        returnAux->cantidadHoras=cantHorasNew;
        returnAux->precioUnitario=precioUnitarioNew;
    }
    return returnAux;
}

int loadRegistros(ArrayList* this)
{
    char idRegistro[6], idEmpelado[6], codTarea[6], cantidadHoras[6], precioUnitario[10];
    int returnAux=-1,auxRegistro, auxIdregistro,auxCodTarea,auxCantidadHoras;
    float auxPrecio;
    sRegistro* auxRegistroMain;

    FILE* f = fopen ("registro_de_dia.txt","r");
    if(f!=NULL)
    {
        returnAux=0;
        this->clear(this);
        fscanf(f,"%[^,],%[^,],%[^,],%[^,],%[^\n]\n",idRegistro,idEmpelado,codTarea,cantidadHoras,precioUnitario);

        while(!feof(f))
        {
            fscanf(f,"%[^,],%[^,],%[^,],%[^,],%[^\n]\n",idRegistro,idEmpelado,codTarea,cantidadHoras,precioUnitario);
            auxRegistro=atoi(idRegistro);
            auxIdregistro=atoi(idEmpelado);
            auxCodTarea=atoi(codTarea);
            auxCantidadHoras=atoi(cantidadHoras);
            auxPrecio=atof(precioUnitario);

            auxRegistroMain = new_Registro_Parameters(auxRegistro,auxIdregistro,auxCodTarea,auxCantidadHoras,auxPrecio);
            if(this->add(this,auxRegistroMain)==0);
            {
                returnAux=1;
            }
        }
    }
    else
    {
        f = fopen ("registro_de_dia.txt","w");
        returnAux=0;
    }

    fclose(f);
    return returnAux;
}

int listarRegistro(sRegistro* registro)
{
    int returnAux=-1;

    if(registro!=NULL)
    {
        returnAux=printf("Id:%d\tId Emp:%d\tCod:%d\tCantHoras:%d\tMonto: %.2f\n",registro->id_registro,registro->id_empleado,registro->codTarea,registro->codTarea,registro->precioUnitario);
    }

    return returnAux;
}

int listarRegistros(ArrayList* this)
{
    int returnAux=-1,i;
    sRegistro* auxRegistro=NULL;

    for(i=0;i<this->len(this);i++)
    {
        auxRegistro=this->get(this,i);
        if(auxRegistro!=NULL)
        {
            returnAux=listarRegistro(auxRegistro);
        }
    }

    return returnAux;
}


int verificarRegistro(ArrayList* this, int id)
{
    int returnAux=-1,i;
    sRegistro* auxRegistro;

    if(this!=NULL)
    {
        returnAux=0;
        for(i=0; i<this->len(this); i++)
        {
            auxRegistro=this->get(this,i);

            if(auxRegistro->id_registro==id)
            {
                returnAux=1;
                break;
            }
        }
    }

    return returnAux;
}

sRegistro* obtenerRegistro(ArrayList* this, int id)
{
    int i;
    sRegistro* auxRegistro=NULL;

    if(this!=NULL)
    {
        for(i=0; i<this->len(this); i++)
        {
            auxRegistro=this->get(this,i);

            if(auxRegistro->id_registro==id)
            {
                break;
            }
            else
            {
                auxRegistro=NULL;
            }
        }
    }

    return auxRegistro;
}

int obtenerRegistroBaja(ArrayList* this, int id, sRegistro* auxRegistro)
{
    int i, returnAux=-1;
    sRegistro* auxRegistro2=NULL;

    if(this!=NULL)
    {
        for(i=0; i<this->len(this); i++)
        {
            auxRegistro2=this->get(this,i);

            if(auxRegistro==auxRegistro2)
            {
                returnAux=i;
                break;
            }
        }
    }

    return returnAux;
}

int eliminarRegistro(ArrayList* registroList)
{
    int returnAux=-1,idRegistro,nValido=1,indexBaja;
    sRegistro* auxRegistro;
    char rta='n';

    if(registroList!=NULL)
    {
        returnAux=0;

        listarRegistros(registroList);
        do
        {
            nValido=getInt(&idRegistro, "Ingrese el Id del registro: ", 15,1, 10000);
            printNextLine();

            nValido=verificarRegistro(registroList,idRegistro);
        }
        while(nValido!=1);

        auxRegistro=obtenerRegistro(registroList,idRegistro);
        if(auxRegistro!=NULL)
        {
            listarRegistro(auxRegistro);
            indexBaja=obtenerRegistroBaja(registroList,idRegistro,auxRegistro);
            getStringChar(&rta,"\nDesea dar de baja? ");
            rta=tolower(rta);
            if(rta=='s')
            {
                registroList->remove(registroList,indexBaja);
                printf("Baja Exitosa.\n");
            }
            else
            {
                printf("Accion cancelada por el usuario.\n");
            }
        }

    }

    return returnAux;
}
