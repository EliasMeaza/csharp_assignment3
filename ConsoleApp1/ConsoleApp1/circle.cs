using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class circle : shape
    {
        public double area { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double parameter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void  menu ()
        {
            Console.WriteLine("enter the radius of the circle: ");
            double radius=Console.Read();
            area=calculate_area (radius);
            parameter= calculate_parameter(radius);
        }
        public double calculate_area(double radius,double y=0)
        {

            double area = 0;
            area = (radius * radius * shape.PI);
            return area;

            
        }

        public double calculate_parameter(double radius, double y=0)
        {
            double parameter = 0;
            parameter = 2*(radius*shape.PI);
            return parameter;
            
        }

       
    }
}
