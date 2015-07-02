using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module4
{
    class Program
    {
        static void Main(string[] args)
        {
            arrayPractice();
        }

        static void arrayPractice()
        {
            char[,] multiArray = new char[3, 2] { { 'a', 'b' }, { 'c', 'd' }, { 'e', 'f' } };
            Console.WriteLine(multiArray[2, 1]);
        }
    }
}
