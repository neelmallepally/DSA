using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSATests
{
    public class _003_CreateFibonacciNumbers
    {
        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { 1, new[] { 1 } };
            yield return new object[] { 2, new[] { 1, 1 } };
            yield return new object[] { 3, new[] { 1, 1, 2 } };
            yield return new object[] { 4, new[] { 1, 1, 2, 3 } };
            yield return new object[] { 5, new[] { 1, 1, 2, 3, 5 } };
            yield return new object[] { 6, new[] { 1, 1, 2, 3, 5, 8 } };
            yield return new object[] { 7, new[] { 1, 1, 2, 3, 5, 8, 13 } };

        }

        [Theory]
        [MemberData(nameof(GetData))]
        public void Test(int number, int[] expected)
        {
            var actual = CreateFibonacci(number);

            Assert.True(Enumerable.SequenceEqual(expected, actual));
        }


        private int[] CreateFibonacci(int number)
        {

            if (number == 1)
            {
                return new[] { 1 };
            }

            if (number == 2)
            {
                return new[] { 1, 1 };
            }

            int i = 2;
            int[] output = new int[number];
            output[0] = 1;
            output[1] = 1;

            while (i < number)
            {
                output[i] = output[i-1] + output[i-2];
                i++;
            }

            return output;
        }
    }
}
