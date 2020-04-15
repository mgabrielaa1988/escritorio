#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "ArrayList.h"
#include "generic.h"
#include "funciones.h"



sTarea* tarea_New()
{
    sTarea* returnAux = NULL;

    returnAux=(sTarea*)malloc(sizeof(sTarea));
    if(returnAux!=NULL)
    {
        strcpy(returnAux->nombre,"");
        returnAux->prioridad=0;
        returnAux->tiempoDeTarea=0;
    }
    return returnAux;
}

sTarea* tarea_New_Parameters(char* auxNombre, int auxPrioridad,int auxTiempoDeTarea)
{
    sTarea* returnAux = NULL;

    returnAux = tarea_New();
    if(returnAux!=NULL)
    {
        strcpy(returnAux->nombre,auxNombre);
        returnAux->prioridad=auxPrioridad;
        returnAux->tiempoDeTarea=auxTiempoDeTarea;
    }
    return returnAux;
}

int printOne(sTarea* auxTarea)
{
    int auxReturn=-1;

    if(auxTarea!=NULL)
    {
        if(auxTarea->prioridad==0)
        {
            printf("Nombre: %s - Prioridad: Baja - Tiempo de demora: %d\n",auxTarea->nombre,auxTarea->tiempoDeTarea);
        }
        else
        {
            printf("Nombre: %s - Prioridad: Alta - Tiempo de demora: %d\n",auxTarea->nombre,auxTarea->tiempoDeTarea);
        }
        auxReturn=0;
    }

    return auxReturn;
}

int printAll(ArrayList* this)
{
    int i, returnAux=-1;
    sTarea* auxTarea;

    if(this!=NULL)
    {
        for(i=0; i<this->len(this); i++)
        {
            auxTarea=this->get(this,i);

            if(auxTarea!=NULL)
            {
                returnAux=printOne(auxTarea);
            }
        }
    }
    return returnAux;
}

int mostrarListas(ArrayList* listaAlta, ArrayList*listaBaja)
{
    int returnAux=-1;
    if(listaAlta!=NULL && listaBaja!=NULL)
    {
        returnAux=0;
        printf("\nLista de prioridad Alta\nCantidad de Tareas %d\n",listaAlta->len(listaAlta));
        printAll(listaAlta);
        printf("\nLista de prioridad Baja\nCantidad de Tareas %d\n",listaBaja->len(listaBaja));
        printAll(listaBaja);
    }

    return returnAux;
}

int loadTareas(ArrayList*this)
{
    char nombre[15],prioridad[5],tiempoDeTarea[10];
    int auxPrioridad, auxTiempoDeTarea, returnAux=-1;
    sTarea* auxTarea;

    FILE* f = fopen ("tar.csv","r");
    if(f!=NULL)
    {
        returnAux=0;

        while(!feof(f))
        {
            fscanf(f, "%[^,],%[^,],%[^\n]\n", nombre, prioridad, tiempoDeTarea);
            auxPrioridad=atoi(prioridad);
            auxTiempoDeTarea=atoi(tiempoDeTarea);

            auxTarea = tarea_New_Parameters(nombre, auxPrioridad, auxTiempoDeTarea);
            printOne(auxTarea);
            if(this->add(this,auxTarea)==0);
            {
                returnAux=1;
            }
        }

    }
    else
    {
        f = fopen ("tar.csv","w");
        returnAux=0;
    }

    fclose(f);
    return returnAux;
}

int compararTiempos(void* a, void* b)
{
    int returnAux=-1;

    if((sTarea*)a!=NULL && (sTarea*)b!=NULL)
    {
        if(((sTarea*)a)->tiempoDeTarea < ((sTarea*)b)->tiempoDeTarea)
        {
            returnAux=-1;
        }
        else
        {
            if(((sTarea*)a)->tiempoDeTarea > ((sTarea*)b)->tiempoDeTarea)
            {
                returnAux=1;
            }
        }
    }
    return returnAux;
}

int ordenarTareas(ArrayList* this)
{
    int returnAux=-1;
    if(this!=NULL)
    {
        returnAux=this->sort(this,compararTiempos,0);
    }

    return returnAux;
}

int addToArray(ArrayList* this, ArrayList* listaSecundaria, int auxPrioridad)
{
    int returnAux=-1,i;
    sTarea* auxTarea;

    if(this!=NULL && listaSecundaria!=NULL)
    {
        for(i=0; i<this->len(this); i++)
        {
            auxTarea=this->get(this,i);
            if(auxTarea->prioridad==auxPrioridad)
            {
                returnAux=listaSecundaria->add(listaSecundaria,auxTarea);
            }
        }
    }

    return returnAux;
}

int particionar(ArrayList* this, ArrayList* pAlta, ArrayList*pBaja)
{
    int returnAux=-1, altaFlag, bajaFlag;

    if(this!=NULL && pAlta!=NULL && pBaja!=NULL)
    {
        pAlta->clear(pAlta);
        pBaja->clear(pBaja);

        altaFlag=addToArray(this,pAlta,1);
        bajaFlag=addToArray(this,pBaja,0);

        if(altaFlag==-1)
        {
            printf("Error en Lista de Alta prioridad");
        }

        if(bajaFlag==-1)
        {
            printf("Error en Lista de baja prioridad");
        }

        if(altaFlag==0 || bajaFlag==0)
        {
            returnAux=0;
        }
    }
    return returnAux;
}

int resolverTarea(ArrayList* listaAll, ArrayList* listaAlta, ArrayList* listaBaja)
{
    int returnAux=-1;
    sTarea* auxTarea=NULL;
    if(listaAll!=NULL && listaAlta!=NULL && listaBaja!=NULL)
    {
        returnAux=0;

        if(listaAlta->len(listaAlta)>0)
        {
            ordenarTareas(listaAlta);
            auxTarea=listaAlta->pop(listaAlta,0);
        }
        else
        {
            if(listaBaja->len(listaBaja)>0)
            {
                ordenarTareas(listaBaja);
                auxTarea=listaBaja->pop(listaBaja,0);
            }
        }

        if(auxTarea!=NULL)
        {
            printf("\nTarea completada\n");
            printOne(auxTarea);
            returnAux=1;
        }
    }

    return returnAux;
}

int saveFile(char* nombreArchivo, ArrayList* this)
{
    int returnAux=-1, i;
    sTarea* auxTarea=tarea_New();

    FILE *f = fopen (nombreArchivo,"w");
    if(f!=NULL)
    {
        for(i=0; i<this->len(this); i++)
        {
            auxTarea = al_get(this,i);

            returnAux=fprintf(f,"%s,%d,%d\n",auxTarea->nombre,auxTarea->prioridad,auxTarea->tiempoDeTarea);
        }
    }

    fclose(f);
    return returnAux;
}
