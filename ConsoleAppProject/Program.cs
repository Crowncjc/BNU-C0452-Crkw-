using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Crown Caesar 
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2022-2023! ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            string[] choices =
            {
                " App1 Distance Converter",
                " App2 BMI Calculator",
                " App3 Student Grades",
            };

            Console.WriteLine(" Please Choose which Application You would like to Use");
            Console.WriteLine();

            int choice;
            do
            {

                choice = ConsoleHelper.SelectChoice(choices);
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        DistanceConverter converter = new DistanceConverter();
                        converter.ConvertDistance();
                        break;
                    case 2:
                        BmiCalculator calculate = new BmiCalculator();
                        calculate.CalculateBMI();
                        break;
                    case 3:
                        StudentGrades convert = new StudentGrades();
                        convert.Run();
                        break;
                }

            } while (choice != 3);

            ///DistanceConverter converter = new DistanceConverter();

            ////converter.ConvertDistance();

            ////Console.WriteLine();
            ////Console.WriteLine(" =================================================");
            ////Console.WriteLine("                  BMI Calculator by            ");
            ////Console.WriteLine("                  Crown Caesar             ");
            ////Console.WriteLine(" =================================================");
            ////Console.WriteLine();

            ////BmiCalculator calculate = new BmiCalculator();

            ////calculate.CalculateBMI();

            ////Console.WriteLine();

            ////Console.WriteLine();
            ////Console.WriteLine(" =================================================");
            ////Console.WriteLine("                  Student Marks by1            ");
            ////Console.WriteLine("                  Crown Caesar             ");
            ////Console.WriteLine(" =================================================");
            ////Console.WriteLine();

            ////StudentGrades convert = new StudentGrades();

            ////convert.Run();///


        }
    }
}
