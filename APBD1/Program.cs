public class Program
{
    public static void Main()
    {
        Console.WriteLine(Average([1, 2, 3, 4]));
        Console.WriteLine(Max([1, 2, 5, 3, 4]));
    }

    public static double Average(int[] numbers)
    {
        double sigma = 0;
        numbers.Sum(x => sigma += x);
        return sigma / numbers.Length;
    }

    public static int Max(int[] numbers)
    {
        int max = 0;
        foreach (var item in numbers)
        {
            if(item > max)
                max = item;
        }
        return max;
    }
}
