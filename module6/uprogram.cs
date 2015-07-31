using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module6
{
    class uprogram
    {
        #region Variables and Properties

        //Program Name
        private string programName;

        public string ProgramName
        {
            get { return programName; }
            set { programName = value; }
        }

        //Department Head
        private string departmentHead;

        public string DepartmentHead
        {
            get { return departmentHead; }
            set { departmentHead = value; }
        }

        //Degrees available
        private degree degrees;

        public degree Degrees
        {
            get { return degrees; }
            set { degrees = value; }
        }

        #endregion
    }
}
