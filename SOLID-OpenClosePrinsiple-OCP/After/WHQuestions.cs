using System;

namespace SOLID_OpenClosePrinsiple_OCP.After
{
    public class WHQuestions : Question
    {
        public override void Print()
        {
            Console.WriteLine($"{Title} [{Mark}]");
            Console.WriteLine("  _____________________________");
            Console.WriteLine("  _____________________________");
            Console.WriteLine("  _____________________________");
        }
    }
}
