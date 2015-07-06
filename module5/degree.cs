using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module5
{
    class degreeClass
    {
        #region Variables and Properties
        //Degree Name
        private string degreeName;

        public string DegreeName
        {
            get { return degreeName; }
            set { degreeName = value; }
        }

        //Credits Required
        private int creditsRequired;

        public int CreditsRequired
        {
            get { return creditsRequired; }
            set { creditsRequired = value; }
        }
        #endregion
    }
}
