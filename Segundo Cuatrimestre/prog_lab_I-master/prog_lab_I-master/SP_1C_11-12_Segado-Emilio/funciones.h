#ifndef FUNCIONES_H_INCLUDED
#define FUNCIONES_H_INCLUDED

typedef struct
{
    char nombre[15];
    int prioridad;
    int tiempoDeTarea;
} sTarea;

/** \brief Obtiene una opcion para el menu con un entero positivo
 *
 * \return int Opcion de menu
 *
 */
int getOpcion();

/** \brief Crea un nuevo elemento sTarea y setea los valores default
 *
 * \return sTarea* puntero al nuevo elemento
 *
 */
sTarea* tarea_New();

/** \brief Crea un nuevo elementos sTarea con valores especificados en los parametros
 *
 * \param auxNombre char* Puntero al nombre de la tarea
 * \param auxPrioridad int Prioridad de la tarea
 * \param auxTiempoDeTarea int Tiempo de la tarea
 * \return sTarea* puntero al nuevo elemento
 *
 */
sTarea* tarea_New_Parameters(char* auxNombre, int auxPrioridad,int auxTiempoDeTarea);

/** \brief Imprime por pantalla un elemento sTarea
 *
 * \param auxTarea sTarea* Elemento a imprimir
 * \return int 1- Si hay error (auxTarea=NULL), 0 si ok.
 *
 */
int printOne(sTarea* auxTarea);

/** \brief Imprime por pantalla todos los elementos sTarea de un array
 *
 * \param this ArrayList* Lista de elementos sTarea
 * \return int 1- Si hay error (this=NULL), 0 si ok.
 *
 */
int printAll(ArrayList* this);

/** \brief Muestra las listas de Alta y Baja Prioridad en orden
 *
 * \param ArrayList* listaAlta Lista de Alta prioridad
 * \param ArrayList* listaBaja Lista de Baja prioridad
 * \return int 1- Si hay error (listaAlta=NULL o listaBaja=NULL), 0 si ok.
 *
 */
int mostrarListas(ArrayList* listaAlta, ArrayList* listaBaja);

/** \brief Carga los datos sTarea desde un archivo
 *
 * \param ArrayList* this Lista de elementos sTarea donde se guardaran los datos
 * \return int 1- Si hay error (this=NULL), 0 si no se ha podido cargar ningun elemento, 1 si ok.
 *
 */
int loadTareas(ArrayList* this);

/** \brief Comprar los tiempos de dos tareas
 *
 * \param a sTarea* Primer tarea a comparar
 * \param b sTarea* Segunda tarea a comparar
 * \return int 1 si el tiempo de la primer tarea es menor, -1 si el tiempo de la segunda es menor
 *
 */
int compararTiempos(void* a, void* b);

/** \brief Ordena las tareas segun el tiempo de forma descendiente
 *
 * \param ArrayList* this lista de Tareas
 * \return int 1- Si hay error (this=NULL), 0 si ok.
 *
 */
int ordenarTareas(ArrayList*this);

/** \brief Añade los elementos de la lista principal a la segundaria solo si cumple con la prioridad especificada
 *
 * \param this ArrayList* Lista principal de Tareas
 * \param listaSecundaria ArrayList* Lista secundaria donde se añadiran los elementos
 * \param auxPrioridad int Criterio de propiedad para filtrar las tareas 0=Baja, 1=Alta
 * \return int 1- Si hay error (this=NULL o listaSecundaria=NULL), 0 si ok.
 *
 */
int addToArray(ArrayList* this, ArrayList* listaSecundaria, int auxPrioridad);

/** \brief Particiona las tareas segun sus prioridades
 *
 * \param this ArrayList* Lista principal de tareas
 * \param pAlta ArrayList* Lista de tareas con prioridad Alta
 * \param ArrayList*pBaja Lista de tareas con prioridad Baja
 * \return int 1- Si hay error (this=NULL o pAlta=NULL o pBaja=NULL ), 0 si ok.
 *
 */
int particionar(ArrayList* this, ArrayList* pAlta, ArrayList*pBaja);

/** \brief Resuelve una tarea, eliminando el elemento sTarea relacionado de las lista principal y de su lista especifica
 *
 * \param listaAll ArrayList* Lista principal
 * \param listaAlta ArrayList* Lista de prioridad Alta
 * \param listaBaja ArrayList* Lista de prioridad Baja
 * \return int 1- Si hay error (listaAll=NULL o listaAlta=NULL o listaBaja=NULL ), 0 si no se ha podido resolver ninguna tarea, 1 si ok.
 *
 */
int resolverTarea(ArrayList* listaAll, ArrayList* listaAlta, ArrayList* listaBaja);

/** \brief Guarda un archivo de lista con el nombre especificado
 *
 * \param nombreArchivo char* Puntero al nombre del archivo
 * \param this ArrayList* Lista que será guardada
 * \return int 1- Si hay error (this=NULL),>0 si ok.
 *
 *
 */
int saveFile(char* nombreArchivo, ArrayList* this);

#endif // FUNCIONES_H_INCLUDED
