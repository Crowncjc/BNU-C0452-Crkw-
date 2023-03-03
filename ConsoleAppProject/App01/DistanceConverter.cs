using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Crown version 0.1
    /// </author>
    public class DistanceConverter
    {
        public static double FEET_IN_MILE = 5280; //Feet to Mile//

        public static double METER_IN_MILE = 1609.344; //Meter to Mile//

        public static double METER_IN_FEET = 3.28084; //Meter in Feet//

        public double miles, meters, feet;

        public void Run()
        {
            
            OutputHeading("Converting Miles to Feet");
            Console.WriteLine();

            miles = InputDistance("Please enter the the number of Miles > ");
            CalculateFeet1();
            OutputFeet1();
            Console.WriteLine();



            OutputHeading("Converting Meters to Feet");
            Console.WriteLine();

            meters = InputDistance("Please enter the the number of Meters > ");
            CalculateFeet2();
            OutputFeet2();
            Console.WriteLine();



            OutputHeading("Converting Feet to Miles                      ");
            Console.WriteLine();

            feet = InputDistance("Please enter the the number of Feet > ");
            CalculateMiles3();
            OutputMiles3();
            Console.WriteLine();



            OutputHeading("Converting Meters to Miles                      ");
            Console.WriteLine();

            meters = InputDistance("Please enter the the number of Meters > ");
            CalculateMiles4();
            OutputMiles4();
            Console.WriteLine();



            OutputHeading("Converting Miles to Meters                      ");
            Console.WriteLine();

            miles = InputDistance("Please enter the the number of Miles > ");
            CalculateMeters5();
            OutputMeters5();
            Console.WriteLine();



            OutputHeading("Converting Feet to Meters                      ");
            Console.WriteLine();

            feet = InputDistance("Please enter the the number of Feet > ");
            CalculateMeters6();
            OutputMeters6();
        }
        

        private void OutputHeading(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine(" =====================================================");
            Console.WriteLine("            Distance Converter Application            ");
            Console.WriteLine("            by Crown Caesar                           ");
            Console.WriteLine(" =====================================================");
            Console.WriteLine();

            Console.WriteLine(prompt);
            Console.WriteLine();
        }

        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        ///////////Miles to Feet///////

        private void CalculateFeet1()
        {
            feet = miles * 5280;
        }

        private void OutputFeet1()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet!");
        }

        ///////////Meters to Feet///////

        
        private void CalculateFeet2()
        {
            feet = meters * METER_IN_FEET;
        }

        private void OutputFeet2()

        {
            Console.WriteLine(meters + " meters is " + feet + " feet!");
        }

        ///////////Feet to Miles///////
        

        private void CalculateMiles3()
        {
            miles = feet / FEET_IN_MILE;
        }

        private void OutputMiles3()

        {
            Console.WriteLine(feet + " feet is " + miles + " miles!");
        }

        ///////////Meters to Miles///////


        private void CalculateMiles4()
        {
            miles = meters * METER_IN_MILE;
        }

        private void OutputMiles4()

        {
            Console.WriteLine(feet + " meters is " + miles + " miles!");
        }

        ///////////Miles to Meters///////
        

        private void CalculateMeters5()
        {
            meters = miles / METER_IN_MILE;
        }

        private void OutputMeters5()

        {
            Console.WriteLine(miles + " miles is " + meters + " meters!");
        }

        ///////////FeettoMeters///////

        private void CalculateMeters6()
        {
            meters = feet / METER_IN_FEET;
        }

        private void OutputMeters6()

        {
            Console.WriteLine(feet + " Feet is " + meters + " Meters!");
        }
    }
}

