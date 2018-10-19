using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.Array.Solver.Tests
{
   
        [TestClass]
        public class SolverTests
        {
            private List<int> numbersList = new List<int>();

            private Solver.NumberArraySolver solver;
            [TestInitialize]
            public void Setup()
            {
                solver = new NumberArraySolver();
                numbersList = new List<int> { 1, 2, 4, 5, 6, 7, 8, 9, 10 };
            }

            [TestMethod]
            public void TestValidNumberList()
            {
                Assert.IsTrue(solver.SolveNumberArray(numbersList).Any());
            }

            [TestMethod]
            public void TestNULLNumberList()
            {
                numbersList = null;
                Assert.ThrowsException<ArgumentNullException>(() => solver.SolveNumberArray(numbersList).Any());
            }

            [TestMethod]
            public void TestNoItemsInListNumberList()
            {
                numbersList = new List<int>();
                Assert.ThrowsException<ArgumentNullException>(() => solver.SolveNumberArray(numbersList).Any());
            }

        [TestMethod]
        public void TestMoreThan1MissingNumberNumberList()
        {
            numbersList = new List<int> { 1, 2, 4, 5, 6, 7, 8, 10 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => solver.SolveNumberArray(numbersList));
        }

    }
   
}
