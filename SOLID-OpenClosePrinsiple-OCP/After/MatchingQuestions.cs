﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OpenClosePrinsiple_OCP.After
{
    public class MatchingQuestions : Question
    {

        public Dictionary<string, string> Rows { get; set; }
         = new Dictionary<string, string>();
        public override void Print()
        {
            Console.WriteLine($"{Title} [{Mark}]");

            foreach (var item in Rows)
            {
                Console.WriteLine($"{item.Key}            {item.Value}");
            }
        }

    }
}
