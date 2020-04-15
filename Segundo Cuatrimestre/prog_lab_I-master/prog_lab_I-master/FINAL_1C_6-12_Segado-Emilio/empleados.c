#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>
#include <string.h>
#include "ArrayList.h"
#include "generic.h"
#include "empleados.h"

sEmpleado* new_Empleado()
{
    sEmpleado* returnAux = NULL;

    returnAux=(sEmpleado*)malloc(sizeof(sEmpleado));
    if(returnAux!=NULL)
    {
        returnAux->id=0;
        strcpy(returnAux->nombre,"");
        strcpy(returnAux->apellido,"");
        returnAux->dni=0;
    }
    return returnAux;
}

sEmpleado* new_Empleado_Parameters(int idNew, char* nameNew, char* lastNameNew, int dniNew)
{
    sEmpleado* returnAux = NULL;

    returnAux=new_Empleado();
    if(returnAux!=NULL)
    {
        returnAux->id=idNew;
        strcpy(returnAux->nombre,nameNew);
        strcpy(returnAux->apellido,lastNameNew);
        returnAux->dni=dniNew;
    }
    return returnAux;
}

int loadEmpelados(ArrayList* this)
{
    char id[10], name[30], lastname[30], dni[10];
    int returnAux=-1,auxId, auxDni;
    sEmpleado* auxEmpleado;

    FILE* f = fopen ("empleados.txt","r");
    if(f!=NULL)
    {
        returnAux=0;
        this->clear(this);
        fscanf(f,"%[^,],%[^,],%[^,],%[^\n]\n",id,name,lastname,dni);

        while(!feof(f))
        {
            fscanf(f,"%[^,],%[^,],%[^,],%[^\n]\n",id,name,lastname,dni);
            auxId=atoi(id);
            auxDni=atoi(dni);

            auxEmpleado = new_Empleado_Parameters(auxId,name,lastname,auxDni);
            if(this->add(this,auxEmpleado)==0);
            {
                returnAux=1;
            }
        }
    }
    else
    {
        f = fopen ("empleados.txt","w");
        returnAux=0;
    }
    fclose(f);
    return returnAux;
}

int listarEmpleado(sEmpleado* empleado)
{
    int returnAux=-1;

    if(empleado!=NULL)
    {
        returnAux=printf("Id:%d\tNombre:%s\tApellido:%s\tDni:%d\n",empleado->id,empleado->nombre,empleado->apellido,empleado->dni);
    }

    return returnAux;
}

int listarEmpleados(ArrayList* this)
{
    int returnAux=-1,i;
    sEmpleado* auxEmpleado=NULL;

    for(i=0;i<this->len(this);i++)
    {
        auxEmpleado=this->get(this,i);
        if(auxEmpleado!=NULL)
        {
            returnAux=listarEmpleado(auxEmpleado);
        }
    }

    return returnAux;
}

int obtenerId(ArrayList* this)
{
    int returnAux=-1,i,posibleId=-1,flag;
    sEmpleado* auxEmpleado;
    if(this!=NULL)
    {

        for(posibleId=100; posibleId<10000; posibleId++)
        {
            flag=0;

            for(i=0; i<this->len(this); i++)
            {
                auxEmpleado=this->get(this,i);

                if(flag==0)
                {
                    if(posibleId==auxEmpleado->id)
                    {
                        flag=1;
                    }
                }
            }

            if(flag==0)
            {
                returnAux=posibleId;
                break;
            }
        }
    }

    return returnAux;
}
sEmpleado* obtenerDatos(ArrayList* this)
{
    int id,dni,nValido,i;
    char nombre[50], apellido[50];
    sEmpleado* auxEmpleado=NULL;

    if(this!=NULL)
    {
        id=obtenerId(this);

        getStringAlpha(nombre, "Ingrese el Nombre: ", 50);
        printNextLine();

        for(i=0; i<strlen(nombre); i++)
        {
            nombre[i]=tolower(nombre[i]);
        }
        nombre[0]=toupper(nombre[0]);

        getStringAlpha(apellido, "Ingrese el apellido: ", 50);
        printNextLine();

        for(i=0; i<strlen(apellido); i++)
        {
            apellido[i]=tolower(apellido[i]);
        }
        apellido[0]=toupper(apellido[0]);

        do
        {
            nValido=getInt(&dni, "Ingrese el dni: ", 50, 10000000, 99999999);
            printNextLine();
        }
        while(nValido!=1);

        auxEmpleado=new_Empleado_Parameters(id,nombre,apellido,dni);
    }

    return auxEmpleado;
}

int addEmpleado(ArrayList* this)
{
    int returnAux=-1;
    sEmpleado* auxEmpleado=new_Empleado();

    if(this!=NULL)
    {
        returnAux=0;
        auxEmpleado=obtenerDatos(this);

        if(!this->add(this,auxEmpleado))
        {
            returnAux=1;
        }
        listarEmpleado(auxEmpleado);
    }
    return returnAux;
}

sEmpleado* obtenerEmpleado(ArrayList* this, int id)
{
    int i;
    sEmpleado* auxEmpleado=NULL;

    if(this!=NULL)
    {
        for(i=0; i<this->len(this); i++)
        {
            auxEmpleado=this->get(this,i);

            if(auxEmpleado->id==id)
            {
                break;
            }
            else
            {
                auxEmpleado=NULL;
            }
        }
    }

    return auxEmpleado;
}

int setNombre(sEmpleado* empleado,char*nombre)
{
    int returnAux=-1;
    if(empleado!=NULL && nombre!=NULL)
    {
        returnAux=0;
        strcpy(empleado->nombre,nombre);
    }
    return returnAux;
}

int setApellido(sEmpleado* empleado,char*apellido)
{
    int returnAux=-1;
    if(empleado!=NULL && apellido!=NULL)
    {
        returnAux=0;
        strcpy(empleado->apellido,apellido);
    }
    return returnAux;
}

int setDNI(sEmpleado* empleado,int dni)
{
    int returnAux=-1;
    if(empleado!=NULL)
    {
        returnAux=0;
        {
            empleado->dni=dni;
        }
    }
            return returnAux;
}

int modificarValores(sEmpleado* auxEmpleado)
{
    int returnAux=-1,opcionCambio, nValido;
    char mensaje[]="\nQue desea cambiar?\
    \n1- Nombre\
    \n2- Apellido\
    \n3- Dni\
    \n4-Cancelar/Salir\n\nIngrese: ";

    int auxDni;
    char auxNombre[50],auxApellido[50];
    char rta, continuar;

    if(auxEmpleado!=NULL)
    {
        returnAux=0;
        do
        {
            cleanScreen();
            listarEmpleado(auxEmpleado);
            do
            {
                printNextLine();
                nValido=getInt(&opcionCambio,mensaje,50,1,4);
            }
            while(nValido!=1);

            switch(opcionCambio)
            {
            case 1:
                getStringAlpha(auxNombre, "Ingrese el Nuevo Nombre: ", 50);
                printNextLine();

                getStringChar(&rta, "Desea cambiar los datos? ");
                rta=tolower(rta);
                if(rta=='s')
                {
                    setNombre(auxEmpleado,auxNombre);
                    printf("Datos cambiados exitosamente.\n");
                }
                else
                {
                    printf("Accion cancelada por el usuario.\n");
                }
                break;
            case 2:
                getStringAlpha(auxApellido, "Ingrese el Nuevo Apellido: ", 50);
                printNextLine();

                getStringChar(&rta, "Desea cambiar los datos? ");
                rta=tolower(rta);
                if(rta=='s')
                {
                    setApellido(auxEmpleado,auxApellido);
                    printf("Datos cambiados exitosamente.\n");
                }
                else
                {
                    printf("Accion cancelada por el usuario.\n");
                }
                break;
            case 3:
                do
                {
                    nValido=getInt(&auxDni, "Ingrese el Nuevo DNI: ", 50, 10000000, 99999999);
                    printNextLine();
                }
                while(nValido!=1);

                getStringChar(&rta, "Desea cambiar los datos? ");
                rta=tolower(rta);
                if(rta=='s')
                {
                    setDNI(auxEmpleado,auxDni);
                    printf("Datos cambiados exitosamente.\n");
                }
                else
                {
                    printf("Accion cancelada por el usuario.\n");
                }
                break;
            case 4:
                returnAux=1;
                continuar='n';
                break;
            }
        }
        while(continuar!='n');
    }
    return returnAux;
}

int verificarEmpleado(ArrayList* this, int id)
{
    int returnAux=-1,i;
    sEmpleado* auxEmpleado;

    if(this!=NULL)
    {
        returnAux=0;
        for(i=0; i<this->len(this); i++)
        {
            auxEmpleado=this->get(this,i);

            if(auxEmpleado->id==id)
            {
                returnAux=1;
                break;
            }
        }
    }

    return returnAux;
}
int modificarEmpleado(ArrayList* this)
{
    int id,nValido,idValido=0,returnAux=-1;
    sEmpleado* auxEmpleado=NULL;

    if(this!=NULL)
    {
        returnAux=0;
        listarEmpleados(this);

        do
        {
            do
            {
                nValido=getInt(&id, "Ingrese el id del Empleado: ", 15, 100, 10000);
                printNextLine();
            }
            while(nValido!=1);

            idValido=verificarEmpleado(this,id);
        }
        while(idValido!=1);

        auxEmpleado=obtenerEmpleado(this,id);
        if(auxEmpleado!=NULL)
        {
            modificarValores(auxEmpleado);
        }
    }
    return returnAux;
}
int obtenerEmpleadoBaja(ArrayList* this, int id, sEmpleado* auxEmpleado)
{
    int i, returnAux=-1;
    sEmpleado* auxEmpleado2=NULL;

    if(this!=NULL)
    {
        for(i=0; i<this->len(this); i++)
        {
            auxEmpleado2=this->get(this,i);

            if(auxEmpleado==auxEmpleado2)
            {
                returnAux=i;
                break;
            }
        }
    }

    return returnAux;
}

//Baja fisica
int bajaFisica(ArrayList* this)
{
    int id,nValido,idValido=0,returnAux=-1, indexBaja;
    sEmpleado* auxEmpleado=NULL;
    char rta='n';

    if(this!=NULL)
    {
        returnAux=0;
        listarEmpleados(this);
        do
        {
            do
            {
                nValido=getInt(&id, "\n\nIngrese el id: ", 50, -1, 10000);
                printNextLine();
            }
            while(nValido!=1);

            if(id!=-1)
            {
                idValido=verificarEmpleado(this,id);
                if(idValido==0)
                {
                    printf("Error. Id no existente\n");
                }
            }
            else
            {
                printf("Cancelado\n");
                return returnAux;
            }
        }
        while(idValido!=1);

        auxEmpleado=obtenerEmpleado(this,id);
        if(auxEmpleado!=NULL)
        {
            listarEmpleado(auxEmpleado);
            indexBaja=obtenerEmpleadoBaja(this,id,auxEmpleado);
            getStringChar(&rta,"\nDesea dar de baja? ");
            rta=tolower(rta);
            if(rta=='s')
            {
                this->remove(this,indexBaja);
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

