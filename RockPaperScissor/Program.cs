Console.WriteLine("Rock-Paper-Scissors!");
Console.WriteLine("Rules: Rock beats Scissor, Scissor beats Paper, Paper beats Rock");
Console.WriteLine("--------------------");

Console.WriteLine("Choose your move: (1) Rock, (2) Paper, (3) Scissors");
int playerMove = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{playerMove}");
// Console.WriteLine(playerMove);

Random random = new Random();
int computerMove = random.Next(1, 4);

//Store player's decision
string playerMoveString = "";
switch (playerMove)
{
    case 1:
        playerMoveString = "Rock";
        break;
    case 2:
        playerMoveString = "Paper";
        break;
    case 3:
        playerMoveString = "Scissors";
        break;
}

//Store computer's decision
string computerMoveString = "";
switch (computerMove)
{
    case 1:
        computerMoveString = "Rock";
        break;
    case 2:
        computerMoveString = "Paper";
        break;
    case 3:
        computerMoveString = "Scissors";
        break;
}

//Compute win or lose
if (playerMove == computerMove)
{
    Console.WriteLine("It's a draw!");
}
else if ((playerMove == 1 && computerMove == 3) || (playerMove == 2 && computerMove == 1) || (playerMove == 3 && computerMove == 2))
{
    Console.WriteLine("You won!");
}
else
{
    Console.WriteLine("You lost!");
}

Console.WriteLine($"You chose {playerMoveString}. The computer chose {computerMoveString}");