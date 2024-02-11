namespace DSATests.Algorithms
{
    public class BinarySearch
    {

        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { new[] { 1, 2, 3, 4, 5 }, 3, 3 };
            yield return new object[] { new[] { 1, 2, 4, 5 }, 3, 0 };
            yield return new object[] { new[] { 1, 2, 4, 5 }, 5, 5 };
            yield return new object[] { new[] { 1, 2, 4, 5 }, 1, 1 };
            yield return new object[] { new[] { 1, 2, 4, 5 }, 10, 0 };
        }

        [Theory]
        [MemberData(nameof(GetData))]
        public void FindNumberOfSteps(int[] inputArray, int numberToFind, int expected)
        {
            var actual = BinarySearchSteps(inputArray, numberToFind);

            Assert.Equal(expected, actual);
        }


        private int BinarySearchSteps(int[] inputArray, int numberToFind)
        {
            int low = 0;
            int high = inputArray.Length;

            if (numberToFind > inputArray[high -1] || numberToFind < inputArray[low])
            {
                return 0;
            }

            while(low <= high)
            {
                int mid = (low + high) / 2;

                if (inputArray[mid] == numberToFind)
                {
                    return inputArray[mid];
                }
                else if (numberToFind > inputArray[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
              
            }


            return 0;
        }



        private int[] ReturnArrayOfNumber(int numberOfElements)
        {
            int[] result = new int[numberOfElements];

            for(int i = 0; i < numberOfElements; i++)
            {
                result[i] = i+1;
            }

            return result;
        }
    }
}
