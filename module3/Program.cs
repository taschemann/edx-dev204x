using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3
{
    class Program
    {
        static void Main(string[] args)
        {
            getStudentInformation();
            echoStudentDetails();
        }

        //Create method to get student information and assign it to a variable

        //Next, create methods such as PrintStudentDetails(string first, string last, string birthday)
        //that accepts the proper variables, and use an appropriate message to print the content to the console window.

        static void getStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's date of birth: ");
            string birthday = Console.ReadLine();
        }

        static void echoStudentDetails()
        {
            //Below variables don't have context. Find way to get info from getStudentInformation() to here.
            Console.WriteLine("{0} {1} was born on: {2}", firstName, lastName, birthday);
        }
    }
}
