using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module8
{
    class course
    {
        #region Variables and Properties

        //Course Name
        private string courseName;

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        //Credits Received
        private int credits;

        public int Credits
        {
            get { return credits; }
            set { credits = value; }
        }

        //Duration of class in weeks
        private int lengthInWeeks;

        public int LengthInWeeks
        {
            get { return lengthInWeeks; }
            set { lengthInWeeks = value; }
        }

        //Instructor
        private teacher[] instructor;

        public teacher[] Instructor
        {
            get { return instructor; }
            set { instructor = value; }
        }

        //Student Generic List
        private List<student> studentList = new List<student>();

        public List<student> StudentList
        {
            get { return studentList; }
            set { studentList = value; }
        }

        //Basically the same as the MSDN code in the student class but modified for generic list use
        //Method must be classified as generic to be able to pass a generic list as an argument - NOPE. That's not how it works.
        public static void PrintValues(List<student> genList)
        {
            int iterate = 1;
            foreach (student studObj in genList)
            {
                Console.WriteLine();
                Console.WriteLine("Object {0} passed from generic list is type {1}", iterate, studObj.GetType());
                Console.WriteLine("First name of object {0} passed to generic list is {1}", iterate, studObj.FirstName);
                Console.WriteLine("Last name of object {0} passed to generic list is {1}", iterate, studObj.LastName);
                Console.WriteLine();
                iterate++;
            }
            //Print blank line
            Console.WriteLine();
        }

        //Prints student object grade values from the generic list object
        public static void PrintGradeValues(List<student> genList)
        {
            int iterate = 1;
            foreach (student studObj in genList)
            {
                Console.WriteLine();
                Console.WriteLine("Grade of object {0} passed to generic list is {1}", iterate, studObj.GradesList.Pop());
                iterate++;
            }
            //Print blank line
            Console.WriteLine();
        }
        #endregion
    }
}
