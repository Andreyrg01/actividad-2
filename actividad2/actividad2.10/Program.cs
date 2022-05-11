// actividad2.10
int x, y, altura;
Console.Write("ingresar la altura de z: ");
altura = int.Parse(Console.ReadLine());
Console.WriteLine("*****");

for (x = 1; x <= altura; x++)
{
    for (y = altura - x; y > 0; y--)
    {
        Console.Write(' ');
    }
    for (y = 1; y < x; y++)
    {
        Console.Write("*****");
        
    }
    Console.WriteLine("    *");
    {
        Console.WriteLine("   *  ");
        {
            Console.WriteLine("  *  ");
            {
                Console.WriteLine(" *   ");
                {
                    Console.WriteLine("*****");
                }
            }
        }
    }
}
