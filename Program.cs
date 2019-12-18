using System;
using static System.Console;

namespace rectangle_methods
{
    class Program
    {
        // use class-level static variables, since
        // we are not instantiating objects (yet!)
        static double height,
                      width,
                      area,
                      perimeter;
        static void Main(string[] args)
        {
            height = ReadDouble("Please enter height:");
            width = ReadDouble("Please enter width:");
            area = CalculateArea();
            perimeter = CalculatePerimeter();
            WriteLine(DisplayResults());
        }

        static double ReadDouble(string label)
        {
            Write("{0} ", label);
            double number;
            string userInput = ReadLine();
            while (Double.TryParse(userInput, out number) == false)
            {
                Write("{0} {1} ", "Invalid input!", label);
                userInput = ReadLine();
            }
            return number;
        }
        static double CalculateArea()
        {
            return width * height;
        }
        static double CalculatePerimeter()
        {
            return 2 * (width + height);
        }
        static string DisplayResults()
        {
            string result = String.Format("{0}\n", "****** RECTANGLE STUFF ******");
            result += String.Format("{0, 12} {1, 12:N1}\n", "Width:", width);
            result += String.Format("{0, 12} {1, 12:N1}\n", "Height:", height);
            result += String.Format("{0, 12} {1, 12:N1}\n", "Area:", area);
            result += String.Format("{0, 12} {1, 12:N1}\n", "Perimeter:", perimeter);
            return result;
        }
    }
}
