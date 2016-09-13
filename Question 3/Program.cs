using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            // no way to actually set the radius
            Circle circle = new Circle();

            // using a lambda expression
            double answer = circle.Calculate(radius =>
                {
                    return 2 * Math.PI * radius;
                });

            // using a delegate
            answer = circle.Calculate(delegate(double radius)
            {
                return 2 * Math.PI * radius;
            });

            // using a method
            answer = circle.Calculate(Circumference);

            Console.WriteLine(answer);
        }

        static double Circumference(double radius)
        {
            return 2 * Math.PI * radius;
        }
    }

    public sealed class Circle
    {
        private double radius;

        public double Calculate(Func<double, double> op)
        {
            return op(radius);
        }
    }

}
