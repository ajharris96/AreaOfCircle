using System;

namespace AreaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius:");
            string userInput = Console.ReadLine();
            bool trying = double.TryParse(userInput, out double result);

            if (userInput != "" && trying) {

                double radius = double.Parse(userInput);



                while (radius < 0)
                {
                    Console.WriteLine("Invalid radius. Must be positive");
                    radius = double.Parse(Console.ReadLine());
                };




                double area = Circle.Area(radius);
                double circumference = Circle.Circumference(radius);
                double diameter = Circle.Diameter(radius);


                Console.WriteLine("The area of a circle with radius " + radius + " is " + area);
                Console.WriteLine("The diameter is " + diameter);
                Console.WriteLine("The circumference is " + circumference);

                Console.WriteLine("What is your car's mpg?");
                double mpg = double.Parse(Console.ReadLine());
                double gallons = circumference / mpg;
                Console.WriteLine("You will use " + gallons + " gallons to go around the circle.");

            }

           

            




        }

       
    }
}
