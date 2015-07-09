using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            firstName = "John";
            string lastName;
            lastName = "Johnson";
            string birthDate;
            birthDate = "December 1, 1990";
            string addressOne;
            addressOne = "123 Your Driveway";
            string addressTwo;
            addressTwo = null;
            string city;
            city = "St. Louis";
            string state;
            state = "MO";
            int zipCode;
            zipCode = 63101;
            string country;
            country = "USA";

            Console.WriteLine("First Name: \t\n" + firstName);
            Console.WriteLine("Last Name: \t" + lastName);
            Console.WriteLine("Birthday: \t" + birthDate);
            Console.WriteLine("Address One: \t" + addressOne);
            Console.WriteLine("Address Two: \t" + addressTwo);
            Console.WriteLine("City: \t" + city);
            Console.WriteLine("State: \t" + state);
            Console.WriteLine("ZIP: \t" + zipCode);
            Console.WriteLine("Country: \t" + country);

            /*
             * Challenge Code
            Console.WriteLine("Please enter your first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Please enter your date of birth: ");
            birthDate = Console.ReadLine();
            Console.WriteLine("Please enter your first address: ");
            addressOne = Console.ReadLine();
            Console.WriteLine("Please enter your second address: ");
            addressTwo = Console.ReadLine();
            Console.WriteLine("Please enter your City: ");
            city = Console.ReadLine();
            Console.WriteLine("Please enter your State: ");
            state = Console.ReadLine();
            Console.WriteLine("Please enter your ZIP Code: ");
            zipCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your Country: ");
            country = Console.ReadLine();
             * */
        }
    }
}
