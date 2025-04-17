namespace Algo.Search;

public static class LinearSearch
{
    public static int Search(int[]? array, int target)
    {
        if (array is null || array.Length == 0) return -1;
        if(target < array[0] || target > array[array.Length - 1]) return -1;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == target) return i;
        }
        
        return -1;
    }
    
    public static int[] TwoSum(int[]? array, int target)
    {
        if (array is null || array.Length == 0)
        {
            return new int[0];
        }

        int startIndex = 0;
        int endIndex = array.Length - 1;

        while (true)
        {
            if (array[startIndex] + array[endIndex] == target) return new int[] { array[startIndex], array[endIndex] };
            if (startIndex == endIndex) return new int[0];
            
            if (array[startIndex] + array[endIndex] < target)
            {
                startIndex += 1;
            }
            else
            {
                endIndex -= 1;
            }
        }
    }
}