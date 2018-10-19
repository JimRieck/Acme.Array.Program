using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Array.Solver;

namespace Acme.Array.Problem.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int> { 1, 2, 4, 5, 6, 7, 8, 9, 10 };
                NumberArraySolver solver = new NumberArraySolver();
                List<int> missingNumbers = solver.SolveNumberArray(numbers);
                System.Console.Write("The missing number is: ");
                System.Console.WriteLine(string.Join(",", missingNumbers));
            }
            catch (Exception error)
            {
                System.Console.WriteLine(error.Message);
            }
            System.Console.ReadLine();
        }
    }
}
