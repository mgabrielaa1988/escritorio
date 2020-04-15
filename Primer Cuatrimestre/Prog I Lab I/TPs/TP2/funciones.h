#ifndef FUNCIONES_H_INCLUDED
#define FUNCIONES_H_INCLUDED

typedef struct
{

    char nombre[50];
    int edad;
    int estado;
    long int dni;

} ePersona;

/**
 * \brief Inicializa un array de ePersonas con el valor recibido
 * \param persona Es el array a ser inicializado
 * \param tam Indica la longitud del array
 * \param valor Es el valor que sera cargado en cada posicion
 * \return void
 *
 */
void inicializar(ePersona persona[],int tam,int valor);

/**
 * \brief Busca la primer ocurrencia de un valor en un array de ePersonas
 * \param persona Es el array en el cual buscar
 * \param tam Indica la logitud del array
 * \param valor Es el valor que se busca
 * \return Si no hay ocurrencia (-1) y si la hay, la posicion de la misma
 *
 */
int buscar(ePersona persona[],int tam,int valor);

/** \brief Obtiene el indice que coincide con el dni pasado por parametro.
 * \param persona el array se pasa como parametro.
 * \param tam indica la longitud del array
 * \param valor Es el valor que se busca
 * \return Si no hay ocurrencia (-1) y si la hay, la posicion de la misma
 *
 */
int buscarPorDni(ePersona persona[],int tam,int valor);


/** \brief
 *
 * \param
 * \param
 * \return
 *
 */
void imprimirGrafico(ePersona valor[],int num_valores);

#endif
