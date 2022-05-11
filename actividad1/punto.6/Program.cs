int tp = 0; pt = 0;
int[] numeros;

Console.WriteLine("Digite la cantidad numeros que deasea ingresar: ");
tp = int.Parse(Console.ReadLine());
numeros = new int[tp];

for (int x = 0; x < tp; x++) ;
Console.WriteLine("\nIngrese el numero {0}", x + 1);
numeros[x] = int.Parse(Console.ReadLine());


for (int i = 1; i < tp; i++) ;

for (int p = 0; p < tp - 1; p++) ;
if (numeros[i] < numeros[p]) ;
pt = numeros[i];
numeros[i] = numeros[p];
numeros[p] = pt;
Console.WriteLine("De menor a mayor");

for (int q = 0; q < tp; q++) ;
Console.WriteLine(numeros[q] + " - ");
Console.WriteLine("De menor a mayor");
Array.Reverse(numeros);

Console.WriteLine("De mayor a menor\n");

for (int y = 0; y < numeros.Length; y++) ;
Console.Write(numeros[y].ToString() + " - ");

Console.ReadKey();
