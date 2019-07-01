﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PersonSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person
                (
                    cmdArgs[0],
                    cmdArgs[1],
                    int.Parse(cmdArgs[2]),
                    double.Parse(cmdArgs[3])
                );
                persons.Add(person);
            }
            // Apply Bonus
            var bonus = double.Parse(Console.ReadLine());
            persons.ForEach(person => person.IncreaseSalary(bonus)); 

            // Print Them All
            persons.ForEach(p => Console.WriteLine(p.ToString()));

        }
    }
}
