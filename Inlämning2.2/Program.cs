using System;
namespace inlämning2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt i meter hoppade Elin?");
            string elinlt = Console.ReadLine();
            double elinln = double.Parse(elinlt);
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Hur långt i meter hoppade Alma?");
            string almalt = Console.ReadLine();
            double almaln = double.Parse(almalt);
            Console.WriteLine("-----------------------------------");

            double resultat =  Math.Round(elinln - almaln, 3);
            Console.WriteLine("Elin hoppade " + resultat + " meter längre än vad Alma gjorde.");
            Console.ReadKey();
            

        }

    }

}
