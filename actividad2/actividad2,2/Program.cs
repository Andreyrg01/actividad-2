//actividad2,2 int main(void)
Console.WriteLine("ingrese el numero");
int number = int.Parse(Console.ReadLine());

for (int row = 1; row <= number; row++)
{
    Console.WriteLine($"(number) x {row} = {number * row }");
}