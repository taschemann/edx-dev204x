using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module5
{
    class course_class
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
        private string[] instructor;

        public string[] Instructor
        {
            get { return instructor; }
            set { instructor = value; }
        }

        private string[] students;

        public string[] Students
        {
            get { return students; }
            set { students = value; }
        }

        #endregion
    }
}
