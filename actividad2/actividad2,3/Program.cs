//actividad2.3
nt anumero = 0;
int suma = 0;


Console.WriteLine("Ingrese un numero natural");
int numero = int.Parse(Console.ReadLine());

while (anumero <= numero)
{
    suma = suma + anumero;
    anumero++;
}

Console.WriteLine(" el resultado de la suma es: " + suma);