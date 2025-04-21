using Algo.Search;

namespace Test.Search;

public class BinarySearchTest
{
    [Theory]
    [InlineData(new int[]{1,2,3,4,5,6}, 4 ,3)]
    public void SearchTest(int[] array, int target, int expected)
    {
        // Arrange 
        
        // Act
        var result = BinarySearch.Search(array, target);
        
        // Assert
        Assert.Equal(expected, result);
    }
}