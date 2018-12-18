using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ecrivez votre âge svp");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Êtes vous un homme ou une femme");
            string sexe = Console.ReadLine();
            if (sexe == "homme"||sexe == "Homme")
            {
                if (age >=18)
                {
                    Console.WriteLine("Vous êtes un homme et vous êtes majeur.");

                }
                else
                {
                    Console.WriteLine("Vous êtes un homme et vous êtes mineur.");
                }
            }
            else
            {
                if (age>=18)
                {
                    Console.WriteLine("vous êtes une femme et vous êtes majeure.");
                }
                else
                {
                    Console.WriteLine("Vous êtes une femme et vous êtes mineure");
                }
            }
        }
    }
}
