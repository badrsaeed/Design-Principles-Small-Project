using SOLID_InterfaceSegregationPrinciple_ISP.After;
using System;
using System.Collections.Generic;

namespace SOLID_InterfaceSegregationPrinciple_ISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Before.Employee> employees = Before.Repository.LoadEmployees();
            IEnumerable<After.Employee> employees1 = After.Repository.LoadEmployees();

            //foreach (var emp in employees)
            //{
            //    Console.WriteLine(emp.PrintSalarySlip());
            //}
            foreach (var emp in employees)
            {
                Console.WriteLine(emp.PrintSalarySlip());
            }

        }
    }
}
