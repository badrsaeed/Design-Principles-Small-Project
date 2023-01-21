﻿using System;
using System.Collections.Generic;

namespace SOLID_OpenClosePrinsiple_OCP.After
{
    public class MultipleChoiceQuestions : Question
    {
        public List<string> Choices { get; set; } = new List<string>();
        public override void Print()
        {
            Console.WriteLine($"{Title} [{Mark}]");
            foreach (var choice in Choices)
            {
                Console.WriteLine($"  {choice}");
            }
        }
    }
}
