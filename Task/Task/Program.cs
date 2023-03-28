namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            int nDivision = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    nDivision++;
                }
            }
            if (nDivision == 1)
            {
                Console.WriteLine($"{number}-isnt prime and isnt not prime!");
            }
            else if (nDivision == 2)
            {
                Console.WriteLine($"{number}-is a prime number");
            }
            else
            {
                Console.WriteLine($"{number}-is not a prime number");
            }
        }
    }
}