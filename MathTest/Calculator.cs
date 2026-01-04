using System;
using System.Collections.Generic;
using System.Linq;
//using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//[assembly: InternalsVisibleTo("MathProject")] //I stedet for at gøre klassen public

namespace MathProject
{
    public class Calculator
    {
            public List<int> Results { get; set; } = new List<int>();    

            /// <summary>
            /// Adds two integers
            /// </summary>
            /// <param name="first">The first value</param>
            /// <param name="second">The second value</param>
            /// <returns></returns>
            public int Add(int first, int second)
            {
                Results.Add(first + second);
                return first + second;
            }


            public bool NumberIsPositive(int number)
            {
                if (number > 0)
                {
                    Console.WriteLine("Number is positive");
                    return true;
                }
                else if (number < 0)
                {
                    Console.WriteLine("Number is negative");
                    return false;
                }
                else
                {
                    Console.WriteLine("Number is zero");
                    return false;
                }
            }

            public bool NumberIsEven(int number)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is even");
                    return true;
                }
                else
                {
                    Console.WriteLine("The number is odd");
                    return false;
                }
            }
        
    }
}
