// See https://aka.ms/new-console-template for more information

namespace piramide
{
    class program
    {
        private static void Main(string[] args)
        {
            string t = "";
            for (int i = 1; i < 12;i++)
            {
                t = "";
                for (int j = 1; j <i;j++)
                {
                    t += (Convert.ToString(j) +"");
                }
                Console.WriteLine(t);
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}