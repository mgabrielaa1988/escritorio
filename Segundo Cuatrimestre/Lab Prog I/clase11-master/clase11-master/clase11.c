#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#define CANT 50

typedef struct{
    int dia;
    int mes;
    int anio;
}eFecha;

typedef struct{
    int id;
    char descripcion[51];
    int isEmpty;
}eSector;

typedef struct{
    int legajo;
    char nombre[20];
    char sexo;
    float sueldo;
    eFecha fechaIngreso;
    int isEmpty;
}eEmpleado;

int menu();
void inicializarEmpleados(eEmpleado vec[],int tam);
int buscarLibre(eEmpleado vec[],int tam);
void mostrarEmpleado(eEmpleado vec);
void mostrarEmpleados(eEmpleado vec[],int tam);
int buscarEmpleado(eEmpleado vec[],int tam,int legajo);
void alta(eEmpleado vec[],int tam);
void baja(eEmpleado vec[],int tam);
void ordenar(eEmpleado vec[],int tam);
int menuModificacion();
void modificar(eEmpleado vec[],int tam);
//listar todos los empleados

int main()
{
    int salir = 0;

    eEmpleado gente[50];
    inicializarEmpleados(gente,50);
    eSector sectores[]={{1,"RRHH",0},{2,"Sistemas",0},{3,"Deposito",0}};

    do
    {
        switch(menu())
        {
        case 1:
            alta(gente,50);
            system("pause");
            break;
        case 2:
            baja(gente,50);
            system("pause");
            break;
        case 3:
            break;
        case 4:
            mostrarEmpleados(gente,50);
            system("pause");
            break;
        case 5:
            ordenar(gente,50);
            system("pause");
            break;
        case 6:
            salir = 1;
            break;
        default:
            printf("Opcion invalida...\n");
            system("pause");
            break;
        }
    }
    while(salir!=1);

    return 0;
}

int menu()
{
    int opcion;
    system("cls");
    printf("---ABM EMPLEADOS---\n");
    printf("-1- Alta\n");
    printf("-2- Baja\n");
    printf("-3- Modificacion\n");
    printf("-4- Listar\n");
    printf("-5- Ordenar\n");
    printf("-6- Salir\n\n");
    printf("Elija una opcion: ");

    scanf("%d",&opcion);
    system("cls");
    return opcion;
}

void inicializarEmpleados(eEmpleado vec[],int tam){
    int i;
    for(i=0;i<tam;i++){
        vec[i].isEmpty = 1;
    }
}

int buscarLibre(eEmpleado vec[],int tam){
    int i,indice=-1;
    for(i=0;i<tam;i++){
        if(vec[i].isEmpty == 1){
            indice = i;
            break;
        }
    }
    return indice;
}

void mostrarEmpleados(eEmpleado vec[],int tam){
    int i;
    printf("LEGAJO\tNOMBRE\tSEXO\tSUELDO\tFECHA INGRESO\n");
    for(i=0;i<tam;i++){
        if(vec[i].isEmpty!=1){
            mostrarEmpleado(vec[i]);
        }
    }
}

void mostrarEmpleado(eEmpleado vec){
    printf("%d\t%s\t%c\t%.2f\t%d/%d/%d\n",vec.legajo,vec.nombre,vec.sexo,vec.sueldo,vec.fechaIngreso.dia,vec.fechaIngreso.mes,vec.fechaIngreso.anio);
}

int buscarEmpleado(eEmpleado vec[],int tam,int legajo){
    int i,aux;
    for(i=0;i<tam;i++){
        if(vec[i].legajo == legajo){
            printf("Legajo existente\n");
            printf("LEGAJO\tNOMBRE\tSEXO\tSUELDO\tFECHA INGRESO\n");
            mostrarEmpleado(vec[i]);
            aux=i;
            break;
        }
        else{
            aux=-1;
        }
    }
    return aux;
}

void alta(eEmpleado vec[],int tam){
    eEmpleado nuevoEmpleado;
    int indice,auxLegajo,esta;

    printf("\t\t\tALTA\n");

    indice=buscarLibre(vec,tam);
    if(indice==-1){
        printf("No hay mas lugar en memoria");
    }
    else{
        printf("Legajo: ");
        scanf("%d",&auxLegajo);
    }
    esta=buscarEmpleado(vec,tam,auxLegajo);

    if(esta==-1){
        nuevoEmpleado.legajo=auxLegajo;
        printf("Nombre: ");
        fflush(stdin);
        scanf("%[^\n]",nuevoEmpleado.nombre);
        printf("Sexo: ");
        fflush(stdin);
        scanf("%c",&nuevoEmpleado.sexo);
        printf("Sueldo: ");
        scanf("%f",&nuevoEmpleado.sueldo);
        printf("Fecha de Ingreso\n");
        printf("Dia: ");
        scanf("%d",&nuevoEmpleado.fechaIngreso.dia);
        printf("Mes: ");
        scanf("%d",&nuevoEmpleado.fechaIngreso.mes);
        printf("Anio: ");
        scanf("%d",&nuevoEmpleado.fechaIngreso.anio);
        printf("\n\nUsted ingreso: \n");
        printf("LEGAJO\tNOMBRE\tSEXO\tSUELDO\tFECHA INGRESO\n");
        mostrarEmpleado(nuevoEmpleado);
    }
    vec[indice]=nuevoEmpleado;
    printf("\nAlta exitosa\n\n");
}

void baja(eEmpleado vec[],int tam){
    int auxLegajo,esta;
    char confirm;
    printf("\t\t\tBAJA\n");
    printf("Ingrese legajo: ");
    scanf("%d",&auxLegajo);
    esta=buscarEmpleado(vec,tam,auxLegajo);

    if(esta!=-1){
        printf("\nConfirma la baja?  s=si n=cancelar\n");
        fflush(stdin);
        scanf("%c",&confirm);
        if(confirm=='s'){
            vec[esta].isEmpty=1;
            printf("\nBaja exitosa\n\n");
        }
        if(confirm=='n'){
            printf("\nBaja cancelada\n\n");
        }
    }
    else{
        printf("\nLegajo inexistente\n\n");
    }
}

void ordenar(eEmpleado vec[],int tam){
    int i,j;
    eEmpleado auxVec;

    for(i=0;i<tam-1;i++){
        for(j=i+1;j<tam;j++){
            if(strcmp(vec[i].nombre,vec[j].nombre)){
            auxVec=vec[i];
            vec[i]=vec[j];
            vec[j]=auxVec;
            }
        }
    printf("\nOrdenamiento exitoso\n\n");
    }
}

int menuModificacion(){
    int opcion;
    system("cls");
    printf("---MODIFICACION---\n");
    printf("-1- Legajo\n");
    printf("-2- Nombre\n");
    printf("-3- Sexo\n");
    printf("-4- Sueldo\n");
    printf("-5- Fecha de Ingreso\n");
    printf("-6- Sector\n");
    printf("-7- Salir\n\n");
    printf("Elija una opcion: ");

    scanf("%d",&opcion);
    system("cls");
    return opcion;
}



void modificar(eEmpleado vec[],int tam){
    int salir = 0;
    int auxLegajo;
    do{
        switch(menuModificacion()){
        case 1:
            printf("Ingrese el legajo a modificar: ");
            scanf("%d",&auxLegajo);
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            break;
        case 6:
            break;
        case 7:
            salir=1;
            break;
        }
    }while(salir!=1);
}
