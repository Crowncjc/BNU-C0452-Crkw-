using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app will prompt the user to input a distance
    /// measurement  and then convert the unit and output
    /// the conversion in another unit.
    /// </summary>
    /// <author>
    /// Crown version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILE = 5280; //Feet to Mile//

        public const double METER_IN_MILE = 1609.344; //Meter to Mile//

        public const double METER_IN_FEET = 3.28084; //Meter in Feet//

        public const string FEET = "Feet";

        public const string METERS = "Meters";

        public const string MILES = "Miles";

        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        public void ConvertDistance()
        {
            OutputHeading();

            fromUnit = SelectUnit(" Please Select the from distance unit > ");
            toUnit = SelectUnit(" Please Select the to distance unit > ");

            Console.WriteLine();
            Console.WriteLine($" Converting {fromUnit} to {toUnit}");
            Console.WriteLine();

            fromDistance = InputDistance($" Enter the number of {fromUnit} > ");
            Console.WriteLine();

            CalculateDistance();

            OutputDistance();
        }

        private void CalculateDistance()
        {
            if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILE;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILE;
            }

            if (fromUnit == MILES && toUnit == METERS)
            {
                toDistance = fromDistance * METER_IN_MILE;
            }
            else if (fromUnit == METERS && toUnit == MILES)
            {
                toDistance = fromDistance / METER_IN_MILE;
            }

            if (fromUnit == FEET && toUnit == METERS)
            {
                toDistance = fromDistance / METER_IN_FEET;
            }
            else if (fromUnit == METERS && toUnit == FEET)
            {
                toDistance = fromDistance * METER_IN_FEET;
            }
        }

        private string SelectUnit(String prompt)
        {
            string choice = DisplayChoices(prompt);
            string unit = ExecuteChoice(choice);
            Console.WriteLine();
            Console.WriteLine($"\n You have Chosen {unit}");
            Console.WriteLine();
            return unit;

            static string ExecuteChoice(string choice)
            {
                if (choice.Equals("1"))
                {
                    return FEET;
                }

                if (choice.Equals("2"))
                {
                    return METERS;
                }

                if (choice.Equals("3"))
                {
                    return MILES;
                }

                return null;
            }

        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METERS}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.WriteLine(prompt);
            string choice = Console.ReadLine();
            return choice;
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

        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        private void OutputDistance()
        {
            Console.WriteLine($"\n {fromDistance}  {fromUnit}" +
                $" is {toDistance} {toUnit}!\n");
        }

    }
}

