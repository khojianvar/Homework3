namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter which display a multiplication table do want: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
        }
    }
}