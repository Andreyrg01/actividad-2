static void Main(string[] args)
{
    int[] ventas = new int[15];
    int v, max = ventas[0], min = ventas[0];
    for (int i = 0; i < 15; i++)
    {
        Console.Write("ingresos en ventas: ");
        v = int.Parse(Console.ReadLine());
        ventas[i] = v;
    }
    for (int i = 0; i < 15; i++)
    {
        if (ventas[i] > max)

            max = ventas[i];


        else if (ventas[i] < min)

            min = ventas[i];
    }

    Console.Write("\n\nLa mayor venta es: " + max);
    Console.Write("\n\nLa menor venta es: " + min);
    Console.ReadKey();

}
