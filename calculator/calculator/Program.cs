namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("first number");
            string firstInput = Console.ReadLine();
            Console.WriteLine("second number");
            string secondInput = Console.ReadLine();
            Console.WriteLine("type of operation (+, -, *, /)");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Result: {Convert.ToDouble(firstInput) + Convert.ToDouble(secondInput)}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {Convert.ToDouble(firstInput) - Convert.ToDouble(secondInput)}");
                    break;
                case "*":
                    Console.WriteLine($"Result: {Convert.ToDouble(firstInput) * Convert.ToDouble(secondInput)}");
                    break;
                case "/":
                    Console.WriteLine($"Result: {Convert.ToDouble(firstInput) / Convert.ToDouble(secondInput)}");
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;

            }
        }
    }
}