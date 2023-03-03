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
            OutputHeading();
            
            Console.WriteLine("                   Miles to Feet                      ");
            Console.WriteLine();

            InputMiles1();
            CalculateFeet1();
            OutputFeet1();
            Console.WriteLine();

            Console.WriteLine("                   Meters to Feet                      ");
            Console.WriteLine();

            InputMeters2();
            CalculateFeet2();
            OutputFeet2();
            Console.WriteLine();

            Console.WriteLine("                   Feet to Miles                      ");
            Console.WriteLine();

            InputFeet3();
            CalculateMiles3();
            OutputMiles3();
            Console.WriteLine();

            Console.WriteLine("                   Meters to Miles                      ");
            Console.WriteLine();

            InputMeters4();
            CalculateMiles4();
            OutputMiles4();
            Console.WriteLine();

            Console.WriteLine("                   Miles to Meters                      ");
            Console.WriteLine();

            InputMiles5();
            CalculateMeters5();
            OutputMeters5();
            Console.WriteLine();

            InputFeet6();
            CalculateMeters6();
            OutputMeters6();
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

        ///////////Miles to Feet///////

        private void InputMiles1()
        {
            Console.WriteLine("Please enter the number of Miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void CalculateFeet1()
        {
            feet = miles * 5280;
        }

        private void OutputFeet1()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet!");
        }

        ///////////Meters to Feet///////

        private void InputMeters2()
        {
            Console.Write("Please enter the number of Meters > ");
            string value = Console.ReadLine();
            meters = Convert.ToDouble(value);
        }

        private void CalculateFeet2()
        {
            feet = meters * METER_IN_FEET;
        }

        private void OutputFeet2()

        {
            Console.WriteLine(meters + " meters is " + feet + " feet!");
        }

        ///////////Feet to Miles///////

        private void InputFeet3()
        {
            Console.Write("Please enter the number of Feet > ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }

        private void CalculateMiles3()
        {
            miles = feet / FEET_IN_MILE;
        }

        private void OutputMiles3()

        {
            Console.WriteLine(feet + " feet is " + miles + " miles!");
        }

        ///////////Meters to Miles///////

        private void InputMeters4()
        {
            Console.Write("Please enter the number of Meter > ");
            string value = Console.ReadLine();
            meters = Convert.ToDouble(value);
        }

        private void CalculateMiles4()
        {
            miles = meters * METER_IN_MILE;
        }

        private void OutputMiles4()

        {
            Console.WriteLine(feet + " meters is " + miles + " miles!");
        }

        ///////////Miles to Meters///////

        private void InputMiles5()
        {
            Console.Write("Please enter the number of Miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void CalculateMeters5()
        {
            meters = miles / METER_IN_MILE;
        }

        private void OutputMeters5()

        {
            Console.WriteLine(miles + " miles is " + meters + " meters!");
        }

        ///////////FeettoMeters///////

        private void InputFeet6()
        {
            Console.Write("Please enter the number of Feet > ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }

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

