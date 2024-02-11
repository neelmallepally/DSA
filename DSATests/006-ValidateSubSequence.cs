using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSATests
{
    // PROBLEM: Given two non-empty arrays of integers, write a function that determines whether the second
    // array is a subsequence of the first one.
    // Examples: [1, 3, 4] is subsequence of [1, 2, 3,4], [2,4] is subsequence of [1, 2, 3, 4]
    public class _006_ValidateSubSequence
    {


        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { new[] { 5, 1, 22 }, new[] { 1, 22 }, true };
            yield return new object[] { new[] { 5, 1, 22, 25, 6, -1, 8, 10 }, new[] { 1, 6, -1, 10 }, true };
            yield return new object[] { new[] { 5, 1, 22, 25, 6, -1, 8, 10 }, new[] { 5, 1, 22, 25, 6, -1, 8, 10, 10 }, false };
        }


        [Theory]
        [MemberData(nameof(GetData))]
        public void Test(int[] array, int[] sequence, bool expected)
        {
            var actual = FoundSubsequence(array, sequence);
            Assert.Equal(expected, actual);
        }


        private bool FoundSubsequence(int[] array, int[] sequence)
        {
            int aPtr = 0;
            int sPtr = 0;

            while(aPtr < array.Length && sPtr < sequence.Length)
            {
                if (array[aPtr] == sequence[sPtr])
                {
                    sPtr++;
                }
                aPtr++;
            }

            return sPtr == sequence.Length;
        }
    }
}
