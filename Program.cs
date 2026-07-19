int Gambler;
int GeorgeDroyd;
bool playagain = true;
int GamblerWins = 0;
int GeorgeDroydWins = 0;
string answer;

Random random = new Random();

while (playagain)
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Lets go gambling!!!");

        Console.ReadKey();

        Gambler = random.Next(1, 8);
        switch (Gambler)
        {
            case 1:
                Console.WriteLine("U got 1");
                break;

            case 2:
                Console.WriteLine("U got 2");
                break;

            case 3:
                Console.WriteLine("U got 3");
                break;

            case 4:
                Console.WriteLine("U got 4");
                break;

            case 5:
                Console.WriteLine("U got 5");
                break;

            case 6:
                Console.WriteLine("U got 6");
                break;
            case 7:
                Console.WriteLine("SEVEN SEVEN SEVEN AYY");
                break;
        }

        Console.WriteLine("Now lets see what Clanker got");
        System.Threading.Thread.Sleep(1000);

        GeorgeDroyd = random.Next(1, 8);
        switch (GeorgeDroyd)
        {
            case 1:
                Console.WriteLine("Clanker got 1");
                break;

            case 2:
                Console.WriteLine("Clanker got 2");
                break;

            case 3:
                Console.WriteLine("Clanker got 3");
                break;

            case 4:
                Console.WriteLine("Clanker got 4");
                break;

            case 5:
                Console.WriteLine("Clanker got 5");
                break;

            case 6:
                Console.WriteLine("Clanker got 6");
                break;
            case 7:
                Console.WriteLine("SEVEN SEVEN SEVEN AYY");
                break;
        }
        if (Gambler > GeorgeDroyd)
        {
            Console.WriteLine("I JUST HIT A JACKPOTTTTTTT");
            GamblerWins++;
        }
        else if (GeorgeDroyd > Gambler)
        {
            Console.WriteLine("U suck");
            GeorgeDroydWins++;
        }
        else
        {
            Console.WriteLine("Let's larp");
            Console.WriteLine("Just this once");
        }
        Console.WriteLine("Gambler: " + GamblerWins + " Clanker: " + GeorgeDroydWins);
        Console.WriteLine();
    }
    if (GamblerWins > GeorgeDroydWins)
    {
        Console.WriteLine("From heaven to earth, I alone am the gambling one");
    }
    else if (GeorgeDroydWins > GamblerWins)
    {
        Console.WriteLine("Nah id win - famous last words");
    }
    else
    {
        Console.WriteLine("Stand proud, you are strong");
    }


    Console.Write("Hit the jackpot again? (Y/N): ");
    answer = Console.ReadLine();
    answer = answer.ToUpper();

    if (answer == "Y")
    {
        playagain = true;
    }
    else
    {
        playagain = false;
    }
}
Console.WriteLine("Roll again cowboy");

Console.ReadKey();
