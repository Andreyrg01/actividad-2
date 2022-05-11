// actividad2.5
int num, rer;
string teclado;
Console.WriteLine("Introduce un numero");
teclado = Console.ReadLine();
num = int.Parse(teclado);


for (int i = 1; i <= 10; i++)
{
    rer = num * i;
    Console.WriteLine(num + " * " + i + " =" + rer);
}