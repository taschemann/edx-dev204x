using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student instantiation
            student individual = new student();
            //The int age is defined in the person class. This works because of inheritance.
            individual.age = 10;
            individual.height = 30;
            individual.weight = 210;

            //Copy and paste module 5 code to other classes before continuing. Need class hierarchy.
        }
    }
}
