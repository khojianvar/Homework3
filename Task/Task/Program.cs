namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f1 = 0, f2 = 1, f3, number;
            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            if(number == 1)
            {
                Console.WriteLine($"{f1}");
            }else if(number == 2)
            {
                Console.WriteLine($"{f1} {f2}");
            }else if(number > 2) 
            {
                Console.Write($" {f1} {f2}");   
                for (int i = 2; i < number; ++i) 
                {
                    f3 = f1 + f2;
                    Console.Write($" {f3}");
                    f1 = f2;
                    f2 = f3;
                }
            }
        }
    }
}