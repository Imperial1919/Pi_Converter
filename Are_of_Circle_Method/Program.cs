using System;

namespace Are_of_Circle_Method
{
    class Program
    {

        static double circlearea(double input)
        {
           return input * 3.14159264;
           
        }

        static double Square(double number){

            return number * number;

        }

        static string Hi(string firstname, string lastname)
        {
            Console.WriteLine("Hello there " + firstname + "" + lastname);
            return firstname + lastname;
        }

        static int Areaof(int width, int height)
        {
            int area = width * height;
            Console.WriteLine("Ok, so this has a total area of " + area + " feet.");
            return area;


        }
        static double feettometers(int feet)
        {
           double conversion = feet / 3.281;
            Console.WriteLine("Ok, so " + feet + " feet is equal to " + conversion + " Meters.");
            return conversion;
        }
        static double MetersToFeet(int meters)
        {
            double footconversion = meters * 3.281;
            Console.WriteLine("Conversely " + meters + " meters can be converted to " + footconversion + " imperial feet.");
            return footconversion;
        }



        static void Main(string[] args)
        {
            Console.WriteLine(circlearea(4));
            Console.WriteLine(Square(5));
            Hi("Bryce", "Petite");
            Areaof(5, 4);
            feettometers(12);
            MetersToFeet(10);

        }
    }
}
