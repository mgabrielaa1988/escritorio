#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include <conio.h>

typedef struct{
    int estado;
}eEstructura;

char menu();
char validarMenu(char);
void inicializarEstado(eEstructura vec[],int tam);
int buscarLibre(eEstructura vec[],int tam);
void listar(eEstructura vec);
void listarTodos(eEstructura vec[],int tam);
void alta(eEstructura vec[],int tam);
void baja(eEstructura vec[],int tam);
void modificar(eEstructura vec[],int tam);
void ordenar(eEstructura vec[],int tam);

int main()
{
    int salir = 0;

    do
    {
        switch(menu())
        {
        case '1':

            system("pause");
            break;
        case '2':

            system("pause");
            break;
        case '3':

            system("pause");
            break;
        case '4':

            system("pause");
            break;
        case '5':

            system("pause");
            break;
        case '6':
            salir = 1;
            break;
        default:
            printf("Opcion invalida...\n");
            system("pause");
            break;
        }
    }
    while(salir != 1);

    return 0;
}

/** \brief Inicializa el estado de un array de estructuras en 0(cero) para saber que este esta vacio
 * \param vec[] Array de estructuras a ser recorrido
 * \param tam Entero que determinado la cantidad de estructuras del array
 * \return void
 */
void inicializarEstado(eEstructura vec[],int tam)
{
    int i;
    for(i=0;i<tam;i++)
    {
        vec[i].estado = 0;
    }
}

/** \brief Busca en un array de estructuras cual es la primera estructura vacia
 * \param vec[] Array de estructuras a ser recorrido
 * \param tam Entero que determina la cantidad de estructuras del array
 * \return indice Numero entero que devuelve: -1 en caso de que no haya estructuras vacias, ó el indice
 del vector en caso de que una estructura tenga su estado en 0(cero) por lo que se la considera vacia
 */
int buscarLibre(eEstructura vec[],int tam)
{
    int i,indice = -1;
    for(i=0;i<tam;i++){
        if(vec[i].estado == 0){
            indice = i;
            break;
        }
    }
    return indice;
}

/** \brief Muestra todos los elementos cargados en una estructura
 * \param vec Estructura a mostrar
 * \return void
 */
void listar(eEstructura vec)
{
    printf("\n");
}

/** \brief Lista todos las estructuras del array que esten consideradas cargadas, es decir, solo las estructuras
cuyos estados sean diferentes a 0(cero)
 * \param vec[] Array de estructuras a ser recorrido
 * \param tam Entero que indica la cantidad de estructuras del array
 * \return void
 */
void listarTodos(eEstructura vec[],int tam)
{
    int i;
    printf("\n");
    for(i=0;i<tam;i++){
        if(vec[i].estado != 0){
            listar(vec[i]);
        }
    }
}

/** \brief Muestra un menu de opciones y permite elegir una
 * \return opcion Devuelve un caracter cargado con la opcion elegida por el usuario
 */
char menu()
{
    char opcion;
    system("cls");
    printf("-------MENU-------\n\n");
    printf("-1- Alta\n");
    printf("-2- Baja\n");
    printf("-3- Modificacion\n");
    printf("-4- Listar\n");
    printf("-5- Ordenar\n");
    printf("-6- Salir\n\n");
    printf("Elija una opcion: ");
    fflush(stdin);
    opcion = getche();
    opcion = validarMenu (opcion);
    return opcion;
}

/** \brief Valida que el caracter recibido este entre los valores xx y xx de la tabla ASCII
y de no ser asi se le pide al usuario que reingrese una opcion valida
 * \param opcion Caracter a ser evaluado
 * \return opcion Caracter que esta entre los parametros pedidos
 */
char validarMenu (char opcion)
{
    while ((int)opcion<49 || (int)opcion>53)
    {
        printf("\n  Opcion no valida...\n");
        printf("  Reingrese una opcion del menu ");
        opcion = getche();
    }
    return opcion;
}
