using Algo.Sorting;

namespace Test.Sorting;

public class BubbleSortTest
{
    [Theory]
    [InlineData(new int[]{1,2,5,4,3})]
    [InlineData(new int[]{1,2,3,4,5})]
    [InlineData(null)]
    public void Test(int[]? array)
    {
        var result = BubbleSort.Sorting(array);

        if (array == null)
        {
            Assert.Null(result);
        }

        if (array?.Length == 1)
        {
            Assert.Equal(array, result);
        }

        if (array?.Length > 1)
        {
            Assert.Equal(new int[]{1,2,3,4,5}, result);
        }
        
    }
}