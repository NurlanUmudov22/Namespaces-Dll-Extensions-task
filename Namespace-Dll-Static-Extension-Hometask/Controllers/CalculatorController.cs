using Namespace_Dll_Static_Extension_Hometask.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Namespace_Dll_Static_Extension_Hometask.Controllers
{
    internal class CalculatorController /*: CalculatorService*/
    {

        public CalculatorService calculatorService;

        public CalculatorController()
        {

            calculatorService = new CalculatorService();

        }



        public void Calculate()
        {
            Console.WriteLine("Enter first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter operation:");
            char operation = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            var result = calculatorService.Calculation( num1,  num2, operation);
            Console.WriteLine("Result: " + result);
        }


    }
}
