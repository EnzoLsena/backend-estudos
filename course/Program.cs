using System;

namespace Course {
    class Program {
        static void Main(string[] args) {
            double a = 2.0, b = 5.0, c = 8;

            double delta = Math.Pow(b,2.0) - 4.0 * a * c;

            double x1 = (- b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            
            Console.WriteLine(x1);
            Console.WriteLine(delta);



        }
            
    }
}
