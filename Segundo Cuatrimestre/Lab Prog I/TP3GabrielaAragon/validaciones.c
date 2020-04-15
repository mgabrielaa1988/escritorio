#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>
#include <string.h>
#include <conio.h>
#include "funciones.h"
#include "validaciones.h"


int buscarLibre (EMovie* movie,int tam)
{
    int index = -1;
    int i;

    for (i=0; i<tam; i++)
    {
        if ((movie+i)->puntaje == -1)
        {
            index = i;
            break;
        }
    }
    return index;
}

/**
 * \brief Verifica si el valor recibido contiene solo letras y números
 * \param str Array con la cadena a ser analizada
 * \return 1 si contiene solo espacio o letras y números, y 0 si no lo es
 */
int esAlfaNumerico(char* str)
{
    int i=0;
    while(*(str+i) != '\0')
    {
        if(/*(*(str+i) < 'a' || *(str+i) > 'z') && (*(str+i) < 'A' || *(str+i) > 'Z') &&*/ (*(str+i) < ' ' || *(str+i) > '}'))
            return 0;
        i++;
    }
    return 1;
}

int validarTamStr(char* texto,int tam)
{
    int retorno =0;
    if(strlen(texto)<tam)
    {
        retorno = 1;
    }
    return retorno;
}

/**
 * \brief Solicita un número al usuario y devuelve el resultado
 * \param mensaje Es el mensaje a ser mostrado
 * \return El número ingresado por el usuario
 *
 */
int getInt(char* mensaje)
{
    int auxiliar;
    printf("%s",mensaje);
    scanf("%d",&auxiliar);
    return auxiliar;
}

/**
 * \brief Verifica si el valor recibido es numérico
 * \param str Array con la cadena a ser analizada
 * \return 1 si es númerico y 0 si no lo es
 *
 */

int esNumerico(char* str)
{
    int i=0;
    while(*(str+i) != '\0')
    {
        if(*(str+i) < '0' || *(str+i) > '9')
            return 0;
        i++;
    }
    return 1;
}

/**
 * \brief Solicita un número al usuario y devuelve el resultado
 * \param mensaje Es el mensaje a ser mostrado
 * \return El número ingresado por el usuario
 *
 */
float getFloat(char* mensaje)
{
    float auxiliar;
    printf("%s",mensaje);
    scanf("%f",&auxiliar);
    return auxiliar;
}

/**
 * \brief Verifica si el valor recibido es numérico aceptando flotantes
 * \param str Array con la cadena a ser analizada
 * \return 1 si es númerico y 0 si no lo es
 *
 */

int esNumericoFlotante(char* str)
{
    int i=0;
    int cantidadPuntos=0;
    while(*(str+i) != '\0')
    {
        if (*(str+i) == '.' && cantidadPuntos == 0)
        {
            cantidadPuntos++;
            i++;
            continue;

        }
        if(*(str+i) < '0' || *(str+i) > '9')
            return 0;
        i++;
    }
    return 1;
}

/**
 * \brief Solicita un texto al usuario y lo devuelve
 * \param mensaje Es el mensaje a ser mostrado
 * \param input Array donde se cargará el texto ingresado
 * \return void
 */
void getString(char* mensaje,char* input)
{
    printf("%s  ", mensaje);
    fflush(stdin);
    scanf ("%[^\n]", input);
}

char validarGuardar(char respuesta)
{
    while(respuesta!= 's' && respuesta!= 'n')
    {
        printf("\nSolo son validos los caracteres S=SI / N=NO\n");
        printf("Reingrese:  ");
        fflush(stdin);
        scanf("%c",&respuesta);
        respuesta = tolower(respuesta);
    }
    return respuesta;
}
