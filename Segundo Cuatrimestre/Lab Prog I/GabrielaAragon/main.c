#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#define PROVE 5
#define STOCK 10

typedef struct
{
    int codigo;
    char descripcion[51];
    int estado;
} eProveedores;

typedef struct
{
    int codigo;
    char descripcion[51];
    float importe;
    int stock;
    int proveedor;
    int estado;
} eProductos;

char menu();
char validarMenu(char);
char menuAlta();
char menuModificar();
char menuInformar();
char menuListar();
void inicializarProveedores(eProveedores[],int);
void inicializarStock(eProductos[],int);
int buscarLibreProvee(eProveedores[],int);
int buscarLibreProduc(eProductos[],int);
void altas(eProductos[],eProveedores[],int,int);
void altaProvee(eProveedores[],int);
int validarProveedor(eProveedores[],int,int);
void altaProduc(eProductos[],eProveedores[],int,int);
int validarFloat(char[]);
int buscarProducto(eProductos[],int,int);
void modificarProducto(eProductos[],int);
void bajaProducto(eProductos[],int);
void mostrarUnProd(eProductos prod);
void mostrarProductos(eProductos[],int);
void mostrarUnProveed(eProveedores proveed);
void informar(eProductos[],int);
void informarA(eProductos[],int);
void informarB(eProductos[],int);
void informarC(eProductos[],int);
void informarD(eProductos[],int);
void listar(eProductos[],eProveedores[],int,int);
void listarA(eProductos[],int);
void listarB(eProductos[],int);
void listarC(eProductos[],int);
void listarD(eProductos[],int);
void listarE(eProductos[],int);
void listarF(eProveedores[],eProductos[],int,int);
void listarG(eProveedores[],eProductos[],int,int);
void listarH(eProveedores[],eProductos[],int,int);
void listarI(eProveedores[],eProductos[],int,int);
void listarJ(eProveedores[],eProductos[],int,int);
void listarK(eProveedores[],eProductos[],int,int);
void listarL(eProveedores[],eProductos[],int,int);

int main()
{
    int salir =0;
    eProveedores proveedores[PROVE];
    eProductos productos[STOCK];
    inicializarProveedores(proveedores,PROVE);
    inicializarStock(productos,STOCK);

    do
    {
        switch(menu())
        {
        case '1':
            altas(productos,proveedores,STOCK,PROVE);
            system("pause");
            break;
        case '2':
            modificarProducto(productos,STOCK);
            system("pause");
            break;
        case '3':
            bajaProducto(productos,STOCK);
            system("pause");
            break;
        case '6':
            salir=1;
            break;
        default:
            printf("opcion no valida");
            break;
        }
    }
    while(salir!=1);
    return 0;
}

void inicializarProveedores(eProveedores proveed[],int tam)
{
    int i;
    for(i=0; i<tam; i++)
    {
        proveed[i].estado = 0;
        proveed[i].codigo = i+1;
    }
}

void inicializarStock(eProductos produc[],int tam)
{
    int i;
    for(i=0; i<tam; i++)
    {
        produc[i].estado = 0;
        produc[i].codigo = i+1;
    }
}

/** \brief Busca en un array de estructuras cual es la primera estructura vacia
 * \param vec[] Array de estructuras a ser recorrido
 * \param tam Entero que determina la cantidad de estructuras del array
 * \return indice Numero entero que devuelve: -1 en caso de que no haya estructuras vacias, ó el indice
 del vector en caso de que una estructura tenga su estado en 0(cero) por lo que se la considera vacia
 */
int buscarLibreProvee(eProveedores proveed[],int tam)
{
    int i,indice = -1;
    for(i=0; i<tam; i++)
    {
        if(proveed[i].estado == 0)
        {
            indice = i;
            break;
        }
    }
    return indice;
}

/** \brief Busca en un array de estructuras cual es la primera estructura vacia
 * \param vec[] Array de estructuras a ser recorrido
 * \param tam Entero que determina la cantidad de estructuras del array
 * \return indice Numero entero que devuelve: -1 en caso de que no haya estructuras vacias, ó el indice
 del vector en caso de que una estructura tenga su estado en 0(cero) por lo que se la considera vacia
 */
int buscarLibreProduc(eProductos produc[],int tam)
{
    int i,indice = -1;
    for(i=0; i<tam; i++)
    {
        if(produc[i].estado == 0)
        {
            indice = i;
            break;
        }
    }
    return indice;
}

/** \brief Muestra un menu de opciones y permite elegir una
 * \return opcion Devuelve un caracter cargado con la opcion elegida por el usuario
 */
char menu()
{
    char opcion;
    system("cls");
    printf("-------MENU-------\n\n");
    printf("-1- Altas\n");
    printf("-2- Modificar\n");
    printf("-3- Baja\n");
    printf("-4- Informar\n");
    printf("-5- Listar\n");
    printf("-6- Salir\n\n");
    printf("Elija una opcion: ");
    fflush(stdin);
    scanf("%c",&opcion);
    opcion = validarMenu (opcion);
    return opcion;
}

void mostrarUnProveed(eProveedores proveed){
    printf("COD: %d %s",proveed.codigo,proveed.descripcion);
}

void mostrarUnProd(eProductos prod)
{
    printf("COD:%d\t$ %.2f\t%d unid\tPROVEEDOR:%d\n",prod.codigo,prod.importe,prod.stock);
    printf("%s\n",prod.descripcion);
}

void mostrarProductos(eProductos produc[],int tam)
{
    int i;
    system("cls");
    printf("\n\n-------LISTA DE PRODUCTOS-------\n\n");
    for(i=0; i<tam; i++)
    {
        if(produc[i].estado!=0)
        {
            mostrarUnProd(produc[i]);
        }
    }
}

char menuAlta()
{
    char opcion;
    system("cls");
    printf("\n\n-------ALTAS-------\n\n");
    printf("-1- Alta Proveedores\n");
    printf("-2- Alta Productos\n");
    printf("-3- Salir\n");
    printf("Elija una opcion: ");
    fflush(stdin);
    scanf("%c",&opcion);
    while((int)opcion<49 || (int)opcion>51)
    {
        printf("\n  Opcion no valida...\n");
        printf("  Reingrese una opcion del menu ");
        fflush(stdin);
        scanf("%c",&opcion);
    }
    return opcion;
}

char menuInformar()
{
    char opcion;
    system("cls");
    printf("\n\n-------INFORMAR-------\n\n");
    printf("-A-Total y promedio de los importes, y cuantos productos superan ese promedio\n");
    printf("-B-Total y promedio de los importes, y cuantos productos no superan ese promedio\n");
    printf("-C-La cantidad de productos cuyo stock es menor o igual a 10\n");
    printf("-D-La cantidad de productos cuyo stock es mayor a 10\n");
    printf("-E-Salir");
    printf("Elija una opcion: ");
    fflush(stdin);
    scanf("%c",&opcion);
    opcion=toupper(opcion);
    while((int)opcion<65 || (int)opcion>69)
    {
        printf("\n  Opcion no valida...\n");
        printf("  Reingrese una opcion del menu ");
        fflush(stdin);
        scanf("%c",&opcion);
        opcion=toupper(opcion);
    }
    return opcion;
}

char menuListar()
{
    char opcion;
    system("cls");
    printf("\n\n-------LISTAR-------\n\n");
    printf("-A-Listado de los productos por importe(descendente) y descripcion(ascendente)\n");
    printf("-B-Todos los productos que en cantidad son menos o igual a 10\n");
    printf("-C-Todos los productos que en cantidad son mayor a 10\n");
    printf("-D-Todos los productos que superan el promedio de los importes\n");
    printf("-E-Todos los productos que no superan el promedio de los importes\n");
    printf("-F-Todos los proveedores cuya cantidad de producto es menor o igual a 10\n");
    printf("-G-Todos los productos provistos por cada proveedor\n");
    printf("-H-Todos los productos provistos por un proveedor determinado\n");
    printf("-I-El proveedor que provee mas productos, mostrando productos\n");
    printf("-J-El proveedor que provee menos productos, mostrando ese producto\n");
    printf("-K-El proveedor que provee el producto mas caro, mostrando ese producto\n");
    printf("-L-El proveedor que provee el producto mas barato, mostrando ese producto\n");
    printf("-M-Salir");
    printf("Elija una opcion: ");
    fflush(stdin);
    scanf("%c",&opcion);
    opcion=toupper(opcion);
    while((int)opcion<65 || (int)opcion>77)
    {
        printf("\n  Opcion no valida...\n");
        printf("  Reingrese una opcion del menu ");
        fflush(stdin);
        scanf("%c",&opcion);
        opcion=toupper(opcion);
    }
    return opcion;
}

int buscarProducto(eProductos produc[],int tam,int codigo)
{
    int i,encontrado=0;
    for(i=0; i<tam; i++)
    {
        if(produc[i].estado!=0 && produc[i].codigo==codigo)
        {
            encontrado=i;
            break;
        }
    }
    return encontrado;
}

/**
 * \brief Verifica si el valor recibido es numérico
 * \param texto Array con la cadena a ser analizada
 * \return 1 si es númerico y 0 si no lo es
 */
int esNumerico(char texto[])
{
    int i=0;
    while(texto[i] != '\0')
    {
        if(texto[i] < '0' || texto[i] > '9')
            return 0;
        i++;
    }
    return 1;
}

void altas(eProductos produc[],eProveedores proveed[],int tamStock,int tamProveed)
{
    int salir=0,i;
    do
    {
        switch(menuAlta())
        {
        case '1':
            altaProvee(proveed,tamProveed);
            system("pause");
            break;
        case '2':
            for(i=0;i<tamProveed;i++){
                if(proveed[i].estado!=0){
                   altaProduc(produc,proveed,tamStock,tamProveed);
                }
                else{
                    printf("No puede ingresar productos sin antes ingresar proveedor");
                }
            }
            system("pause");
            break;
        case '3':
            salir=1;
            break;
        default:
            printf("\n\nOpcion incorrecta\n\n");
            system("pause");
            break;
        }
    }
    while(salir!=1);
}

void bajaProducto(eProductos produc[],int tam)
{
    int auxCodigo,esta;
    char confirm;
    system("cls");
    printf("\n\n-------BAJA PRODUCTO-------\n\n");
    printf("Ingrese el codigo del producto: ");
    scanf("%d",&auxCodigo);
    esta=buscarProducto(produc,tam,auxCodigo);
    if(esta==0)
    {
        printf("\n\nCodigo no encontrado\n\n");
    }
    else
    {
        printf("\n\nProducto encontrado\n");
        mostrarUnProd(produc[esta]);
        printf("\n\nConfirma la baja? S/N\t");
        fflush(stdin);
        scanf("%c",&confirm);
        confirm=tolower(confirm);
        while(confirm!='s'&&confirm!='n')
        {
            printf("\n\nIngrese solo <S> o <N> \t");
            scanf("%c",&confirm);
            confirm=tolower(confirm);
        }
        if(confirm=='s')
        {
            produc[esta].estado=0;
        }
    }
}

char menuModificar()
{
    char opcion;
    printf("\n\nModificar:\n");
    printf("-1-Descripcion\n-2-Importe\n-3-Stock\n-4-Salir\nIngrese opcion: ");
    fflush(stdin);
    scanf("%c",&opcion);
    while((int)opcion<49 || (int)opcion>52)
    {
        printf("\n  Opcion no valida...\n");
        printf("  Reingrese una opcion del menu: \n");
        fflush(stdin);
        scanf("%c",&opcion);
    }
    return opcion;
}

void modificarProducto(eProductos produc[],int tam)
{
    int auxCodigo,esta;
    int salir=0;
    char auxDesc[51];
    char auxPrecio[15];
    int auxStock;
    system("cls");
    printf("\n\n-------MODIFICAR PRODUCTOS-------\n\n");
    printf("Ingrese el codigo del producto: ");
    scanf("%d",&auxCodigo);
    esta=buscarProducto(produc,tam,auxCodigo);
    if(esta==0)
    {
        printf("\n\nCodigo no encontrado\n");
    }
    else if(produc[esta].estado!=0 && esta!=0)
    {
        printf("\n\nProducto encontrado\n");
        mostrarUnProd(produc[esta]);
        system("pause");

        do
        {
            switch(menuModificar())
            {
            case '1':
                printf("Descripcion del Producto: ");
                fflush(stdin);
                gets(auxDesc);
                while(strlen(auxDesc)>51)
                {
                    printf("Descripcion extensa, solo puede ingresar 50 caracteres\nReingrese: \n");
                    fflush(stdin);
                    gets(auxDesc);
                }
                strcpy(produc[esta].descripcion,auxDesc);
                system("pause");
                break;
            case '2':
                printf("\n\nPrecio: $ ");
                fflush(stdin);
                gets(auxPrecio);
                while((validarFloat(auxPrecio)!=1)&&(strlen(auxPrecio)>15))
                {
                    printf("Valor no permitido, solo numeros y un punto\nReingrese: \n");
                    fflush(stdin);
                    gets(auxPrecio);
                }
                produc[esta].importe=atof(auxPrecio);
                system("pause");
                break;
            case '3':
                printf("\n\nCantidad: ");
                scanf("%d",&auxStock);
                while(isdigit(auxStock)!=1)
                {
                    printf("Valor no permitido, solo numeros enteros\nReingrese: \n");
                    scanf("%d",&auxStock);
                }
                produc[esta].stock=auxStock;
                system("pause");
                break;
            case '4':
                salir=1;
                system("pause");
                break;
            }
        }
        while(salir!=1);
    }

    printf("\n\nModificacion exitosa\n\n");
}

/** \brief Valida que el caracter recibido este entre los valores xx y xx de la tabla ASCII
y de no ser asi se le pide al usuario que reingrese una opcion valida
 * \param opcion Caracter a ser evaluado
 * \return opcion Caracter que esta entre los parametros pedidos
 */
char validarMenu (char opcion)
{
    while ((int)opcion<49 || (int)opcion>54)
    {
        printf("\n  Opcion no valida...\n");
        printf("  Reingrese una opcion del menu: ");
        scanf("%c",&opcion);
    }
    return opcion;
}

void altaProvee(eProveedores proveed[],int tam)
{
    char auxDesc[51];
    int indice;
    system("cls");
    printf("\n\n-------ALTA PROVEEDORES-------\n\n");
    indice=buscarLibreProvee(proveed,tam);
    if(indice==-1)
    {
        printf("\nEl sistema esta completo. No se puede dar de alta a nuevos proveedores.\n\n");
    }
    else
    {
        printf("Ingrese descripcion del Proveedor: ");
        fflush(stdin);
        scanf("%s",auxDesc);
        while(strlen(auxDesc)>51)
        {
            printf("Descripcion extensa, solo puede ingresar 50 caracteres:\nReingrese: \n");
            fflush(stdin);
            scanf("%s",auxDesc);
        }
    }
    strcpy(auxDesc,proveed[indice].descripcion);
    proveed[indice].estado =1;
    printf("\n\nAlta exitosa\n");
}

int validarProveedor(eProveedores proveed[],int aux,int tam){
    int i,esta=0;
    for(i=0;i<tam;i++){
        if(proveed[i].estado!=0 && aux==proveed[i].codigo){
            esta=1;
        }
    }
    return esta;
}

void altaProduc(eProductos produc[],eProveedores proveed[],int tamProd,int tamProv)
{
    char auxDesc[51];
    int indice,esta;
    char auxStock[5];
    char auxPrecio[15];
    int auxProv,i;
    system("cls");
    printf("\n-------ALTA PRODUCTOS-------\n\n");
    indice=buscarLibreProduc(produc,tamProd);
    if(indice==-1)
    {
        printf("\nEl sistema esta completo. No se puede dar de alta nuevos productos.\n\n");
    }
    else
    {
        printf("Descripcion del Producto: ");
        fflush(stdin);
        gets(auxDesc);
        while(strlen(auxDesc)>51)
        {
            printf("Descripcion extensa, solo puede ingresar 50 caracteres\nReingrese: \n");
            fflush(stdin);
            gets(auxDesc);
        }
        printf("\n\nPrecio: $ ");
        fflush(stdin);
        gets(auxPrecio);
        while((validarFloat(auxPrecio)!=1)&&(strlen(auxPrecio)>15))
        {
            printf("Valor no permitido, solo numeros y un punto\nReingrese: \n");
            fflush(stdin);
            gets(auxPrecio);
        }
        printf("\n\nCantidad: ");
        fflush(stdin);
        scanf("%s",auxStock);
        while(esNumerico(auxStock) && strlen(auxStock)>5)
        {
            printf("Valor no permitido, solo numeros enteros\nReingrese: \n");
            fflush(stdin);
            scanf("%s",auxStock);
        }
        printf("\n\nCodigos de Proveedor disponible: ");
        for(i=0;i<tamProv;i++){
            if(proveed[i].estado!=0){
                printf("%d\t%s",proveed[i].codigo,proveed[i].descripcion);
            }
        }
        printf("Proveedor elegido: ");
        scanf("%d",&auxProv);
        esta=validarProveedor(proveed,auxProv,tamProv);
        while(esta != 1){
            printf("Proveedor inexistente\nReingrese: ");
            scanf("%d",&auxProv);
            esta=validarProveedor(proveed,auxProv,tamProv);
        }
    }
    strcpy(auxDesc,produc[indice].descripcion);
    produc[indice].importe = atof(auxPrecio);
    produc[indice].stock = atoi(auxStock);
        produc[indice].proveedor = auxProv;
    produc[indice].estado = 1;
    printf("\n\nAlta exitosa\n\n");
}

/** \brief Verifica si el valor recibido puede ser un flotante
 * \param flotante Array de caracteres a verificar
 * \return correcto Devuelve 1(uno) si la cadena posee numeros,un punto y ningun espacio
 * Devuelve 0(cero) si la cadena tiene mas de un punto, espacios, y otro caracter que no sea un numero
 */
int validarFloat(char flotante[])
{
    int i=0;
    int contadorPuntos=0;

    while(flotante[i]!= '\0')
    {
        if((flotante[i] == ' ') && (flotante[i] != '.') && (flotante[i] < '0' || flotante[i] > '9'))
        {
            return 0;
        }
        if(flotante[i] == '.')
        {
            contadorPuntos++;
        }
        i++;
    }
    if(contadorPuntos==1)
    {
        return 1;
    }

    return 0;
}

void informar(eProductos produc[],int tam)
{
    int salir=0;
    do{
            switch(menuInformar()){
            case 'A':
                informarA(produc,tam);
                break;
                case 'B':
                    informarB(produc,tam);
                break;
                case 'C':
                    informarC(produc,tam);
                break;
                case 'D':
                    informarD(produc,tam);
                break;
                case 'E':
                    salir=1;
                    break;
            }
    }while(salir!=1);
}

void informarA(eProductos produc[],int tam){
    float total=0,promedio;
    int cantSupProm=0,i,contador=0;
    for(i=0;i<tam;i++){
        if(produc[i].estado!=0){
            total=total+produc[i].importe;
            contador++;
        }
    }
    promedio=total/contador;
    printf("-A-Total y promedio de los importes, y cuantos productos superan ese promedio\n");
    printf("TOTAL: %.2f",total);
    printf("PROMEDIO: %.2f",promedio);
    for(i=0;i<tam;i++){
        if(produc[i].estado!=0 && produc[i].importe>promedio){
            cantSupProm=cantSupProm+produc[i].stock;
        }
    }
    printf("CANTIDAD: %d",cantSupProm);
}

void informarB(eProductos produc[],int tam){
    float total=0,promedio;
    int cantMenProm=0,i,contador=0;
    for(i=0;i<tam;i++){
        if(produc[i].estado!=0){
            total=total+produc[i].importe;
            contador++;
        }
    }
    promedio=total/contador;
    printf("-B-Total y promedio de los importes, y cuantos productos no superan ese promedio\n");
    printf("TOTAL: %.2f",total);
    printf("PROMEDIO: %.2f",promedio);
    for(i=0;i<tam;i++){
        if(produc[i].estado!=0 && produc[i].importe<promedio){
            cantMenProm=cantMenProm+produc[i].stock;
        }
    }
    printf("CANTIDAD: %d",cantMenProm);
}

void informarC(eProductos produc[],int tam){
    int i,cantidad=0;
    for(i=0;i<tam;i++){
        if(produc[i].estado!=0 && produc[i].stock<=10){
            cantidad=produc[i].stock;
        }
    }
    printf("-C-La cantidad de productos cuyo stock es menor o igual a 10\n");
    printf("CANTIDAD: %d",cantidad);
}

void informarD(eProductos produc[],int tam){
    int i,cantidad=0;
    for(i=0;i<tam;i++){
        if(produc[i].estado!=0 && produc[i].stock>10){
            cantidad=produc[i].stock;
        }
    }
    printf("-D-La cantidad de productos cuyo stock es mayor a 10\n");
    printf("CANTIDAD: %d",cantidad);
}

void listar(eProductos produc[],eProveedores proveed[],int tamProd,int tamProv){
    int salir=0;
    do{
        switch(menuListar()){
        case 'A':
            break;
            case 'B':
            break;
            case 'C':
            break;
            case 'D':
            break;
            case 'E':
            break;
            case 'F':
            break;
            case 'G':
            break;
            case 'H':
            break;
            case 'I':
            break;
            case 'J':
            break;
            case 'K':
            break;
        }
    }while(salir!=1);
}

void listarA(eProductos produc[],int tam){
    int i,j;
    eProductos auxProd;
    printf("\n-A-Listado de los productos por importe(descendente) y descripcion(ascendente)\n");
    for(i=0;i<tam-1;i++){
        for(j=i+1;j<tam;j++){
            if(produc[i].estado!=0 && produc[j].estado!=0 && produc[i].importe>produc[j].importe){
                auxProd = produc[i];
                produc[i] = produc[j];
                produc[j] = produc[i];
            }
            else if(produc[i].estado!=0 && produc[j].estado!=0 && produc[i].importe == produc[j].importe && stricmp(produc[i].descripcion,produc[j].descripcion)>0){
                auxProd = produc[i];
                produc[i] = produc[j];
                produc[j] = produc[i];
            }
        }
}
mostrarProductos(produc,tam);
}

void listarB(eProductos produc[],int tam){
    int i;
    printf("\n-B-Todos los productos que en cantidad son menos o igual a 10\n");
    for(i=0;i<tam;i++){
        if(produc[i].estado!=0 && produc[i].stock<=10){
            mostrarUnProd(produc[i]);
        }
    }
}

void listarC(eProductos produc[],int tam){
    int i;
    printf("\n-C-Todos los productos que en cantidad son mayor a 10\n");
    for(i=0;i<tam;i++){
        if(produc[i].estado!=0 && produc[i].stock>10){
            mostrarUnProd(produc[i]);
        }
    }
}

void listarD(eProductos produc[],int tam){
    float promedio,acumulador=0;
    int i,contador=0;
    for(i=0;i<tam;i++){
        if(produc[i].estado!=0){
            acumulador=acumulador+produc[i].importe;
            contador++;
        }
    }
    promedio=acumulador/contador;
    printf("-D-Todos los productos que superan el promedio de los importes\n");
    for(i=0;i<tam;i++){
        if(produc[i].estado!=0 && produc[i].importe>promedio){
            mostrarUnProd(produc[i]);
        }
    }
}

void listarE(eProductos produc[],int tam){
    float promedio,acumulador=0;
    int i,contador=0;
    for(i=0;i<tam;i++){
        if(produc[i].estado!=0){
            acumulador=acumulador+produc[i].importe;
            contador++;
        }
    }
    promedio=acumulador/contador;
printf("-E-Todos los productos que no superan el promedio de los importes\n");
for(i=0;i<tam;i++){
        if(produc[i].estado!=0 && produc[i].importe<promedio){
            mostrarUnProd(produc[i]);
        }
    }
}

void listarF(eProveedores proveed[],eProductos produc[],int tamProv,int tamProd){
    int i,j;
    printf("-F-Todos los proveedores cuya cantidad de producto es menor o igual a 10\n");
    for(i=0;i<tamProv;i++){
        if(proveed[i].estado!=0){
            for(j=0;j<tamProd;j++){
                if(produc[j].estado!=0 && proveed[i].codigo==produc[j].proveedor && produc[j].stock<=10){
                    mostrarUnProveed(proveed[i]);
                }
            }
        }
    }
}

void listarG(eProveedores proveed[],eProductos produc[],int tamProv,int tamProd){
    int i,j;
    printf("-G-Todos los productos provistos por cada proveedor\n");
    for(i=0;i<tamProv;i++){
        if(proveed[i].estado!=0){
            mostrarUnProveed(proveed[i]);
            for(j=0;j<tamProd;j++){
                if(produc[j].estado!=0 && produc[j].proveedor==proveed[i].codigo){
                    mostrarUnProd(produc[j]);
                }
            }
        }
    }
}

void listarH(eProveedores proveed[],eProductos produc[],int tamProv,int tamProd){
    int auxCodigo,i,j;
    printf("\nIngrese el codigo del proveedor a mostrar: ");
    scanf("%d",&auxCodigo);
    printf("\n-H-Todos los productos provistos por un proveedor determinado\n");
    for(i=0;i<tamProv;i++){
        if(proveed[i].estado!=0){
            for(j=0;j<tamProd;j++){
                    if(produc[j].estado!=0 && proveed[i].codigo==produc[j].proveedor && proveed[i].codigo==auxCodigo){
                mostrarUnProd(produc[j]);
                    }
            }
        }
    }
}

void listarI(eProveedores proveed[],eProductos produc[],int tamProv,int tamProd){
    int contador=0,mayor=0,i,j;
    eProveedores auxProveed;
    for(i=0;i<tamProv;i++){
        if(proveed[i].estado!=0){
            for(j=0;j<tamProd;j++){
                if(produc[j].estado!=0 && produc[j].proveedor==proveed[i].codigo){
                    contador = contador+produc[j].stock;
                }
            }
            if(contador>mayor){
                mayor=contador;
                auxProveed =proveed[i];
            }
        }
    }
 printf("-I-El proveedor que provee mas productos, mostrando productos\n");
mostrarUnProveed(auxProveed);
for(i=0;i<tamProd;i++){
    if(produc[i].estado!=0 && auxProveed.codigo==produc[i].proveedor){
        mostrarUnProd(produc[i]);
    }
}
 }
void listarJ(eProveedores proveed[],eProductos produc[],int tamProv,int tamProd){
printf("-J-El proveedor que provee menos productos, mostrando ese producto\n");}
void listarK(eProveedores proveed[],eProductos produc[],int tamProv,int tamProd){
printf("-K-El proveedor que provee el producto mas caro, mostrando ese producto\n");}
void listarL(eProveedores proveed[],eProductos produc[],int tamProv,int tamProd){
    printf("-L-El proveedor que provee el producto mas barato, mostrando ese producto\n");
}
