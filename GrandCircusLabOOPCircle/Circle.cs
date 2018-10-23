using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLabOOPCircle
{
    class Circle
    {

        //private field the Circle class needs to work
        private double Radius;


        //constructor method takes one variable at instantiation
        public Circle(double radius)
        {
            Radius = radius;
        }

        //does the math
        public double CalculateCircumference()
        {
            return System.Math.Round(  ((2 * System.Math.PI) * this.Radius), 2);
        }

        //returns the formatted number
        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }

        //does the math
        public double CalculateArea()
        {
            return System.Math.Round((System.Math.PI * (this.Radius * this.Radius)), 2);
        }

        //returns the formatted number
        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }


        //sets number to a string, private because it means nothing to end user - only needed locally
        private string FormatNumber(double x)
        {
            string numberText = "";

            numberText += x;

            return numberText;
        }


    }
}
