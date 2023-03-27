namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            int factorial = 1;
            int new_num = num;
            /*for (;num!=0;)
            {
                factorial *= num;
                num -= 1;
            }*/
            while (num != 0)
            {
                factorial *= num;
                num -= 1;
            }
            Console.WriteLine($"Factorial of {new_num} is: {factorial}");
        }
    }
}