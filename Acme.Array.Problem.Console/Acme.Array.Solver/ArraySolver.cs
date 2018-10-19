using System;
using System.Collections.Generic;

namespace Acme.Array.Solver
{
    public abstract class ArraySolver : IArraySolver
    {
        public virtual List<int> SolveNumberArray(List<int> numberList)
        {
            return new List<int>();
        }
    }
}
