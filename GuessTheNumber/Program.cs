public class Program
{
    int secretNumber = 0;
    int guess = 0;
    int tries = 0;
    static void Main()
    {
        Program program = new Program(); //create an instance reference of our Program class. Create an object reference of the Program class?
        Random random = new Random(); //initialise an instance of the Random class
        program.secretNumber = random.Next(1,10);
        Console.WriteLine("I'm guessing a number between 1 and 10. Can you guess what number it is?");
        program.playerGuess();
    }
    void playerGuess()
    {
        guess = Convert.ToInt32(Console.ReadLine());
        tries++;
        Console.WriteLine(guess);
        
        if (guess < secretNumber)
        {
            Console.WriteLine("No the number I am thinking of is higher than " + guess + ".Can you guess what it is?");
            playerGuess();
        }
        else if (guess > secretNumber)
        {
            Console.WriteLine("No the number I am thinking of is lower than " + guess + ".Can you guess what it is?");
            playerGuess();
        }
        else
        {
            Win();
        }
    }
    void Win()
    {
        Console.WriteLine("Well done! Your guess of " + guess + " matched with the secret number of " + secretNumber + "! Only took you " + tries + " tries.");
    }

}