Console.WriteLine("Roll the Dice! A dice rollin application");
Console.WriteLine("\n The dice has 6 sides");
Console.WriteLine("\n Press any key to roll the die. Good luck!");
// Console.ReadKey();

ConsoleKey keyPressed = Console.ReadKey().Key;
while (keyPressed != ConsoleKey.Escape)
{
    Console.Clear();
    int randomDiceRoll = 0;
    Random random = new Random();
    randomDiceRoll = random.Next(1, 7);

    Console.WriteLine("You rolled a " + randomDiceRoll);
    keyPressed = Console.ReadKey().Key;
}

