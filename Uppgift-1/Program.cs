using System;

namespace Uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namnLista = new();
            string input = " ";

            Console.WriteLine("Välkommnen, skriv in så många namn som du vill");
            Console.WriteLine("När du är nöjd så trycker du enter och skriver en tom rad för att skriva ut alla namn");

            while (input != "")
            {
                Console.WriteLine();
                Console.Write("Skriv in namn:");
                input = Console.ReadLine();
                namnLista.Add(input);
            }

            namnLista.Sort();

            Console.WriteLine("Namnen du skrev in i omvänd bokstavsordning");
            for (int i = namnLista.Count() - 1; i > 0; i--) 
            {
                Console.WriteLine(namnLista[i]);
            }
        }
    }
}