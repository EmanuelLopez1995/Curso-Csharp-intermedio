﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1995, 1, 1));
            Console.WriteLine(person.GetBirthdate());
            Console.ReadLine();
        }
    }
}
