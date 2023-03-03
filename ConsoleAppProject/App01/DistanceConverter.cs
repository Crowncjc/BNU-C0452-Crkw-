using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Derek version 0.1
    /// </author>
    public class DistanceConverter
    {
        public static double FEET_IN_MILE = 5280; //Feet to Mile//

        public static double METER_IN_MILE = 1609.344; //Meter to Mile//

        public static double METER_IN_FEET = 3.28084; //Meter in Feet//

        public double miles, meters, feet;

        public void Run()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
  
        }
        

        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine(" =====================================================");
            Console.WriteLine("            Distance Converter Application            ");
            Console.WriteLine("            by Crown Caesar                           ");
            Console.WriteLine(" =====================================================");
            Console.WriteLine();
        }

        private void InputMiles()
        {
            Console.WriteLine("Please enter the number of Miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void CalculateFeet()
        {

        }
                
    }
}

