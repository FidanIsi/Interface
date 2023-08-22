using System.Security.AccessControl;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area1 = GeometryHelper.triangle(3, 7);
            Console.WriteLine(area1);

            double area2 = GeometryHelper.rectangle(4.6, 15);
            Console.WriteLine(area2);

            double area3 = GeometryHelper.circle(4.6);
            Console.WriteLine(area3);
        }
    }

    public static class GeometryHelper
    {
        public static double triangle(double width, double length)
        {
            double area = width * length / 2;
            return area;
        }

        public static double rectangle (double width, double height)
        {
            double area = width * height;
            return area;
        }

        public static double circle (double rad)
        {
            double area = Math.PI * rad * rad;
            return area;
        }
    }
}