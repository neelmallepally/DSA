using System.Collections;

namespace DSATests
{

    // PROBLEM: 001- TWO SUM
    // Given an array of integers, return indices of the two numbers such that they add up to a specific target.
    // You may assume that each input would have exactly one solution, and you may not use the same element twice.
    
    public class TwoSumTests
    {
        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { new[] {2, 7, 11, 15 }, 9, new[] { 0, 1 } };
            yield return new object[] { new[] {2, 1, 5, 3 }, 4, new[] { 1, 3 } };
        }

        [Theory]
        [MemberData(nameof(GetData))]
        public void Test1(int[] input, int target, int[] expected)
        {
            var result = TwoSum.ProcessResult(input, target);
            
            Assert.Equal(expected.Length, result.Length);
            Assert.Equal(expected[0], result[0]);
            Assert.Equal(expected[1], result[1]);
        }
    }


    public class TwoSum
    {
        public static int[] ProcessResult(int[] input, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int[] result = new int[2];

            for(int i = 0; i < input.Length; i++)
            {
                var key = target - input[i];
                if (map.TryGetValue(key, out int index))
                {
                    result[0] = index;
                    result[1] = i;
                    return result;
                }

                map.Add(input[i], i);
            }

            return result;
        }
    }
}


