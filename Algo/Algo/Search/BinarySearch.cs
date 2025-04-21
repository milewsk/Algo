namespace Algo.Search;

public static class BinarySearch
{
    public static int Search(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int middle = (left + right) / 2;
            if (array[middle] == target) return middle;
            
            if (array[middle] < target)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }
        
        return -1;
    }
}