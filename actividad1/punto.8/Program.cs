
#include<stdio.h>

int main()

{

    int n;

    float total;

    printf(«Ingresa el numero de llantas a comprar\n»);

    scanf(«% d», &n);

    if (n < 5)
    {

        total = n * 240000;

    }

    else
    {

        total = n * 22100;

    }

    printf(«\nNumero de llantas compradas: % d», n);

    printf(«\nTotal a pagar: $% .1f», total);

    return 0;