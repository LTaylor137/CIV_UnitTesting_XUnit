using System;
using CalcLib;
using Xunit;

namespace Tests {
    public class UnitTest1 {

        // FactorialRec Tests Fact 1 test.
        [Fact]
        public void FactorialRecTest1 () {

            RecursiveCalc rec = new RecursiveCalc ();
            int expected = 1;
            int input = 1;
            int ans = 1;

            Assert.Equal (expected, rec.FactorialRec (input, ans));

        }

        // FactorialRec Tests Theories 3 tests.
        [Theory]
        [InlineData (1, 1)]
        [InlineData (6, 3)]
        [InlineData (39916800, 11)]

        public void FactorialRecTest2 (int expected, int input) {

            RecursiveCalc rec = new RecursiveCalc ();
            int ans = 1;

            Assert.Equal (expected, rec.FactorialRec (input, ans));

        }
    }

    public class UnitTest2 {

        //Check for DivideByZeroException Theory 2 tests
        [Theory]
        [InlineData (2, 0)]
        [InlineData (7, 0)]
        public void PrimeCheckRecTest (int primenum, int divisor) {

            RecursiveCalc r = new RecursiveCalc ();

            Assert.Throws<DivideByZeroException> (() => r.PrimeCheckRec (primenum, divisor));
        }
    }

    //FibonacciRec Test Fact 1 test
    public class UnitTest3 {
        [Fact]
        public void FibonacciRecTest1 () {

            RecursiveCalc r = new RecursiveCalc ();
            int expected = 41;
            int num1 = 1;
            int num2 = 2;
            int numFibs = 3;

            Assert.Equal (expected, r.FibonacciRec (num1, num2, numFibs));

        }
    }

     // FibonacciRec Test Theory 2 tests. Second test is designed to fail.

    public class UnitTest4 {
        [Theory]
        [InlineData(36824, 1, 5, 10)]
        [InlineData(3961680, 1, 7, 15)]    // --- This test is designed to FAIL, actual expected number should be 3961681

        public void FibonacciRecTest2 (int expected, int num1, int num2, int numFibs) {

            RecursiveCalc r = new RecursiveCalc ();

            Assert.Equal (expected, r.FibonacciRec (num1, num2, numFibs));

        }
    }

}