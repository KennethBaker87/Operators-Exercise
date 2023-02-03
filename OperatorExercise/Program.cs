using System;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {


            int a = 17;
            int b = 4;

            int sum = a + b;
            int diff = a - b;
            int quot = a * b;
            int quotient = a / b;
            int remainder = a % b;



            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            }

            //--------------------------Exercise 2-------------------------------
            Console.WriteLine("What is radius of your circle?: ");
            var radius = double.Parse(Console.ReadLine());
            var answer = AreaOfCircle(radius);
            Console.WriteLine($"The area of a circle with raidus of {radius} is {answer}");
        }
        public static double AreaOfCircle(double radius)
        {
            return (Math.PI * radius * radius);
        }
    }
}
