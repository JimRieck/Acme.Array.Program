using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;

namespace Acme.Array.Solver
{
    public class NumberArraySolver : ArraySolver
    {
        public override List<int> SolveNumberArray(List<int> numberList)
        {
            List<int> numbersMissing = new List<int>();
            if (numberList == null)
            {
                throw new ArgumentNullException("numberList cannot be null");
            }
            else if (!numberList.Any())
            {
                throw new InvalidDataException("numberList has no items");
            }
            else
            {
               numbersMissing = GetMissingNumber(numberList);
                if (numbersMissing.Count() > 1)
                {
                    throw new ArgumentOutOfRangeException("There is more than 1 missing number.");
                }
            }

            return numbersMissing;
        }

        private List<int> GetMissingNumber(List<int> numberList)
        {
            List<int> missingNumbers = new List<int>();
            for (int i = 0; i < numberList.Count; i++)
            {
                if (i + 1 <= numberList.Count - 1)
                {
                    int expectedNextNumber = numberList[i] + 1;
                    if (expectedNextNumber != numberList[i + 1])
                    {
                        missingNumbers.Add(expectedNextNumber);
                    }
                }
            }

            return missingNumbers;
        }
    }
}