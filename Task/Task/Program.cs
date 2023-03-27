namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the firstnumber: ");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the secondnumber: ");
            int secondnumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the thirdnumber: ");
            int thirdnumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the fourthnumber: ");
            int fourthnumber = int.Parse(Console.ReadLine());
            int maxnumber = firstnumber;
            if (maxnumber < secondnumber)
            {
                maxnumber = secondnumber;
            }
            if (maxnumber < thirdnumber)
            {
                maxnumber = thirdnumber;
            }
            if (maxnumber < fourthnumber)
            {
                maxnumber = fourthnumber;
            }
            int minnumber = firstnumber;
            if (minnumber > secondnumber)
            {
                minnumber = secondnumber;
            }
            if (minnumber > thirdnumber)
            {
                minnumber = thirdnumber;
            }
            if (minnumber > fourthnumber)
            {
                minnumber = fourthnumber;
            }
            int res = maxnumber - minnumber;
            Console.WriteLine($"The max number: {maxnumber}");
            Console.WriteLine($"The min number: {minnumber}");
            Console.WriteLine($"Difference between the largest and the smallest of them: {res}");
        }
    }
}