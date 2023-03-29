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
            
            int MaxNum = Math.Max(Math.Max(firstnumber, secondnumber), Math.Max(thirdnumber, fourthnumber));
            int MinNum = Math.Min(Math.Min(firstnumber, secondnumber), Math.Min(thirdnumber, fourthnumber));
            Console.WriteLine($"The max number: {MaxNum}");
            Console.WriteLine($"The min number: {MinNum}");
            Console.WriteLine($"Difference between the largest and the smallest of them: {MaxNum - MinNum}");
        }
    }
}