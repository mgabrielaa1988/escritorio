#include <stdio.h>
#include <stdlib.h>

void funcionGraficar(int,int,int);

int main(){
    int a=6, b=4, c=3;
    funcionGraficar(a,b,c);

    return 0;
}

void funcionGraficar(int rango1,int rango2,int rango3){
    int i,mayor,flag=0;

    if(rango1 >= rango2 && rango1 >= rango3){
        mayor = rango1;
    }
    else{
        if(rango2 >= rango1 && rango2 >= rango3){
            mayor = rango2;
        }
        else{
        mayor = rango3;
        }
    }

    for(i=mayor; i>0; i--){
        if(i<= rango1){
            printf("\t*");
        }
        if(i<= rango2){
            flag=1;
            printf("\t*");
        }
        if(i<= rango3){
            if(flag==0)
                printf("\t\t*");
            if(flag==1)
                printf("\t*");
        }
        printf("\n");
    }
    printf("       <18    19-35    >35");
}
