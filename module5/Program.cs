﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate three student objects - This is done below in the for loop
            //studentClass student1 = new studentClass();
            //studentClass student2 = new studentClass();
            //studentClass student3 = new studentClass();

            //Instantiate a Course object called Programming with C#
            courseClass programmingWithCSharp = new courseClass();
            programmingWithCSharp.CourseName = "Programming in C#";

            //Instantiate three student objects
            //Add your three students to this Course object
            //This portion also takes advantage of the static variable studentClass.StudentCount
            programmingWithCSharp.Students = new studentClass[3];
            for (int i = 0; i < 3; i++)
            {
                programmingWithCSharp.Students[i] = new studentClass();
                //studentClass.FirstName = "Thomas";
                studentClass.StudentCount++;
                //Console.WriteLine(studentClass.FirstName);
            }                

            //Instantiate at least one Teacher object
            teacherClass teacher1 = new teacherClass();

            //Add that Teacher object to your Course object
            programmingWithCSharp.Instructor = new teacherClass[3] { teacher1, null, null };

            //Instantiate a Degree object, such as Bachelor
            degreeClass bachelorDegree = new degreeClass();

            //Add your Course object to the Degree object
            bachelorDegree.Course = programmingWithCSharp;

            //Instantiate a UProgram object called Information Technology
            UProgram informationTechnology = new UProgram();

            //Add the Degree object to the UProgram object
            informationTechnology.Degrees = bachelorDegree;

            informationTechnology.ProgramName = "Information Technology";
            informationTechnology.Degrees.DegreeName = "ISAT";

            //Using Console.WriteLine statements, output the following information to the console window:
            //The name of the program and the degree it contains
            //The name of the course in the degree
            //The count of the number of students in the course.

            Console.WriteLine("The name of the Program is {0} and the Degree is {1}.", informationTechnology.ProgramName, informationTechnology.Degrees.DegreeName );
            Console.WriteLine("The name of the Course is {0}.", informationTechnology.Degrees.Course.CourseName);
            Console.WriteLine("The number of students enrolled is {0}", studentClass.StudentCount );
        }
    }
}
