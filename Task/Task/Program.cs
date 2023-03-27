namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            int num = int.Parse(Console.ReadLine());
            /*for (int i = 1; i <= 100; i++)
            {
                if (num % i == 0)
                {
                    Console.Write($"{i} ");
                }
            }*/
            int i = 1;
            while (i <= 100)
            {
                if (num % i == 0)
                {
                    Console.Write($"{i} ");
                }
                i++;
            }
        }
    }
}