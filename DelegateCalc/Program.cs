namespace DelegateCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input: 'type a b'");
                Console.WriteLine("Implemented types: add, sub, mul, pow, root, div");
                string[] input = Console.ReadLine().Split(" ");
                Calculator calculator = new Calculator();
                
                try
                {
                    Console.WriteLine(calculator.Calculate(input));
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
