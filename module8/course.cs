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

        //Student ArrayList
        private ArrayList students = new ArrayList();

        public ArrayList Students
        {
            get { return students; }
            set { students = value; }
        }

        //Basically the same as the MSDN code in the student class with some slight modifications
        public void ListStudent(ArrayList listObj)
        {
            foreach (student stud in listObj)
            {
                Console.WriteLine("First name of student{0} is " + stud.FirstName);
                Console.WriteLine("Last name of student{0} is " + stud.LastName);
            }
            //Print blank line
            Console.WriteLine();
        }
        #endregion
    }
}
