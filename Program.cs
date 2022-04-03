using System;

namespace TrouveLeNombre
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Trop petit / Trop grand";
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Bienvenue sur mon premier programme C# !");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            bool continu = true;
            string answer;
            
            while (continu == true)
            {
                Random rand = new Random();
                int nb = rand.Next(1, 101);
                int error = 0;
                int usernb =  0;
                bool continuAsking = true;
              
                while (usernb != nb)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Entrez une valeur entre 1 et 100 !");
                    try
                    {
                        usernb = int.Parse(Console.ReadLine());

                        if (usernb > nb)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Trop Grand !");

                            error++;
                        }
                        else if (usernb < nb)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Trop Petit !");
                            error++;
                        }
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Une erreur a étée détecté veuillez recommencer.");
                    }
                }
                if (usernb == nb && error == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Bravo ! Du premier coup !");
                }
                else if (usernb == nb)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Bravo ! vous avez fait {error} erreurs");
                }
               
                while (continuAsking == true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Voulez vous recommencer ? O ou N");
                    answer = Console.ReadLine();
                    switch (answer)
                    {
                        case "Oui":
                        case "oui":
                        case "yes":
                        case "Yes":
                        case "o":
                        case "O":
                        case "y":
                        case "Y":
                            continu = true;
                            continuAsking = false;              
                            break;
                        case "no":
                        case "Non":
                        case "No":
                        case "non":
                        case "n":
                        case "N":
                            continu = false;
                            continuAsking = false;
                            break;
                    }
                }
                
            }
        }
    }
}