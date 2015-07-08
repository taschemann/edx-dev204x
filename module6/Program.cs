using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Module 5 Code
            //Instantiate a Course object called Programming with C#
            course programmingWithCSharp = new course();
            programmingWithCSharp.CourseName = "Programming in C#";

            //Instantiate three student objects and add them to the course object
            programmingWithCSharp.Students = new student[3];
            for (int i = 0; i < 3; i++)
            {
                programmingWithCSharp.Students[i] = new student();
                student.StudentCount++;
            }

            student student1 = new student();
            try
            {
                student1.TakeTest();
            }
            catch (NotImplementedException notImplemented)
            {
                Console.WriteLine(notImplemented.Message);
            }

            //Instantiate at least one Teacher object
            teacher teacher1 = new teacher();

            //Add that Teacher object to your Course object - only 1 instructor for this module
            programmingWithCSharp.Instructor = new teacher[1] { teacher1 };

            //Instantiate a Degree object
            degree bachelorDegree = new degree();

            //Add your Course object to the Degree object
            bachelorDegree.Course = programmingWithCSharp;

            //Instantiate a UProgram object called Information Technology
            uprogram informationTechnology = new uprogram();

            //Add the Degree object to the UProgram object
            informationTechnology.Degrees = bachelorDegree;
            //These are added for readability and testing in output
            informationTechnology.ProgramName = "Information Technology";
            informationTechnology.Degrees.DegreeName = "ISAT";

            //Console Output
            Console.WriteLine("The name of the Program is {0} and the Degree is {1}.", informationTechnology.ProgramName, informationTechnology.Degrees.DegreeName);
            Console.WriteLine("The name of the Course is {0}.", informationTechnology.Degrees.Course.CourseName);
            Console.WriteLine("The number of students enrolled is {0}", student.StudentCount);

            #endregion

            #region Challenge Code
            //Create an instance of a Person object in code
            person person1 = new person();
            //Create an instance of a Student object in code
            student student2 = new student();
            //Assign the Student object to the Person object
            person1 = student2;
            //Access the properties of the Person instance you created
            person1.FirstName = "Thomas";
            
            //This doesn't work because person1 is an instance of the person class
            //When we assign an inherited class back to a parent object, we lose the
            //functionality of the inherited class.
                
            //person1.TakeTest();

            Console.WriteLine(person1.FirstName);
            #endregion
        }
    }
}
