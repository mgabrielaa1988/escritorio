#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>
#include <string.h>
#include <conio.h>

#include "arraylist.h"
#include "validaciones.h"
#include "funciones.h"


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


/** \brief Valida el tamanio de un string
 * \param char texto String a validar
 * \param int tam Entero que indica la cantidad de caracteres maximo
 * \return retorno 1 si el string tiene mas caracteres que el maximo indicado
                   0 si el string tiene el tamanio adecuado
 */
int validarTamStr(char* texto,int tam)
{
    int retorno = 1;
    if(strlen(texto)<tam)
    {
        retorno = 0;
    }
    return retorno;
}

/**
 * \brief Solicita un número al usuario y devuelve el resultado
 * \param mensaje Es el mensaje a ser mostrado
 * \return El número ingresado por el usuario
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
 * \return 0 si es númerico y 1 si no lo es
 */
int esNumerico(char* str)
{
    int retorno = 0;
    int i=0;
    while(*(str+i) != '\0')
    {
        if(*(str+i) < '0' || *(str+i) > '9')
            retorno = 1;
        i++;
    }
    return retorno;
}


/**
 * \brief Solicita un número al usuario y devuelve el resultado
 * \param mensaje Es el mensaje a ser mostrado
 * \return El número ingresado por el usuario
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
 * \return 0 si es númerico y 1 si no lo es
 */
int esNumericoFlotante(char* str)
{
    int i=0;
    int cantidadPuntos=0;
    int retorno = 0;
    while(*(str+i) != '\0')
    {
        if (*(str+i) == '.' && cantidadPuntos == 0)
        {
            cantidadPuntos++;
            i++;
            continue;

        }
        if(*(str+i) < '0' || *(str+i) > '9')
            retorno = 1;
        i++;
    }
    return retorno;
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


/** \brief Valida que se ingresan solo los caracteres 's' o 'n'
 * \param char respuesta Caracter a ser analizado
 * \return char respCorrecta Caracter 's' o 'n'
 */
char validarGuardar(char respuesta)
{
    char respCorrecta;
    while(respuesta!= 's' && respuesta!= 'n')
    {
        printf("\nSolo son validos los caracteres S=SI / N=NO\n");
        printf("Reingrese:  ");
        fflush(stdin);
        scanf("%c",&respCorrecta);
        respCorrecta = tolower(respCorrecta);
    }
    return respCorrecta;
}

