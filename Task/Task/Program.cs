namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter starting range: ");
            int srange = int.Parse(Console.ReadLine());
            Console.Write("Enter ending range: ");
            int erange = int.Parse(Console.ReadLine());
            Console.Write($"Result: The Perfect numbers within {srange} and {erange} are:");
            for (int i = srange; i <= erange; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
    }
}