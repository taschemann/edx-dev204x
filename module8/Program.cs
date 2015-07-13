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
            student student1 = new student();
            student student2 = new student();
            student student3 = new student();

            //Add 5 grades to the Grades Stack in the each Student object
            for (int x = 0; x < 5; x++)
            {
                student1.GradesList.Push(gradeGen.Next(50, 101));
                student2.GradesList.Push(gradeGen.Next(50, 101));
                student3.GradesList.Push(gradeGen.Next(50, 101));
            }

            //Adding some names for testing
            student1.FirstName = "John";
            student1.LastName = "Aarons";
            student2.FirstName = "Michael";
            student2.LastName = "Asher";
            student3.FirstName = "Chris";
            student3.LastName = "Barns";

            //Add objects to Generic List object
            programmingWithCSharp.StudentList.Add(student1);
            programmingWithCSharp.StudentList.Add(student2);
            programmingWithCSharp.StudentList.Add(student3);

            //programmingWithCSharp.StudentList.Find();

            Console.WriteLine(programmingWithCSharp.StudentList.GetType());

            ////Adding some names for testing
            //student1.FirstName = "John";
            //student1.LastName = "Aarons";
            //student2.FirstName = "Michael";
            //student2.LastName = "Asher";
            //student3.FirstName = "Chris";
            //student3.LastName = "Barns";

            course.PrintValues(programmingWithCSharp.StudentList);

            #endregion
        }
    }
}