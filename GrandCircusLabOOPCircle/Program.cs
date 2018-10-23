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


        public double CalculateCircumference()
        {
            return System.Math.Round( ((2 * System.Math.PI) * this.Radius), 2 );
        }


        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }


        public double CalculateArea()
        {
            return System.Math.Round( (System.Math.PI * (this.Radius * this.Radius)), 2 );
        }


        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }


        //round number to 2 decimals
        private string FormatNumber(double x)
        {
            string numberText = ("" + x);

            return numberText;
        }


    }




}
