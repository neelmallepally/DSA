using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSATests
{

    // PROBLEM: Given a number n, get sum of all fibonacci series up to n.
    public class SumOfFibonacciNumbers
    {
        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { 1, 1 };
            yield return new object[] { 2, 2 };
            yield return new object[] { 3, 4 };
            yield return new object[] { 4, 7 };
            yield return new object[] { 5, 12 };
            yield return new object[] { 6, 20 };
            yield return new object[] { 7, 33 };
            yield return new object[] { 8, 54 };
        }

        [Theory]
        [MemberData(nameof(GetData))]
        public void Test(int num, int expected)
        {
            var actual = Sum_Fib(num);
            Assert.Equal(expected, actual);
        }


        private int Sum_Fib(int n)
        {
            if (n < 2) return n;

            return Fib(n) + Sum_Fib(n-1);
        }


        private int Fib(int n)
        {
            if (n < 2)
            {
                return n;
            }

            return Fib(n - 1) + Fib(n - 2);
        }
    }
}
