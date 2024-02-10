namespace DSATests
{

    // PROBLEM: Given a source string and a target string, find if a character in source string is present in the target string,
    // if it is present and it is in the same location in both source and target then return upper case.
    // if it is present but in different location then return lower case
    // if it is not present then return "-"
    // EXAMPLE: source: spain, target: spare then output should be SPA--
    // EXAMPLE: source: lame, target: male then output should be -AlE
    // ASSUMPTIONS: 1. both source and target strings are of same length
    //              2. character comparison is case insensitive
    public class Strings_002_CompareCharInTwoStrings
    {

        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { "spain", "spare", "SPA--" };
            yield return new object[] { "lame", "male", "lAmE" };
            yield return new object[] { "void", "drop", "-o-d" };
            yield return new object[] { "loomt", "croob", "-oO--" };
            yield return new object[] { "loop", "void", "-Oo-" };
            yield return new object[] { "", "void", "" };
            yield return new object[] { null, "void", "" };
            yield return new object[] { "toaster", "void", "" };

        }

        [Theory]
        [MemberData(nameof(GetData))]
        public void Test(string source, string target, string expected)
        {
            var result = CompareTheStrings(source, target);

            Assert.True(expected.Equals(result), $"Expected: {expected}, Actual: {result}");
        }



        private string CompareTheStrings(string source, string target)
        {

            if(string.IsNullOrWhiteSpace(source) || string.IsNullOrWhiteSpace(target)) 
            { 
                return string.Empty;
            }

            if (source.Length != target.Length)
            {
                return string.Empty;
            }

            int i = 0;
            var output = "";
            while(i < source.Length)
            {
                var s = source[i];
                var t = target[i];

                if(target.Contains(s) && s == t)
                {
                     output += Char.ToUpper(s);
                }
                else if (target.Contains(s) && s != t)
                {
                    output += Char.ToLower(s);
                }
                else
                {
                    output += "-";
                }

                i++;
            }

            return output;
        }
    }




}
