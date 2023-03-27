namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            string new_num = "";
            for (; num != 0;)
            {
                if (num % 2 != 0)
                {
                    num = num / 2;
                    new_num = new_num + "1";
                }
                if (num % 2 == 0)
                {
                    num = num / 2;
                    new_num = new_num + "0";
                }
            }
            for (int i = new_num.Length - 1; i >= 0; i--)
            {
                Console.Write(new_num[i]);
            }
            Console.WriteLine();
            Main(args);
        }
    }
}