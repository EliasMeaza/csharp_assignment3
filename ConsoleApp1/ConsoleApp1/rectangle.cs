using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class rectangle : shape
    {
        public double area { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double parameter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void menu()
        {
            Console.WriteLine("enter the length of the rectangle: ");
            double length = Console.Read();
            Console.WriteLine("enter the width of the rectangle: ");
            double width = Console.Read();
            
            area = calculate_area(length,width);
            parameter= calculate_parameter(length,width);
        }
        public double calculate_area(double x, double y)
        {
           double area = 0;
            area=(x*y);
            return area;
            
        }

        public double calculate_parameter(double x, double y)
        {
            double parameter = 0;
            parameter=2*(x+y);
            return parameter;
        }
    }
}
