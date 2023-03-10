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

        public string [] Students { get; set; }

        public int[] Marks { get; set; }

        public int[] Gradeprofile { get; set; }

        public double Mean { get; set; }

        public int Minimum { get; set; }

        public int Maximum { get; set; }

    public StudentGrades()
    {
        Students = new string[]
        {
            "Emily","Ethan","Olivia","Liam","Sophia",
            "Noah","Ava","William","Isabella","Benjamin"
        };
            Gradeprofile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];         
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
