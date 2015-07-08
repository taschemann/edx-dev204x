using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module6
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
        
    }
}
