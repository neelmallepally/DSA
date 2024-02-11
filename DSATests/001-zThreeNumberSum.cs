using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSATests
{
    public class _001_ThreeNumberSum
    {
        // PROBLEM: Three Number Sum (M)
        // Write a function that takes in a non-empty array of distinct integers and an integer representing a target
        // sum. The function should find all triplets in the array that sum up to the target sum and return a two
        // dimensional array of all these triplets. The numbers in each triplet should be ordered in ascending order,
        // and the triplets themselves should be ordered in ascending order with respect to the numbers they hold.

        // If not threee numbers sum up to the target sum, the function should return an empty array.

        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { 
            new[] { 12, 3, 1, 2, -6, 5, -8, 6 }, 
            0, 
            new List<int[]>() { new[] { -8, 2, 6 }, new[] { -8, 3, 5 }, new[] { -6, 1, 5 } } };
        }


        [Theory]
        [MemberData(nameof(GetData))]
        public void Test(int[] input, int target, List<int[]> expected)
        {
            var result = ReturnTriplet(input, target);

            Assert.Equal(expected.Count, result.Count);

            for(int i = 0; i < result.Count; i++)
            {
                Assert.True(Enumerable.SequenceEqual(expected[i], result[i]));
            }
        }

        private List<int[]> ReturnTriplet(int[] x, int target)
        {
            List<int[]> result = new List<int[]>();
            Array.Sort(x);

            for (int i = 0; i < x.Length; i++)
            {
                
                int c = x[i];
                int l = i + 1;
                int r = x.Length -1;

                while (l < r)
                {
                    int sum = c + x[l] + x[r];

                    if (sum > target) r--;
                    if (sum < target) l++;
                    if (sum == target)
                    {
                        int[] triplet = new int[3] {c, x[l], x[r] };

                        result.Add(triplet);
                        l++;
                        r--;
                    }
                }
            }

            return result;
        }

        // HINT 1: First order the elements in the input order by ascending order
        // HINT 2: Start from first number as current number, and a left pointer next to the first number and right pointer on the last element of the array.
        // HINT 3: As you sum current + number in left ptr position + number in righ ptr position, compare sum and target sum and move pointers accodingly until you get sum == target
        // PATTERN: IN A SORTED ARRAY when adding numbers, moving to the right increases the sum and moving to the left decreases the sum.
    }



}
