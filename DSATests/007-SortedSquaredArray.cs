namespace DSATests
{
    public class _007_SortedSquaredArray
    {
        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { new[] { 1, 2 }, new[] { 1, 4 } };
            yield return new object[] { new[] { -2, 1 }, new[] { 1, 4 } };
        }


        [Theory]
        [MemberData(nameof(GetData))]
        public void Test(int[] input, int[] expected)
        {
            var actual = SquareNumbs(input);

            Assert.True(Enumerable.SequenceEqual(expected, actual));
        }

        private int[] SquareNumbs(int[] input)
        {
            int[] output = new int[input.Length];

            int start = 0;
            int end = input.Length - 1;
            int i = end;

            while (i >= 0)
            {
                int min = input[start];
                int max = input[end];

                if (Math.Abs(max) >= Math.Abs(min))
                {
                    output[i] = max * max;
                    end -= 1;
                }
                else
                {
                    output[i] = min * min;
                    start += 1;
                }

                i--;
            }

            return output;
        }

    }
}
