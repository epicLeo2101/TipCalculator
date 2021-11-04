using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double mealUserInput;
            double tipPercentUserInput;
            double tipAmounCalculated;
            double mealCalculatedTotalCost;


            Console.Title = "Tip Calculator";

            Console.WriteLine("Please enter the cost of your meal: ");

            mealUserInput = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What percentage would you like to tip: ?");

            tipPercentUserInput = Convert.ToDouble(Console.ReadLine());

            tipAmounCalculated = ((tipPercentUserInput / 100) * mealUserInput);

            Console.WriteLine("The tip amount base on the cost of your meal should be: $" + Math.Round(tipAmounCalculated));

            mealCalculatedTotalCost = mealUserInput + tipAmounCalculated;

            Console.WriteLine("The total cost of the meal with tip is: $" + Math.Round(mealCalculatedTotalCost));

            Console.ReadLine();    
        }
    }
}
