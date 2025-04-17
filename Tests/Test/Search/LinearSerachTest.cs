using Algo.Search;

namespace Test.Search;

public class LinearSerachTest
{
    [Theory]
    [InlineData(new int[]{1,2,3,4,5,10}, 5)]
    [InlineData(new int[]{1,1,1,2}, 5)]
    public void TwoSumTest(int[]? numbers, int target)
    {   // Arrange
        
        // Act
        var result = LinearSearch.TwoSum(numbers, target);
        
        // Assert
        if (numbers is null || numbers.Length < 2 || result.Length < 2)
        {
            Assert.Equal(new int[0], result);
        }
        
        var sum = result[0] + result[1];
        if (sum != target)
        {
            Assert.Equal(new int[0], result);
        }
        
        Assert.Equal(target, sum);
    }
}