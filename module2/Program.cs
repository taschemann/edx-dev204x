using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start a new column on the vertical axis
            for (int x = 0; x < 8; x++)
            {
                //If x is an odd number...
                if (x % 2 == 1)
                {
                    //Start a new row on the horizontal axis with this loop
                    for (int y = 0; y < 8; y++)
                    {
                        //If y is an even number...
                        if (y % 2 == 0)
                        {
                            //Print "O"
                            Console.Write("O");
                        }
                        //If y is an odd number...
                        else
                        {
                            //Print "X"
                            Console.Write("X");
                        }
                    }
                }
                //If x is an even number...
                else
                {
                    //Start a new row on the horizontal axis with this loop
                    for (int y = 0; y < 8; y++)
                    {
                        //If y is an even number...
                        if (y % 2 == 0)
                        {
                            //Print "X" - Here is why the loop function wouldn't work - these loops have different outputs
                            Console.Write("X");
                        }
                        //If y is an odd number...
                        else
                        {
                            //Print "O"
                            Console.Write("O");
                        }
                    }
                }
                //Once the X's and O's are written and the row is exhausted, start a new line and do it again
                Console.Write("\n");
            }
        }
    }
}
