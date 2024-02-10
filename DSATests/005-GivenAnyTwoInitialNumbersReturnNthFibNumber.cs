namespace DSATests
{
    public class GivenAnyTwoInitialNumbersReturnNthFibNumber
    {
        // PROBLEM 1: Given any two numbers find Nth number in the Fibonacci series.
        // Explanation:
        // F(n)   = F(n-1) + F(n-2)
        // F(n-1) = F(n-2) + F(n-3)
        // .
        // .
        // .
        // F(3) = F(2) + F(1)
        // N2
        // N1



        // PROBLEM 2: Given any two numbers (N1, N2) find the sum of numbers in the Fibonacci series up to Nth number.
        // Shortcut trick: F(N+2) - N2

        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { 8, 5, 3, 13 };
            yield return new object[] { 8, 5, 4, 18 };
            yield return new object[] { 8, 5, 5, 31 };
            yield return new object[] { 8, 5, 6, 49 };
            yield return new object[] { 8, 5, 1, 8 };
            yield return new object[] { 8, 5, 2, 5 };
            yield return new object[] { 1, 3, 6, 18 };
            yield return new object[] { 0, 0, 5, 0 };
        }


        [Theory]
        [MemberData(nameof(GetData))]
        public void Test_GetFibNumber(int firstNumber, int secondNumber, int nthNumber, int expectedNumber)
        {
            var actual = GetFibNumber(firstNumber, secondNumber, nthNumber);

            Assert.Equal(expectedNumber, actual);

        }


        private int GetFibNumber(int firstNum, int secondNum, int nthNumber)
        {
            if (firstNum == 0 && secondNum == 0) return 0;
            
            if (nthNumber == 1)
            {
                return firstNum;
            }

            if (nthNumber == 2)
            {
                return secondNum;
            }

            return GetFibNumber(firstNum, secondNum, (nthNumber - 2)) + GetFibNumber(firstNum, secondNum, (nthNumber - 1));
        }

    }
}
