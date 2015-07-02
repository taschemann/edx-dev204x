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
            //arrayPractice();
            enumPractice();
        }

        static void arrayPractice()
        {
            char[,] multiArray = new char[3, 2] { { 'a', 'b' }, { 'c', 'd' }, { 'e', 'f' } };
            Console.WriteLine(multiArray[2, 1]);
        }
        
        //Cannot be put into a method
        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

        static void enumPractice()
        {
            #region
            int x = (int)Days.Sunday;
            int y = (int)Days.Friday;
            Console.WriteLine("Sun = {0}", x);
            Console.WriteLine("Fri = {0}", y);
            #endregion
        }

    }
}

