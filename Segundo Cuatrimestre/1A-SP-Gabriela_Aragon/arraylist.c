
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#include "arraylist.h"
#include "validaciones.h"
#include "funciones.h"

// funciones privadas
int resizeUp(ArrayList* this);
int expand(ArrayList* this,int index);
int contract(ArrayList* this,int index);

#define AL_INCREMENT      10
#define AL_INITIAL_VALUE  10
//___________________

/** \brief Allocate a new arrayList with AL_INITIAL_VALUE elements.
 * \param void
 * \return ArrayList* Return (NULL) if Error [if can't allocate memory]
 *                  - (pointer to new arrayList) if OK
 */
ArrayList* al_newArrayList(void)
{
    ArrayList* this;
    ArrayList* returnAux = NULL;
    void* pElements;
    this = (ArrayList *)malloc(sizeof(ArrayList));

    if(this != NULL)
    {
        pElements = malloc(sizeof(void *)*AL_INITIAL_VALUE );
        if(pElements != NULL)
        {
            this->size=0;
            this->pElements=pElements;
            this->reservedSize=AL_INITIAL_VALUE;
            this->add=al_add;
            this->len=al_len;
            this->set=al_set;
            this->remove=al_remove;
            this->clear=al_clear;
            this->clone=al_clone;
            this->get=al_get;
            this->contains=al_contains;
            this->push=al_push;
            this->indexOf=al_indexOf;
            this->isEmpty=al_isEmpty;
            this->pop=al_pop;
            this->subList=al_subList;
            this->containsAll=al_containsAll;
            this->deleteArrayList = al_deleteArrayList;
            this->sort = al_sort;
            this->map = al_map;
            returnAux = this;
        }
        else
        {
            free(this);
        }
    }

    return returnAux;
}

void* al_map(ArrayList* this,void(funcion)(void*)){
    int i;
    void* auxElement;

    if(this!=NULL){
        for(i=0;i<this->len(this);i++){
            auxElement = this->get(this,i);
            funcion(auxElement);
        }
    }
    return auxElement;
}

/** \brief  Add an element to arrayList and if is
 *          necessary resize the array
 * \param this ArrayList* Pointer to arrayList
 * \param pElement void* Pointer to element
 * \return int Return (-1) if Error [this or pElement are NULL pointer] - (0) if OK
 */
int al_add(ArrayList* this, void* pElement)
{
    int returnAux = -1;
    int okResizeUp;
    int flag = 0;

    if(this!=NULL && pElement!=NULL)
    {
        if(this->size == this->reservedSize)
        {
            okResizeUp = resizeUp(this);
            if(okResizeUp)
            {
                flag = -1;
            }
        }
        if(flag == 0)
        {
            *(this->pElements + this->size) = pElement;
            this->pElements[this->size] = pElement;
            this->size++;
            returnAux = 0;
        }
    }
    return returnAux;
}

/** \brief  Delete arrayList
 * \param this ArrayList* Pointer to arrayList
 * \return int Return (-1) if Error [this is NULL pointer] - (0) if OK
 */
int al_deleteArrayList(ArrayList* this)
{
    int returnAux = -1;

    if(this!=NULL)
    {
        this->size = 0;
        free(this->pElements);
        this->pElements = NULL;
        returnAux = 0;
    }
    return returnAux;
}

/** \brief  Size of arrayList
 * \param this ArrayList* Pointer to arrayList
 * \return int Return length of array or (-1) if Error [this is NULL pointer]
 */
int al_len(ArrayList* this)
{
    int returnAux = -1;
    if(this!=NULL)
    {
        returnAux = this->size;
    }
    return returnAux;
}

/** \brief  Get an element by index
 * \param this ArrayList* Pointer to arrayList
 * \param index int Index of the element
 * \return void* Return (NULL) if Error [this is NULL pointer or invalid index] - (Pointer to element) if OK
 */
void* al_get(ArrayList* this, int index)
{
    void* returnAux = NULL;
    if(this!=NULL && index>=0 && index<this->len(this))
    {
        returnAux = *(this->pElements+index);
    }
    return returnAux;
}

/** \brief  Find if this contains at least one element pElement
 * \param this ArrayList* Pointer to arrayList
 * \param pElement void* Pointer to element
 * \return int Return (-1) if Error [this or pElement are NULL pointer]
 *                  - ( 0) if OK but not found a element
 *                  - ( 1) if this list contains at least one element pElement
 */
int al_contains(ArrayList* this, void* pElement)
{
    int returnAux = -1;
    int i;
    if(this!=NULL && pElement!=NULL)
    {
        returnAux = 0;
        for(i=0; i<(this->len(this)); i++)
        {
            if(this->get(this,i) == pElement)
            {
                returnAux = 1;
                break;
            }
        }
    }
    return returnAux;
}

/** \brief Set a element in this at index position
 * \param this ArrayList* Pointer to arrayList
 * \param index int Index of the element
 * \param pElement void* Pointer to element
 * \return int Return (-1) if Error [this or pElement are NULL pointer or invalid index]
 *                  - ( 0) if OK
 */
int al_set(ArrayList* this,int index,void* pElement)
{
    int returnAux = -1;

    if(this!=NULL && pElement!=NULL && index>=0 && index<this->len(this))
    {
        *(this->pElements+index) = pElement;
        returnAux = 0;
    }
    return returnAux;
}

/** \brief  Remove an element by index
 * \param this ArrayList* Pointer to arrayList
 * \param index int Index of the element
 * \return int Return (-1) if Error [this is NULL pointer or invalid index]
 *                  - ( 0) if OK
 */
int al_remove(ArrayList* this,int index)
{
    int returnAux = -1;

    if(this!=NULL && index>=0 && index<this->len(this)){
        contract(this,index);
        returnAux = 0;
    }

    return returnAux;
}

/** \brief Removes all of the elements from this list
 * \param this ArrayList* Pointer to arrayList
 * \return int Return (-1) if Error [this is NULL pointer]
 *                  - ( 0) if OK
 */
int al_clear(ArrayList* this)
{
    int returnAux = -1;
    int i;

    if(this!=NULL)
    {
        for(i=0;i<this->len(this);i++){
            this->remove(this,i);
        }
        this->size = 0;
        resizeDown(this);
        returnAux = 0;
    }
    return returnAux;
}

/** \brief Returns an array containing all of the elements in this list in proper sequence
 * \param this ArrayList* Pointer to arrayList
 * \return ArrayList* Return  (NULL) if Error [this is NULL pointer]
 *                          - (New array) if OK
 */
ArrayList* al_clone(ArrayList* this)
{
    ArrayList* auxAL = NULL;
    int i;

    if(this!=NULL)
    {
        auxAL = al_newArrayList();
        if(auxAL!=NULL)
        {
            for(i=0; i<this->len(this); i++)
            {
                auxAL->add(auxAL,this->get(this,i));
            }
        }
    }
    return auxAL;
}

/** \brief Inserts the element at the specified position
 * \param this ArrayList* Pointer to arrayList
 * \param index int Index of the element
 * \param pElement void* Pointer to element
 * \return int Return (-1) if Error [this or pElement are NULL pointer or invalid index]
 *                  - ( 0) if OK
 */
int al_push(ArrayList* this,int index,void* pElement)
{
    int returnAux = -1;

    if(this!=NULL && pElement!=NULL && index>=0 && index<=(this->len(this)))
    {
        if(index==this->len(this)){
            this->add(this,pElement);
        }
        else{
        if(expand(this,index)==0)
        {
            this->set(this,index,pElement);
            returnAux=0;
        }
        }
    }
    return returnAux;
}

/** \brief Returns the index of the first occurrence of the specified element
 * \param this ArrayList* Pointer to arrayList
 * \param pElement void* Pointer to element
 * \return int Return (-1) if Error [this or pElement are NULL pointer] - (index to element) if OK
 */
int al_indexOf(ArrayList* this, void* pElement)
{
    int returnAux = -1;
    int i;
    if(this!=NULL && pElement!=NULL)
    {
        for(i=0; i<this->len(this); i++)
        {
            if(pElement == this->get(this,i))
            {
                returnAux = i;
                break;
            }
        }
    }
    return returnAux;
}

/** \brief Returns true if this list contains no elements.
 * \param this ArrayList* Pointer to arrayList
 * \return int Return (-1) if Error [this is NULL pointer] - (0) if Not Empty - (1) if is Empty
 */
int al_isEmpty(ArrayList* this)
{
    int returnAux = -1;

    if(this!=NULL)
    {
        returnAux = 1;
        if(this->len(this)!=0)
        {
            returnAux = 0;
        }
    }
    return returnAux;
}

/** \brief Remove the item at the given position in the list, and return it.
 * \param this ArrayList* Pointer to arrayList
 * \param index int Index of the element
 * \return int Return (NULL) if Error [this is NULL pointer or invalid index]
 *                  - ( element pointer) if OK
 */
void* al_pop(ArrayList* this,int index)
{
    void* returnAux = NULL;
    int removOK;

    if(this!=NULL && index>=0 && index<(this->len(this)))
    {
        returnAux = this->get(this,index);
        removOK = this->remove(this,index);
        if(removOK == -1)
        {
            returnAux = NULL;
        }
    }
    return returnAux;
}

/** \brief Returns a new arrayList with a portion of this between the specified
 *         fromIndex, inclusive, and toIndex, exclusive.
 * \param this ArrayList* Pointer to arrayList
 * \param from int Initial index of the element (inclusive)
 * \param to int Final index of the element (exclusive)
 * \return int Return (NULL) if Error [this is NULL pointer or invalid 'from' or invalid 'to']
 *                  - (pointer to new array) if OK
 */
ArrayList* al_subList(ArrayList* this,int from,int to)
{
    ArrayList* returnAux = NULL;
    int i;

    if(this!=NULL && from >= 0 && from<this->len(this) && from<to && to<=this->len(this))
    {
        returnAux = al_newArrayList();
        for(i=from;i<to;i++)
        {
            this->add(returnAux,this->get(this,i));
        }
    }
    return returnAux ;
}

/** \brief Returns true if this list contains all of the elements of this2
 * \param this ArrayList* Pointer to arrayList
 * \param this2 ArrayList* Pointer to arrayList
 * \return int Return (-1) if Error [this or this2 are NULL pointer]
 *                  - (0) if Not contains All - (1) if is contains All
 */
int al_containsAll(ArrayList* this,ArrayList* this2)
{
    int returnAux = -1;
    int i;
    void* auxElement;

    if(this!=NULL && this2!=NULL){
        returnAux = 1;
        for(i=0;i<this2->len(this2);i++){
            auxElement = this2->get(this2,i);
            if(this->contains(this,auxElement)==0){
                returnAux = 0;
            }
        }
    }
    return returnAux;
}

/** \brief Sorts objects of list, use compare pFunc
 * \param pList ArrayList* Pointer to arrayList
 * \param pFunc (*pFunc) Pointer to function to compare elements of arrayList
 * \param order int  [1] indicate UP - [0] indicate DOWN
 * \return int Return (-1) if Error [pList or pFunc are NULL pointer]
 *                  - (0) if OK
 */
int al_sort(ArrayList* this, int (*pFunc)(void*,void*), int order)
{
    int returnAux = -1;
    int i,j;
    void* aux;

    if(this!=NULL && pFunc!=NULL && (order==0 || order==1)){
        for(i=0;i<(this->len(this))-1;i++){
            for(j=i+1;j<this->len(this);j++){
                if(order == 1){
                    if(pFunc(this->get(this,i),this->get(this,j))>0){
                        aux = *(this->pElements+i);
                        *(this->pElements+i) = *(this->pElements+j);
                        *(this->pElements+j) = aux;
                    }
                }
                if(order == 0){
                    if(pFunc(this->get(this,i),this->get(this,j))<0){
                        aux = *(this->pElements+i);
                        *(this->pElements+i) = *(this->pElements+j);
                        *(this->pElements+j) = aux;
                    }
                }
            }
        }
        returnAux = 0;
    }
    return returnAux;
}


/** \brief Increment the number of elements in this in AL_INCREMENT elements.
 * \param this ArrayList* Pointer to arrayList
 * \return int Return (-1) if Error [this is NULL pointer or if can't allocate memory]
 *                  - (0) if OK
 */
int resizeUp(ArrayList* this)
{
    void** auxLista;
    int returnAux = -1;

    if(this!=NULL)
    {
        auxLista =(void**) realloc(this->pElements, sizeof(void*) * (this->reservedSize + AL_INCREMENT)) ;
        if(auxLista!=NULL)
        {
            this->pElements = auxLista;
            this->reservedSize += AL_INCREMENT;
            returnAux = 0;
        }
    }
    return returnAux;
}

/** \brief Decrement the number of elements in this in length of this + AL_INCREMENT elements.
 * \param this ArrayList* Pointer to arrayList
 * \return int Return (-1) if Error [this is NULL pointer or if can't allocate memory]
 *                  - (0) if OK
 */
int resizeDown(ArrayList* this)
{
    int returnAux = -1;
    void** auxAL;

    if(this!=NULL)
    {
        if((this->reservedSize)>(this->size)){
        auxAL = (void**) realloc(this->pElements,sizeof(void*)*(this->len(this)+AL_INCREMENT));
        }
        if(auxAL!=NULL)
        {
            this->pElements = auxAL;
            this->reservedSize = (this->len(this))+AL_INITIAL_VALUE;
            returnAux=0;
        }
    }
    return returnAux;
}

/** \brief  Expand an array list
 * \param this ArrayList* Pointer to arrayList
 * \param index int Index of the element
 * \return int Return (-1) if Error [this is NULL pointer or invalid index]
 *                  - ( 0) if OK
 */
int expand(ArrayList* this,int index)
{
    int returnAux = -1;
    int i;

    if(this!=NULL && index>=0 && index<=(this->len(this)))
    {
        if(this->len(this) == this->reservedSize)
        {
            resizeUp(this);
        }
        for(i=this->len(this)-1;i>=index;i--)
        {
            this->set(this,i+1,this->get(this,i));
        }
        returnAux = 0;
        this->size++;
    }
    return returnAux;
}

/** \brief  Contract an array list
 * \param this ArrayList* Pointer to arrayList
 * \param index int Index of the element
 * \return int Return (-1) if Error [this is NULL pointer or invalid index]
 *                  - ( 0) if OK
 */
int contract(ArrayList* this,int index)
{
    int returnAux = -1;
    int i;

    if(this!=NULL && index>=0 && index<=this->len(this)){
        for(i=index;i<(this->len(this))-1;i++)
        {
            this->set(this,i,this->get(this,i+1));
        }
        this->size--;
        resizeDown(this);
        returnAux = 0;
    }
    return returnAux;
}

