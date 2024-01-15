namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //EXERCISE 1
            int a = 17;
            int b = 4;

            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a} + {b} is {sum}.");
            Console.WriteLine($"{a} - {b} is {difference}.");
            Console.WriteLine($"{a} x {b} is {product}.");
            Console.WriteLine($"{a} ÷ {b} is {quotient}, with a remainder of {remainder}.");

            Console.WriteLine();
            Console.WriteLine();

            //EXERCISE 2
            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of your circle is {AreaOfCircle(radius)}.");
            Console.WriteLine($"If that is too many decimal places, you can round to {Math.Round(AreaOfCircle(radius))}.");
        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
