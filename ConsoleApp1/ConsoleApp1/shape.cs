using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class main
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1-for circle");
            Console.WriteLine("2-for rectangle");
            int choice;
            do
            {
                choice = Console.Read();
                if (choice == 1)
                {
                    rectangle n = new rectangle();
                    n.menu();
                }
                else if (choice == 2)
                {
                    circle c = new circle();
                    c.menu();
                }
                else
                {
                    Console.WriteLine("incorrect input");
                }
            }while(choice !=1 && choice !=2);
            
            Console.WriteLine("the area is -" + area);
            Console.WriteLine("the parameter is -" + area);
        }

    }
    }
    internal interface shape 

    {
        public double area { get; set; }
        public double parameter { get; set; }
        public static double PI = 3.14;

        double  calculate_area(double x, double y);
        double calculate_parameter(double x, double y = 0);
    }
        
        

    }
}
