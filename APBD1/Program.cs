public class Program
{
    public static void Main()
    {
        Console.WriteLine(Average([1, 2, 3, 4]));
    }

    public static double Average(int[] numbers)
    {
        double sum = 0;
        numbers.Sum(x => sum += x);
        return sum / numbers.Length;
    }
}
