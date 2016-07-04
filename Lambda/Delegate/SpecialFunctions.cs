using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.Delegate
{
    public delegate double PerformCalculation(double x, double y);
    /**
     * TODO 1:
     * Create a delegate called NumberCheck which returns a boolean and has a single parameter of type int
     */
    public delegate bool NumberCheck(int x);

    public class SpecialFunctions
    {
        public static double Sum(double val1, double val2)
        {
            return val1 + val2;
        }

        public static double Product(double val1, double val2)
        {
            return val1 * val2;
        }

        public static double Diff(double val1, double val2)
        {
            return val1 - val2;
        }

        public static void ExecuteFunction(PerformCalculation function, double param1, double param2)
        {
            double result = function(param1, param2);
            Console.WriteLine(result);
        }

        public static void ExecuteFunctionUsingFunc(Func<double, double, double> function, double param1, double param2)
        {
            double result = function(param1, param2);
            Console.WriteLine(result);
        }

        /**
         * TODO 2: 
         * Create a function which checks if an integer is even. The function will return True for even numbers and False for odd numbers.
         */
        public static bool CheckEvenNumber(int number)
        {
            return number % 2 == 0;
        }
        /**
         * TODO 3:
         * Create a function called GetEvenNumbers which uses an instance of a NumberCheck delegate and an aray list of integers.
         * The function will return a list with the even numbers.
         */

        //IEnumerable merge cu yield; List nu merge
         public static IEnumerable<int> GetEvenNumbers(NumberCheck function, List<int> list)
        {
            //var newList = new List<int>();
            foreach (var number in list)
            {
                if (function(number))
                {
                    //newList.Add(number);
                    yield return number;
                }
            }
            //return newList;
        }

        public static List<int> GetOddNumbers(Func<int,bool> function, List<int> list)
        {
            var newList = new List<int>();
            foreach (var number in list)
            {
                if (!function(number))
                {
                    newList.Add(number);
                }
            }
            return newList;
        }
    }
}
