using System;

namespace SOLID_OpenClosePrinsiple_OCP.After
{
    public class TrueFalseQuestions : Question
    {
        public override void Print()
        {
            Console.WriteLine($"{Title} [{Mark}]");
            Console.WriteLine("  1. T");
            Console.WriteLine("  2. F");
        }
    }
}
