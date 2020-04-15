#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include <conio.h>

int CANTUSU=2;
int CANTPROD=3;

typedef struct{
    int id;
    char nombre[21];
    float precio;
    int stock;
    int vendidos;
    int estado;
}eProducto;

typedef struct{
    char nombre[21];
    int password;
    int estado;
    eProducto productos[2];
}eUsuario;

int menu();
void inicializarUsuarios(eUsuario[],int);
void inicializarProductos(eProducto[],int);
void altaUsuario(eUsuario[],int);
int buscarLibreUsu(eUsuario[],int);
int buscarLibreProd(eProducto[],int);
int buscarUsuario(eUsuario[],char[],int);
int buscarPass(eUsuario[],int,int);
void modificarUsuario(eUsuario[],int);
void bajaUsuario(eUsuario[],int);
void publicarProd(eProducto[],eUsuario[],int,int);
void mostrarProd(eProducto);
void mostrarProds(eProducto[],int);
int buscarProdXID(eProducto[],int,int);
void modificarPubli(eProducto[],eUsuario[],int,int);
void cancelarPubli(eProducto[],eUsuario[],int,int);

int main()
{
    eUsuario usuarios[CANTUSU];

    menu();
   /* do{
        switch(menu()){
        case 1:

        case 2:
        case 3:
        case 4:
        case 5:
        case 6:
        case 7:
        case 8:
        case 9:
        case 10:

        }
    }while()
*/
    return 0;
}

int menu(){
    int opcion;
    system("cls");
    printf("-----MENU-----");
    printf("\n-1- Alta Usuario");
    printf("\n-2- Modificar Usuario");
    printf("\n-3- Baja Usuario");
    printf("\n-4- Publicar Producto");
    printf("\n-5- Modificar Publicacion");
    printf("\n-6- Cancelar Publicacion");
    printf("\n-7- Comprar Producto");
    printf("\n-8- Listar Publicaciones de Usuario");
    printf("\n-9- Listar Publicaciones");
    printf("\n-10-Listar Usuarios");
    printf("\n-0- Salir");
    printf("\n Ingrese la opcion: ");
    scanf("%d",&opcion);

    return opcion;
}

void inicializarUsuarios(eUsuario usuario[],int CANTUSU){
    int i;
    for(i=0;i<CANTUSU;i++){
        usuario[i].estado = 0;
    }
}

void inicializarProductos(eProducto producto[],int CANTPROD){
    int i;
    for(i=0;i<CANTPROD;i++){
        producto[i].estado = 0;
    }
}

int buscarLibreUsu(eUsuario usuario[],int CANTUSU){
    int i,indice=-1;
    for(i=0;i<CANTUSU;i++){
        if(usuario[i].estado == 0){
            indice = i;
            break;
        }
    }
    return indice;
}

int buscarLibreProd(eProducto producto[],int CANTPROD){
    int i,indice=-1;
    for(i=0;i<CANTPROD;i++){
        if(producto[i].estado == 0){
            indice =i;
            break;
        }
    }
    return indice;
}

int buscarUsuario(eUsuario usuario[],char auxNombre[],int CANTUSU){
    int i,aux;
    for(i=0;i<CANTUSU;i++){
        if(strcmp(usuario[i].nombre,auxNombre)==0){
            printf("Usuario ya existente");
            aux=i;
            break;
        }
        else{
            aux=-1;
        }
    }
    return aux;
}

void altaUsuario(eUsuario nuevoUsu[],int CANTUSU){
    system("cls");
    eUsuario nuevoUsuario;
    int indice,esta;
    char auxNombre[21];

    printf("\n-----ALTA USUARIO-----\n\n");

    indice=buscarLibreUsu(nuevoUsu,CANTUSU);

    if(indice==-1){
        printf("No hay mas lugar en memoria");
    }
    else{
        printf("Ingrese nuevo usuario: ");
        fflush(stdin);
        scanf("%[^\n]",auxNombre);
    }

    esta=buscarUsuario(nuevoUsu,auxNombre,CANTUSU);

    if(esta==-1){
        strcpy(auxNombre,nuevoUsuario.nombre);
        printf("\n - El password debe contener solo 5 numeros - \n");
        printf("Ingrese password: ");
        scanf("%d",&nuevoUsuario.password);
        nuevoUsu[indice]=nuevoUsuario;
        printf("\nAlta exitosa\n\n");
    }
}

void modificarUsuario(eUsuario usuario[],int CANTUSU){
    char auxNombre[21];
    int esta,auxPass;
    printf("-----MODIFICAR USUARIO-----");
    printf("Ingrese el nombre de usuario: ");
    fflush(stdin);
    scanf("%[^\n]",auxNombre);
    esta=buscarUsuario(usuario,auxNombre,CANTUSU);
    if(esta!=-1){
        printf("\nUsuario encontrado\n\n");
        printf("Ingrese password actual: ");
        scanf("%d",&auxPass);
        if(auxPass==usuario[esta].password){
            printf("\nPassword correcto\n");
            printf("Ingrese nuevo password: ");
            scanf("%d",&usuario[esta].password);
            printf("\nCambio de password exitoso\n\n");
        }
        else{
            printf("Password incorrecto");
        }

    }
}

void bajaUsuario(eUsuario usuario[],int CANTUSU){
    char auxNombre[21];
    char confirm;
    int esta,auxPass;
    printf("-----BAJA USUARIO-----");
    printf("Ingrese el nombre de usuario: ");
    fflush(stdin);
    scanf("%[^\n]",auxNombre);
    esta=buscarUsuario(usuario,auxNombre,CANTUSU);
    if(esta!=-1){
        printf("\nUsuario encontrado\n\n");
        printf("\nConfirma la baja?  s=si n=cancelar\n");
        fflush(stdin);
        scanf("%c",&confirm);
        if(confirm=='s'){
            printf("Ingrese password: ");
            scanf("%d",&auxPass);
            if(auxPass==usuario[esta].password){
                usuario[esta].estado=0;
                printf("\nBaja exitosa\n\n");
            }
            else{
                printf("Password incorrecto");
            }
        }
        if(confirm=='n'){
            printf("\nBaja cancelada\n\n");
        }
    }
    else{
        printf("Usuario no encontrado");
    }
}

void publicarProd(eProducto producto[],eUsuario usuario[],int CANTPROD,int CANTUSU){
    char auxNombre[21];
    int esta,auxPass,indice;
    char confirm;
    eProducto nuevoProd;
    printf("-----PUBLICAR PRODUCTO-----");
    printf("Usuario: ");
    fflush(stdin);
    scanf("%[^\n]",auxNombre);
    esta=buscarUsuario(usuario,auxNombre,CANTUSU);
    indice=buscarLibreProd(producto,CANTPROD);

    if(esta!=-1){
        printf("\nUsuario encontrado\n");
        printf("Ingrese password: ");
        scanf("%d",&auxPass);
        if(auxPass==usuario[esta].password){
            printf("Password correcto");
            printf("ID: ");
            scanf("%d",&nuevoProd.id);
            printf("Nombre del producto: ");
            fflush(stdin);
            scanf("%[^\n]",nuevoProd.nombre);
            printf("Precio: ");
            scanf("%f",&nuevoProd.precio);
            printf("Stock: ");
            scanf("%d",&nuevoProd.stock);
            printf("Cantidad vendida: ");
            printf("%d",&nuevoProd.vendidos);
            printf("Confirma la publicacion? s=si n=no");
            fflush(stdin);
            scanf("%c",&confirm);
            if(confirm=='s'){
                usuario[esta].productos[indice]=nuevoProd;
                printf("Publicacion exitosa");
            }
            if(confirm=='n'){
                printf("Publicacion cancelada");
            }
        }
        else{
            printf("Password incorrecto");
        }
    }
    else{
        printf("Usuario no encontrado");
    }
}

void mostrarProd(eProducto producto){
    printf("%d\t%s\t%.2f\t%d\t%d",producto.id,producto.nombre,producto.precio,producto.vendidos,producto.stock);
}
void mostrarProds(eProducto producto[],int CANTPROD){
    int i;
    printf("\n-----PRODUCTOS-----\n");
    printf("ID\tNOMBRE\tPRECIO\tVENDIDOS\tSTOCK\n");
    for(i=0;i<CANTPROD;i++){
        if(producto[i].estado!=0){
            mostrarProd(producto[i]);
        }
    }
}

int buscarProdXID(eProducto producto[],int auxID,int CANTPROD){
    int i,aux;
    for(i=0;i<CANTPROD;i++){
        if(auxID==producto[i].id){
            aux=i;
        }
        else{
            aux=-1;
            printf("No existe el producto");
        }
    }
    return aux;
}

void modificarPubli(eProducto producto[],eUsuario usuario[],int CANTPROD,int CANTUSU){
    char auxNombre[21];
    int auxPass,esta,modifico,hay;
    int nvoStock;
    float nvoPrecio;
    char confirm;

    printf("\n-----MODIFICAR PUBLICACION----- 'n\n");
    printf("Usuario: ");
    fflush(stdin);
    scanf("%[^\n]",auxNombre);
    esta=buscarUsuario(usuario,auxNombre,CANTUSU);

    if(esta!=-1){
        printf("\nUsuario encontrado\n");
        printf("Ingrese password: ");
        scanf("%d",&auxPass);
        if(auxPass==usuario[esta].password){
            printf("Password correcto");
            mostrarProds(usuario[esta].productos,CANTPROD);
            printf("Ingrese el id del producto: ");
            scanf("%d",&modifico);
            hay=buscarProdXID(usuario[esta].productos,modifico,CANTPROD);
            if(hay!=-1){
                printf("Ingrese nuevo precio: ");
                scanf("%f",&nvoPrecio);
                printf("Ingrese nuevo stock: ");
                scanf("%d",&nvoStock);
                printf("Confirma la moficacion: s=si n=no");
                fflush(stdin);
                scanf("%c",&confirm);
                if(confirm=='s'){
                    usuario[esta].productos[hay].precio=nvoPrecio;
                    usuario[esta].productos[hay].stock=nvoStock;
                    printf("Modificacion exitosa");
                }
                if(confirm=='n'){
                    printf("Modificacion cancelada");
                }
            }
            else{
                printf("ID erroneo");
            }
        }
    }
}

void cancelarPubli(eProducto producto[],eUsuario usuario[],int CANTPROD,int CANTUSU){
    char auxNombre[21];
    int auxPass,esta,cancelo,hay;
    char confirm;

    printf("\n-----CANCELAR PUBLICACION----- 'n\n");
    printf("Usuario: ");
    fflush(stdin);
    scanf("%[^\n]",auxNombre);
    esta=buscarUsuario(usuario,auxNombre,CANTUSU);

    if(esta!=-1){
        printf("\nUsuario encontrado\n");
        printf("Ingrese password: ");
        scanf("%d",&auxPass);
        if(auxPass==usuario[esta].password){
            printf("Password correcto");
            mostrarProds(usuario[esta].productos,CANTPROD);
            printf("Ingrese el id del producto: ");
            scanf("%d",&cancelo);
            hay=buscarProdXID(usuario[esta].productos,cancelo,CANTPROD);
            if(hay!=-1){
                printf("Confirma la cancelacion: s=si n=no");
                fflush(stdin);
                scanf("%c",&confirm);
                if(confirm=='s'){
                    usuario[esta].productos[hay].estado=0;
                    printf("Cancelacion exitosa");
                }
                if(confirm=='n'){
                    printf("Cancelacion anulada");
                }
            }
            else{
                printf("ID erroneo");
            }
        }
    }
}
