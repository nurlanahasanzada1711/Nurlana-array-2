namespace array_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 18, 98, 45, 3, 67 };
            int max = a[0];
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != max && a[i] < min)
                {
                    min = a[i];
                }
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine($"{max}");
            Console.WriteLine($"{min}");
        }
    }
}