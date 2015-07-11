using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region

            //Random class object to generate grade numbers for student objects
            Random gradeGen = new Random();
            //Instantiate a Course object called Programming with C#
            course programmingWithCSharp = new course();
            programmingWithCSharp.CourseName = "Programming in C#";

            //Instantiate three student objects and add them to the course object
            //Can't generate variable names dynamically because C# is strongly typed
            //For the sake of understanding ArrayLists, I'm just flat out defining student objects
            student student1 = new student();
            student student2 = new student();
            student student3 = new student();

            //This was giving me an "Object reference not set to an instance of an object" exception
            //Needed to initialize the stack object in the student class
            //try
            //{
            //  This was all done in the loop below which generates random numbers to put in the stack
            //    student1.Grades.Push(90);
            //    student1.Grades.Push(90);
            //    student1.Grades.Push(90);
            //    student1.Grades.Push(90);
            //    student1.Grades.Push(90);
            //}
            //catch (NullReferenceException ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Add 5 grades to the Stack in the each Student object
            for (int x = 0; x < 5; x++)
            {
                student1.Grades.Push(gradeGen.Next(50, 101));
                student2.Grades.Push(gradeGen.Next(50, 101));
                student3.Grades.Push(gradeGen.Next(50, 101));
            }

            Console.WriteLine("Values for student1 are: ");
            student.PrintValues(student1.Grades);
            Console.WriteLine("Values for student2 are: ");
            student.PrintValues(student2.Grades);
            Console.WriteLine("Values for student3 are: ");
            student.PrintValues(student3.Grades);

            //Add objects to ArrayList object
            //Can I do this with a loop? -- Nope. C# is strongly typed
            programmingWithCSharp.Students.Add(student1);
            programmingWithCSharp.Students.Add(student2);
            programmingWithCSharp.Students.Add(student3);

            //Adding some names for testing
            student1.FirstName = "John";
            student1.LastName = "Aarons";
            student2.FirstName = "Michael";
            student2.LastName = "Asher";
            student3.FirstName = "Chris";
            student3.LastName = "Barns";

            programmingWithCSharp.ListStudent(programmingWithCSharp.Students);

            #endregion
        }
    }
}