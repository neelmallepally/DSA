using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSATests
{
    public class Strings_001_ReverseAString
    {

        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { "TOM", "MOT" };
            yield return new object[] { null, null };
            yield return new object[] { "", "" };
            yield return new object[] { " ", " " };
            yield return new object[] { "dom", "mod" };
        }

        [Theory]
        [MemberData(nameof(GetData))]
        public void Test(string input, string expected)
        {
            var actual = Reverse(input);
            Assert.Equal(expected, actual);
        }


        private string Reverse(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;


            var output = new StringBuilder();

            for (int i = input.Length -1; i >= 0; i--)
            {
                output.Append(input[i]);
            }


            return output.ToString();
        }
    }
}
