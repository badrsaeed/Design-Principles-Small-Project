using System;
using System.Threading;

namespace DesignPrinciples_Evaluate_What_Varies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = Pizza.Order("chicken");
            Console.WriteLine(pizza);
            Console.ReadKey();
        }
    }

    class Pizza
    {
        public virtual string Title => $"{nameof(Pizza)}";
        public virtual decimal Price => 10m;


        private static Pizza Create(string type)
        {
            Pizza pizza;

            if (type.Equals(PizzaConstants.Cheese))
                pizza = new Cheese();
            else if (type.Equals(PizzaConstants.Chicken))
                pizza = new Chicken();
            else
                pizza = new Vegeterian();
            return pizza;
        }
        public static Pizza Order(string type)
        {
            Pizza pizza = Create(type);

            Preparing();
            Coocking();
            CutiingAndBoxing();

            return pizza;
        }
        private static void Preparing()
        {
            Console.Write("Preparing...");
            Thread.Sleep(1000);
            Console.WriteLine("Completed");
        }
        private static void Coocking()
        {
            Console.Write("Coocking...");
            Thread.Sleep(1000);
            Console.WriteLine("Completed");
        }
        private static void CutiingAndBoxing()
        {
            Console.Write("Cutiing and Boxing...");
            Thread.Sleep(1000);
            Console.WriteLine("Completed");
        }
        public override string ToString()
        {
            return $"{this.Title}\n\tPrice = {this.Price}$";
        }
    }

    internal class Vegeterian : Pizza
    {
        public override string Title => $"{nameof(Vegeterian)} {base.Title}";
        public override decimal Price => base.Price + 4m;
    }

    class Cheese : Pizza
    {
        public override string Title => $"{nameof(Cheese)} {base.Title}";
        public override decimal Price => base.Price + 3m;
    }

    class Chicken : Pizza
    {
        public override string Title => $"{nameof(Chicken)} {base.Title}";
        public override decimal Price => base.Price + 10m;
    }
}
