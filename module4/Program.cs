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

        //enum section
        #region
        //Cannot be put into a method
        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

        static void enumPractice()
        {
            //Region directive allows blocks of code to be collapsed
            int x = (int)Days.Sunday;
            int y = (int)Days.Friday;
            Console.WriteLine("Sun = {0}", x);
            Console.WriteLine("Fri = {0}", y);
        }
        #endregion

        //struct section
        #region
        //public - type is available to code running in any assembly
        //internal - type is available to any code within the same assembly, but not available to code in another assembly - default value
        //private - type is only available to code within the struct that contains it. Can only use private access modifier with nested structs
        public struct Coffee
        {
            public int Strength;
            public string Bean;
            public string CountryofOrigin;
            //other methods, fields, properties, and events
        }
        #endregion

        //Instantiating a struct
        #region
        //Must be inside a method
        static void structPractice()
        {
            Coffee coffeeStruct = new Coffee();
            coffeeStruct.Strength = 3;
            coffeeStruct.Bean = "Arabica";
            coffeeStruct.CountryofOrigin = "Kenya";
        }
        #endregion


        //Creating a constuctor within a struct
        #region
        public struct coffeeAgain
        {
            //Custom constructor
            public coffeeAgain(int strength, string bean, string countryOfOrigin)
            {
                this.Strength = strength;
                this.Bean = bean;
                this.CountryOfOrigin = countryOfOrigin;
            }

            //These statements declare the stuct fields and set the default values
            public int Strength;
            public string Bean;
            public string CountryOfOrigin;
            //Other methods, fields, properties, and events
        }
        #endregion

        //Calling a constructor
        #region
        //Call custom constructor by providing arguments for the three required parameters
        //coffeeAgain coffeeAgainAgain = new coffeeAgain(4, "Arabica", "Colombia");
        #endregion
    }
}

