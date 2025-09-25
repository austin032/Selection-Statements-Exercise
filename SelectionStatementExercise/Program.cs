namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 24;
            
            Console.WriteLine("Guess my favorite number:");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine($"The number you entered is too low!");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"The number you entered is too high!");
            }
            else
            {
                Console.WriteLine($"You guessed the number correctly!");
            }
        }
    }
}
