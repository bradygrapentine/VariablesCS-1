using System;

namespace VariablesCS
{
    class Program
    {
        static void VariableMethods()
        {
            double numberOfCupsOfCoffee = 3;
            string fullName = "Brady Steven Grapentine";
            var today = DateTime.Now;
            Console.WriteLine(numberOfCupsOfCoffee + ", " + fullName + ", " + today.ToString("d"));
            Console.Write("What is your first name? ");
            var name = Console.ReadLine();
            if (name == "Alice")
            {
                Console.WriteLine($"Listen {name}, strange women lying in ponds distributing swords is no basis for a system of government. Supreme executive power derives from a mandate from the masses, not from some farcical aquatic ceremony.");
            }
            else
            {
                Console.WriteLine($"It's nice to meet you, {name}!");
            }
            Console.Write("Enter a number: ");
            var firstNumberAsString = Console.ReadLine();
            Console.Write("Enter another number: ");
            var secondNumberAsString = Console.ReadLine();

            var firstOperand = double.Parse(firstNumberAsString);
            var secondOperand = double.Parse(secondNumberAsString);

            var sum = firstOperand + secondOperand;
            var difference = firstOperand - secondOperand;
            var product = firstOperand * secondOperand;
            var quotient = firstOperand / secondOperand;
            var remainder = firstOperand % secondOperand;

            Console.WriteLine($"If you add {firstOperand} and {secondOperand} you get {sum}!");
            Console.WriteLine($"If you subtract {secondOperand} from {firstOperand} you get {difference}!");
            Console.WriteLine($"If you divide {firstOperand} by {secondOperand} you get {quotient}!");
            Console.WriteLine($"If you multiply {firstOperand} by {secondOperand} you get {product}!");
            Console.WriteLine($"The remainder after {firstOperand} is divided by {secondOperand} is {remainder}!");
        }

        static void Main(string[] args)
        {
            VariableMethods();
        }
    }
}