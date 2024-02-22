using System;

namespace Assessment{

    class Triangle{

        static void Main(string[] args){

            Console.WriteLine("Enter Base: ");

            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Height: ");

            int h = Convert.ToInt32(Console.ReadLine());

            double result = .5 * b * h; 

            Console.WriteLine("The area of the triangle is: " + result);
            
        }
    }
}