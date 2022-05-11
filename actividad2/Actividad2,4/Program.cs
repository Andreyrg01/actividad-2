//Actividad2,4
//include <stdio.h>

float promedio(int [] valores, int cantidad)
{
    int i;
    float suma = 0 ;

    for (i = 0; i < cantidad; ++i)
        suma += valores[i];

    return suma / (float)cantidad;
}

printf("El promedio de %s es %.1f\n",
       nombre,
       promedio(n));

        printf("Desea calcular mas promedios (si/no)? ");
        scanf("%s", opcion);

    } while (opcion[0] == 's' || opcion[0] == 'S');

    return 0;
}