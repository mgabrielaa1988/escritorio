#include <stdio.h>
#include <stdlib.h>

int main()
{
    float precioReal;
    int descuento;
    float descuentoEnDinero;
    float precioConDescuento;
    float iva;
    float total;

    printf("Ingrese el precio real: $");
    fflush(stdin);
    scanf("%f",&precioReal);
    printf("Ingrese el descuento %: ");
    fflush(stdin);
    scanf("%d",&descuento);

    descuentoEnDinero=(descuento*precioReal)/100;
    printf("\nDescuento: $%.2f",descuentoEnDinero);

    precioConDescuento=precioReal-descuentoEnDinero;
    printf("\nSubtotal: $%.2f",precioConDescuento);

    iva=precioConDescuento*0.21;
    printf("\nIVA: $%.2f",iva);

    total=precioConDescuento+iva;
    printf("\nTOTAL: $%.2f\n",total);

    return 0;
}
