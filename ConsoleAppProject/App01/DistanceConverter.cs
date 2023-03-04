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
            OutputDistance(miles, nameof(miles), feet, nameof(feet));
            Console.WriteLine();



            OutputHeading("Converting Meters to Feet");
            Console.WriteLine();

            meters = InputDistance("Please enter the the number of Meters > ");
            CalculateFeet2();
            OutputDistance(meters, nameof(meters), feet, nameof(feet));
            Console.WriteLine();



            OutputHeading("Converting Feet to Miles                      ");
            Console.WriteLine();

            feet = InputDistance("Please enter the the number of Feet > ");
            CalculateMiles3();
            OutputDistance(feet, nameof(feet), miles, nameof(miles));
            Console.WriteLine();



            OutputHeading("Converting Meters to Miles                      ");
            Console.WriteLine();

            meters = InputDistance("Please enter the the number of Meters > ");
            CalculateMiles4();
            OutputDistance(meters, nameof(meters), miles, nameof(miles));
            Console.WriteLine();



            OutputHeading("Converting Miles to Meters                      ");
            Console.WriteLine();

            miles = InputDistance("Please enter the the number of Miles > ");
            CalculateMeters5();
            OutputDistance(miles, nameof(miles), meters, nameof(meters));
            Console.WriteLine();



            OutputHeading("Converting Feet to Meters                      ");
            Console.WriteLine();

            feet = InputDistance("Please enter the the number of Feet > ");
            CalculateMeters6();
            OutputDistance(feet, nameof(feet), meters, nameof(meters));
            
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

        private void OutputDistance(
            double fromDistance, string fromUnit,
            double toDistance, string toUnit)
        {
            Console.WriteLine($" {fromDistance}  {fromUnit}" +
                $" is {toDistance} {toUnit}!");
        }

        ///////////Miles to Feet///////

        private void CalculateFeet1()
        {
            feet = miles * 5280;
        }
        ///////////Meters to Feet///////

        
        private void CalculateFeet2()
        {
            feet = meters * METER_IN_FEET;
        }

        ///////////Feet to Miles///////
        

        private void CalculateMiles3()
        {
            miles = feet / FEET_IN_MILE;
        }

        ///////////Meters to Miles///////


        private void CalculateMiles4()
        {
            miles = meters * METER_IN_MILE;
        }

        ///////////Miles to Meters///////
        

        private void CalculateMeters5()
        {
            meters = miles / METER_IN_MILE;
        }

        ///////////FeettoMeters///////

        private void CalculateMeters6()
        {
            meters = feet / METER_IN_FEET;
        }

    }
}

