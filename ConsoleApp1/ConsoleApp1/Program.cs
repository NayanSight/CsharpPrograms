internal class Program
{
    


    static void Main()
    {
        int[] array = { 1, 2, 3, 4 };
        GeneratePermutations(array, 0, array.Length - 1);
    }

    static void GeneratePermutations(int[] array, int start, int end)
    {
        if (start == end)
        {
            PrintArray(array);
        }
        else
        {
            for (int i = start; i <= end; i++)
            {
                Swap(ref array[start], ref array[i]);
                GeneratePermutations(array, start + 1, end);
                Swap(ref array[start], ref array[i]); // backtrack
            }
        }
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}

