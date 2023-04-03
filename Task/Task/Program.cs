namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int previusNumber = int.Parse(Console.ReadLine());
            int sequence = 1;
            int longSequence = 0;
            int numberOfLongSequence = previusNumber;
            for (;true;)
            {
                Console.Write("Enter the number: ");
                int currentNumber = int.Parse(Console.ReadLine());
                if(previusNumber == currentNumber)
                {
                    sequence++;
                }
                else if (currentNumber == 0)
                {
                    break;
                }
                else 
                {
                    if(longSequence<sequence)
                    {
                        longSequence = sequence;
                        numberOfLongSequence = previusNumber;
                    }
                    sequence = 1;
                }
                previusNumber = currentNumber;
            }
            Console.WriteLine($"Longest sequence: {longSequence} times number {numberOfLongSequence}");
        }
    }
}