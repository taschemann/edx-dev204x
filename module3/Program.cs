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
            //Exception practice
            try
            {
                //Function that will never be implemented
                validateBirthday();
            }
            catch (NotImplementedException notImplemented)
            {
                Console.WriteLine(notImplemented.Message);
            }
            //End exception practice

            Console.WriteLine("Which option do you need to work with?");
            Console.WriteLine("\n 1. Student \n 2. Teacher \n 3. Validate Birthday \n 4. Exit \n");
            //Need exception here if user inputs an incorrect value
            string input = Console.ReadLine();
            int x;
            Int32.TryParse(input, out x);
            //
            switch (x)
            {
                case 1:
                    getStudentInformation();
                    break;
                case 2:
                    getTeacherInformation();
                    break;
                case 3:
                    validateBirthdayChallenge();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }

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

            Console.WriteLine("Do you want to print output?");
            string input = Console.ReadLine();

            if (input == "y" || input == "yes")
            {
                printDetails(firstName, lastName, birthday);
            }
            else
            {
                Environment.Exit(0);
            }

        }

        static void getTeacherInformation()
        {
            Console.WriteLine("Enter the teacher's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's date of birth: ");
            string birthday = Console.ReadLine();
        }

        static void printDetails(string firstName, string lastName, string birthday)
        {
            //Print details to console
            Console.WriteLine("{0} {1} was born on: {2}", firstName, lastName, birthday);
        }

        static void validateBirthday()
        {
            //Will never be implemented
            throw new NotImplementedException();
        }

        static void validateBirthdayChallenge()
        {
            //Challenge method
            //Research System.DateTime type. Modify birthday field for the student and/or teacher to ensure it used
            //a DateTime type. Create a try/catch block to catch invalid date entries and display a message to the user.
            throw new NotImplementedException();
        }
    }
}
