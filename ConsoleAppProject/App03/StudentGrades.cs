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

        public const int lowestF = 0;
        public const int lowestD = 40;
        public const int lowestC = 50;
        public const int lowestB = 60;
        public const int lowestA = 70;
        public const int maxMark = 100;

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

            OutputChoices();
        }


        /// <summary>
        /// 
        /// 
        /// </summary>
        public void InputMarks()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// 
        /// </summary>
        public void CalculateStats()
        {
            throw new NotImplementedException();
        }
    }
}
