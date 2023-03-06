using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This App designed to help individuals track their
    /// weight and determine whether their weight falls
    /// within a healthy range according to their height.
    /// </summary>
    /// <author>
    /// Crown Caesar version 0.1
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
            Console.WriteLine();

            if (BMI < 18.5)
                Console.WriteLine($"Your BMI of {BMI} indicates that you are underweight, {username}.");
            else if (BMI >= 18.5 && BMI <= 24.9)
                Console.WriteLine($"Your BMI of {BMI} indicates that you are at healthy weight, {username}.");
            else if (BMI >= 25 && BMI <= 29.9)
                Console.WriteLine($"Your BMI of {BMI} indicates that you are overwiehgt, {username}.");
            else
                Console.WriteLine($"Your BMI f {BMI} indicates that you are obese, {username}.");
        }

    }

}
