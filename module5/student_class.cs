using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module5
{
    class student_class
    {
        #region Variables and Properties
        //First Name
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        //Last Name
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        //Birth Date
        private string birthDate;

        public string BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        //First Address
        private string addressOne;

        public string AddressOne
        {
            get { return addressOne; }
            set { addressOne = value; }
        }

        //Second Address
        private string addressTwo;

        public string AddressTwo
        {
            get { return addressTwo; }
            set { addressTwo = value; }
        }

        //City
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        //State
        private string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        //Zip Code
        private int zipCode;

        public int ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        //Country
        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        #endregion
    }
}
