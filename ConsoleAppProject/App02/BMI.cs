using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author 

    public class BmiCalculator
    {

        public void CalculateBMI()
        {
            Console.Write("Hello, let's start by taking your name > ");
            Console.WriteLine();
            string username = Console.ReadLine();

            Console.WriteLine($"Hi {username}, now let's calculate your BMI.");
            Console.WriteLine();
            Console.WriteLine("Enter your weight (Kilograms): ");
            Console.WriteLine();
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your height (Meters): ");
            double height = Convert.ToDouble(Console.ReadLine());

            double BMI = weight / (height * height);
            Console.WriteLine($"Your BMI is {BMI}");

            if (BMI < 18.5)
                Console.WriteLine($"Your BMI of {BMI} is deemed as underweight, {username}.");
            else if (BMI >= 18.5 && BMI <= 24.9)
                Console.WriteLine($"Your BMI of {BMI} is a healthy weight and normal - Keep at your lifestyle, {username}.");
            else if (BMI >= 25 && BMI <= 29.9)
                Console.WriteLine($"Your BMI of {BMI} is classified as overwiehgt, {username}.");
            else
                Console.WriteLine($"Your BMI f {BMI} is considered obese, {username}.");
        }

    }

}
