using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSATests
{
    public class _009_MEDIUM_MoveElementToEnd
    {

        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] {
                new List<int>() { 2, 1, 2, 2, 2, 3, 4, 2 },
                2,
                new List<int>() {1, 3, 4, 2, 2, 2, 2, 2}
            };

            yield return new object[] {
                new List < int >() { 2, 1, 2, 2, 2, 3, 4, 2 },
                5,
                new List < int >() { 2, 1, 2, 2, 2, 3, 4, 2 }
            };

            yield return new object[] {
                new List<int>(){ 2 },
                2,
                new List<int>() { 2 }
            };

            yield return new object[] {
                new List<int>(),
                2,
                new List<int>()
            };
        }


        [Theory]
        [MemberData(nameof(GetData))]
        public void Test(List<int> array, int toMove, List<int> expected)
        {
            var result = MoveElementToEnd(array, toMove);

            Assert.True(Enumerable.SequenceEqual(expected, result));
        }

        private List<int> MoveElementToEnd(List<int> array, int toMove)
        {
            int l = 0;
            int i = 0;

            while (l < array.Count)
            {
                int c = array[l];

                if (c == toMove)
                {
                    l++;
                }
                else
                {
                    array[l] = array[i];
                    array[i] = c;
                    i++;
                    l++;
                }
            }

            return array;
        }

    }
}
