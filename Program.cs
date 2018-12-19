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
            string sex = Console.ReadLine();
            if (sex == "homme" || sex == "Homme")
            {
                if (age >= 18 && age < 120) // opérateur de comparaison pour rester dans la fourchette voulue
                {
                    Console.WriteLine("Vous êtes un homme et vous êtes majeur.");
                }
                else if (age < 18 && age >= 1)
                {
                    Console.WriteLine("Vous êtes un homme et vous êtes mineur.");
                }
                else // si la réponse est hors des valeurs voulues
                {
                    Console.WriteLine("Oops, il doit y avoir une erreur dans l'age");
                }
            }
            else if (sex == "femme" || sex == "Femme")
            {
                if (age >= 18 && age < 120) // opérateur de comparaison pour rester dans la fourchette voulue
                {
                    Console.WriteLine("vous êtes une femme et vous êtes majeure.");
                }
                else if (age < 18 && age >= 1)
                {
                    Console.WriteLine("Vous êtes une femme et vous êtes mineure");
                }
                else // si la réponse est hors des valeurs voulues
                {
                    Console.WriteLine("Oops, il doit y avoir une erreur dans l'age");
                }
            }
            // si la réponse est hors des valeurs voulues
            else{ Console.WriteLine("Oops, il doit y avoir une erreur dans le genre"); }
        }
    }
}

