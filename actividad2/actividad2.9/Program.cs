// actividad2.9
class program
{
    //factorial (n) = n*(n-1)!
    public static double Fact(int num)
    {
        if (num == 0 || num== 1)
            return 1;
        return num * Fact(num - 1);
    }
    static void Main(String[] args)
    {
        int n;
        Console.Write("digite el valor de n: ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("el factorial de {0} es: {1}",n,Fact(n));
    }
}
