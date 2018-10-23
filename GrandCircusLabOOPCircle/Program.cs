using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLabOOPCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;

            Console.WriteLine("Please enter the radius of the circle: ");

            while (true)
            {
                try
                {
                    radius = Double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please just enter a number for the radius!");
                    continue;
                }

                break;
            }

            Circle newCircle = new Circle(radius);

            Console.WriteLine("\nThe circumference is: " + newCircle.CalculateFormattedCircumference());

            Console.WriteLine("\nThe area is: " + newCircle.CalculateFormattedArea());



            Console.ReadKey();


        }
    }


    //our class Circle------------------------------------------
    class Circle
    {
        private double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        //does the math
        public double CalculateCircumference()
        {
            return System.Math.Round( ((2 * System.Math.PI) * this.Radius), 2 );
        }

        //returns the formatted number
        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }

        //does the math
        public double CalculateArea()
        {
            return System.Math.Round( (System.Math.PI * (this.Radius * this.Radius)), 2 );
        }

        //returns the formatted number
        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }


        //sets number to a string
        private string FormatNumber(double x)
        {
            string numberText = "";

            numberText += x;

            return numberText;
        }


    }




}
