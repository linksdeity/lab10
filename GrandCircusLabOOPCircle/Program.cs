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

            //verify input
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

            //instantiate a circle with the radius the user wants
            Circle newCircle = new Circle(radius);

            //use public methods to grab the string answer to circumference
            Console.WriteLine("\nThe circumference is: " + newCircle.CalculateFormattedCircumference());

            //use public methods to grab the string answer to area
            Console.WriteLine("\nThe area is: " + newCircle.CalculateFormattedArea());


            //keeps console open
            Console.ReadKey();


        }
    }


}
