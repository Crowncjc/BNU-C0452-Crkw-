using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        // Constants (Grade Boundaries)
        public const int LowestF = 0;
        public const int LowestD = 40;
        public const int LowestC = 50;
        public const int LowestB = 60;
        public const int LowestA = 70;
        public const int MaxMark = 100;

        public const int MIN = 0;
        public const int MAX = 100;
        public const int Percentage = 100;

        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }
        public int[] Mark { get; set; }

        public StudentGrades()
    {
        Students = new string[]
        {
            "Emily","Ethan","Olivia","Liam","Sophia",
            "Noah","Ava","William","Isabella","Benjamin"
        };
            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[]
            {
               10, 20, 30, 40, 50,
               60, 70, 80, 90, 100
            };
    }


        /// <summary>
        /// 
        /// 
        /// </summary>
        public void InputMarks()
        {
            Console.WriteLine(" Please enter a Mark for each Student");
            Console.WriteLine(" ------------------------------------");

            int i = 0;
            foreach (var student in Students)
            {
                int mark = (int)ConsoleHelper.InputNumber(
                    $" Enter {student}'s Mark > ", MIN, MAX);

                Marks[i] = mark;
                i++;
            };
        }

        /// <summary>
        /// 
        /// 
        /// </summary>
        public void OutputMarks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// 
        /// </summary>
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= LowestF && mark <= LowestD - 1)
                return Grades.F;
            if (mark >= LowestD && mark <= LowestC - 1)
                return Grades.D;
            if (mark >= LowestC && mark <= LowestB - 1)
                return Grades.C;
            if (mark >= LowestB && mark <= LowestA - 1)
                return Grades.B;
            if (mark >= LowestA && mark <= MaxMark)
                return Grades.A;

            else return Grades.F;
        }

        /// <summary>
        /// 
        /// 
        /// </summary>
        public void CalculateStats()
        {
            double total = 0;

            foreach (int mark in Marks)
            {
                Mean = total / Marks.Length;
            }
        }

        public void CalculateGradeProfile()
        {
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0; 
            }

            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade - 1]++;
            }
        }
    }
}
