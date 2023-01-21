
using SOLID_OpenClosePrinsiple_OCP.After;
using System;

namespace SOLID_OpenClosePrinsiple_OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quiz quiz = new After.Quiz(QuestionsBank.Generate());
            quiz.Print();
            Console.ReadKey();
        }
    }
}
