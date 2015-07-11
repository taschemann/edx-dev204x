using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module8
{
    class student : person
    {
        //Student Count Variable
        private static int studentCount;

        public static int StudentCount
        {
            get { return studentCount; }
            set { studentCount = value; }
        }

        public int TakeTest()
        {
            throw new NotImplementedException();
        }

        //Stack to hold student grades
        private Stack grades = new Stack();

        public Stack Grades
        {
            get { return grades; }
            set { grades = value; }
        }

        //Method from the MSDN Stack doc
        public static void PrintValues(IEnumerable collection)
        {
            //for each object stored in the collection that is passed...
            foreach (Object obj in collection)
            {
                //Print the object value to console
                Console.Write(" {0}", obj);
            }
            //Print blank line
            Console.WriteLine();
        }
    }
}
