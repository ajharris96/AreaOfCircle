using System;
namespace AreaOfCircle
{
    public class Circle
    {
        //double radius;


    

        public static double Area(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;

        }
        public static double Circumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }
        public static double Diameter(double radius)
        {
            double diameter = 2  * radius;
            return diameter;
        }


    }
}
