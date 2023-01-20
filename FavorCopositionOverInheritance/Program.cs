using System;
using System.Collections.Generic;

namespace FavorCopositionOverInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var choice = 0;
                    Pizza pizza = new Pizza();
            do
            {
                Console.Clear();
                choice = ReadChoice(choice);
                if (choice >= 1 && choice <= 5)
                {
                    IGradiants gradiants = null;
                    switch (choice)
                    {
                        case 1:
                            gradiants = new Tomato();
                            break;
                        case 2:
                            gradiants = new Cheese();
                            break;
                        case 3:
                            gradiants = new Chicken();
                            break;
                        case 4:
                            gradiants = new Olives();
                            break;
                        case 5:
                            gradiants = new GreanPaper();
                            break;
                        default:
                            break;
                    }
                    pizza.AddGraiants(gradiants);
                    Console.WriteLine("Press any key to continue");
                }
                Console.ReadKey();
            } while (choice != 0);
            Console.WriteLine(pizza);
                Console.ReadKey();
        }
        private static int ReadChoice(int choice)
        {
            Console.WriteLine("Available Gradiants");
            Console.WriteLine("------------");
            Console.WriteLine("1. Tomato");
            Console.WriteLine("2. Cheese");
            Console.WriteLine("3. Chicken");
            Console.WriteLine("4. Olives");
            Console.WriteLine("5. Green Paper");
            Console.WriteLine("what do you need: ");
            if (int.TryParse(Console.ReadLine(), out int ch))
            {
                choice = ch;
            }

            return choice;
        }

      
    }
    class Pizza
    {
        public decimal Price => 10m;

        public List<IGradiants> gradiants { get; private set; } = new List<IGradiants>();

        public void AddGraiants(IGradiants gradiant)
        {
            gradiants.Add(gradiant);
        }

        public decimal CalculatePrice()
        {
            decimal total = this.Price;
            foreach (var item in gradiants)
            {
                total += item.Price;
            }
            return total;
        }


        public override string ToString()
        {
            var outout = $"{nameof(Pizza)}";
            outout += $"\n\tBase Price: {Price.ToString("C")}";
            foreach (var item in gradiants)
            {
                outout += $"\n\t Add: {item.Titel}, Price: {item.Price.ToString("C")}";
            }
            outout += "\n____________________________________";
            outout += $"\nTotal = {CalculatePrice().ToString("C")}";
            return outout;
        }

    }
    public interface IGradiants
    {
        public string Titel { get;}
        public decimal Price { get;}

    }
    public class Tomato : IGradiants
    {
        public string Titel => nameof(Tomato);

        public decimal Price => 1m;
    }
    public class Cheese : IGradiants
    {
        public string Titel => nameof(Cheese);

        public decimal Price => 3m;
    }
    public class Chicken : IGradiants
    {
        public string Titel => nameof(Chicken);

        public decimal Price => 5m;
    }
    public class Olives : IGradiants
    {
        public string Titel => nameof(Olives);

        public decimal Price => 1m;
    }

    public class GreanPaper : IGradiants
    {
        public string Titel => nameof(GreanPaper);

        public decimal Price => 1.5m;
    }

}
