namespace Algo.Sorting;

public static class BubbleSort
{
    public static int[]? Sorting(int[]? numbers)
    {
        if(numbers == null) return null;
        if(numbers.Length == 1) return numbers;

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[i] < numbers[j])
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            } 
        }
        
        return numbers;
    }
}