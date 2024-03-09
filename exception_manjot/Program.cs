using System;
using System.Collections.Generic;

namespace exception_manjot
{
    public class Circle
    {

        private double Radius { get; set; }


        public Circle(double radius)
        {
            SetRadius(radius);
        }

        public void SetRadius(double radius)
        {
            if (radius > 0)
            {
                Radius = radius;
            }
            else
            {
                throw new InvalidRadiusException(radius);
            }
        }
        public override string ToString()
        {
            return $"Circle with radius: {Radius}";
        }
    }
    public class InvalidRadiusException : Exception
    {
        public InvalidRadiusException(double radius) : base($"Radius {radius} is not valid. It should be greater than zero.")
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(7);
            Console.WriteLine(circle1.ToString());
            try
            {
                Circle circle2 = new Circle(-9);
                Console.WriteLine(circle2.ToString());
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            try
            {
                Circle circle3 = new Circle(0);
                Console.WriteLine(circle3.ToString());
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }

            Console.ReadKey();

        }
    }

}