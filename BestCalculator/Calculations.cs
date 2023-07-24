using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace BestCalculator
{
    public class Calculations
    {
        
        public void Addition(double num1, double num2)
        {

            var rezult = num1 + num2;

            Console.WriteLine($"Result of two numbers is: {rezult}");
        }
        public void Substraction(double num1, double num2)
        {
            var rezult = num1 - num2;
            Console.WriteLine($"Result of two numbers is: {rezult}");
        }

        public void Multiplication(double num1, double num2)
        {
            var rezult = num1 * num2;
            Console.WriteLine($"Result of two numbers is: {rezult}");
        }
        public void Division(double num1, double num2)
        {
            var rezult = num1 / num2;
            Console.WriteLine($"Result of two numbers is: {rezult}");
        }
   
         
        }
}