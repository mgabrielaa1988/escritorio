#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>

int main()
{
    int nota;
    int edad;
    char sexo;
    int i;
    float promedio;
    int acumuladorNota=0;
    int notaBaja;
    char sexoNotaBaja;
    int flag=0;
    int varonMayorAprob=0;
    int masJoven;
    char sexoMasJoven;
    int notaMasJoven;
    int edadPriMujer;
    int notaPriMujer;

    for(i=0;i<5;i++){
    printf("Ingrese la nota: ");
    scanf("%d",&nota);
    while(nota<0||nota>10){
        printf("Nota invalida. Reingrese: ");
        scanf("%d",&nota);
    }

    printf("Ingrese la edad: ");
    scanf("%d",&edad);
    while(edad<1||edad>100){
        printf("Edad invalida. Reingrese: ");
        scanf("%d",&edad);
    }

    printf("Ingrese <f> para femenino o <m> para masculino: ");
    fflush(stdin);
    scanf("%c",&sexo);
    sexo=tolower(sexo);
    while(sexo!='f'&&sexo!='m'){
        printf("Solo se permiten los caractares <f> y <m>");
        printf("Reingrese: ");
        fflush(stdin);
        scanf("%c",&sexo);
        sexo=tolower(sexo);
    }

    acumuladorNota=acumuladorNota+nota;

    if(nota<notaBaja||flag==0){
        notaBaja=nota;
        sexoNotaBaja=sexo;
    }

    if(sexo=='m'&&edad>18&&nota>=6){
        varonMayorAprob++;
    }

    if(edad<masJoven||flag==0){
        masJoven=edad;
        sexoMasJoven=sexo;
        notaMasJoven=nota;
    }

    if(sexo=='f'&&flag==0){
        edadPriMujer=edad;
        notaPriMujer=nota;
        flag=1;
    }

    }

    promedio=(float)acumuladorNota/5;

    printf("\nEl promedio de la notas totales es: %.2f",promedio);
    printf("\nLa nota mas baja es: %d y es de sexo <%c>",notaBaja,sexoNotaBaja);
    printf("\nCantidad de varones mayores de 18 con nota mayor o igual a 6: %d",varonMayorAprob);
    printf("\nEl sexo de la persona mas joven es <%c> y su nota es: %d",sexoMasJoven,notaMasJoven);
    if(flag==1){
        printf("\nLa primera mujer tiene %d anios y su nota es: %d",edadPriMujer,notaPriMujer);
    }
    else{
        printf("\nNo se ingreso ninguna mujer");
    }

    return 0;
}
