namespace DSATests
{
    public class BuyLowSellHigh
    {

        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { new[] { 7, 1, 5, 3, 6, 4 }, 5 };
            yield return new object[] { new[] { 7, 6, 5 }, 0 };
            yield return new object[] { new[] { 1, 2, 3 }, 2 };
            yield return new object[] { new[] { 7, 5, 3, 9, 1, 11 }, 10 };
            yield return new object[] { new[] { 0 }, 0};
            yield return new object[] { null, 0 };

        }

        [Theory]
        [MemberData(nameof(GetData))]
        public void Test(int[] input, int expectedProfit)
        {
            var result = ReturnMaxMinValues(input);

            Assert.Equal(expectedProfit, result);
        }


        private int ReturnMaxMinValues(int[] input)
        {

            if (input == null || input.Length <= 1)
                return 0;

            int l = 0;
            int r = 1;

            int maxProfit = 0;

            while( r < input.Length )
            {
                if (input[r] > input[l] )
                {
                    int profit = input[r] - input[l];
                    maxProfit = Int32.Max(maxProfit, profit);
                }
                else
                {
                    l = r;
                }

                r++;
            }


            return maxProfit;
        }
    }
}
