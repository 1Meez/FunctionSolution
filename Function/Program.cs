namespace Function
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());


            Console.WriteLine($"Addition: {num1} + {num2} = {Calculate.Calculator(num1, num2)}");
            Console.WriteLine($"Subtraction: {num1} - {num2} = {Calculate.Calculator(num1, num2, "-")}");
            Console.WriteLine($"Multiplication: {num1} * {num2} = {Calculate.Calculator(num1, num2, "*")}");
            Console.WriteLine($"Division: {num1} / {num2} = {Calculate.Calculator(num1, num2, "/")}");
        }
    }
}
