Console.Clear();
int dice1 = 0, dice2 = 0, dice3 = 0, dice4 = 0, dice5 = 0;
bool fixed1 = false, fixed2 = false, fixed3 = false, fixed4 = false, fixed5 = false;
string diceFixer = "l";
int nr1 = dice1, nr2 = dice2, nr3 = dice3, nr4 = dice4, nr5 = dice5;


void SortDice()
{
    do
    {
        if (dice1 > dice2) { nr1 = dice2; nr2 = dice1; dice1 = nr1; dice2 = nr2; }
        if (dice2 > dice3) { nr2 = dice3; nr3 = dice2; dice2 = nr2; dice3 = nr3; }
        if (dice3 > dice4) { nr3 = dice4; nr4 = dice3; dice3 = nr3; dice4 = nr4; }
        if (dice4 > dice5) { nr4 = dice5; nr5 = dice4; dice4 = nr4; dice5 = nr5; }

    }
    while (!(dice1 < dice2 && dice2 < dice3 && dice3 < dice4 && dice4 < dice5));
}

void RollDice()
{
    if (fixed1 == false)
    {
        dice1 = (Random.Shared.Next(1, 7));
    }
    if (fixed2 == false)
    {
        dice2 = (Random.Shared.Next(1, 7));
    }
    if (fixed3 == false)
    {
        dice3 = (Random.Shared.Next(1, 7));
    }
    if (fixed4 == false)
    {
        dice4 = (Random.Shared.Next(1, 7));
    }
    if (fixed5 == false)
    {
        dice5 = (Random.Shared.Next(1, 7));
    }
}

void PrintDice(int round)
{
    System.Console.WriteLine($"Dice roll #{round} of three: {dice1} with dice 1; {dice2} with dice 2; {dice3} with dice 3; {dice4} with dice 4; {dice5} with dice 5;");
    System.Console.WriteLine();
}

void FixDice()
{
    while (diceFixer != "r")
    {
        System.Console.WriteLine($"Which dice do you want to fix  or unfix ? ");
        diceFixer = Console.ReadLine()!;
        if (diceFixer == "r")
        {
            diceFixer = "r";
        }
        else if (diceFixer == "1")
        {
            if (fixed1 == false)
            {
                fixed1 = true;
                System.Console.WriteLine($"{dice1} / dice 1 is fixed");
            }
            else
            {
                fixed1 = false;
                System.Console.WriteLine($"{dice1}/ dice 1 is not fixed");
            }
        }
        else if (diceFixer == "2")
        {
            if (fixed2 == false)
            {
                fixed2 = true;
                System.Console.WriteLine($"{dice2}/ dice 2 is fixed");
            }
            else
            {
                fixed2 = false;
                System.Console.WriteLine($"{dice2}/ dice 2 is not fixed");
            }
        }
        else if (diceFixer == "3")
        {
            if (fixed3 == false)
            {
                fixed3 = true;
                System.Console.WriteLine($"{dice3} /dice 3 is fixed");
            }
            else
            {
                fixed3 = false;
                System.Console.WriteLine($"{dice3}/ dice 3 is not fixed");
            }
        }
        else if (diceFixer == "4")
        {
            if (fixed4 == false)
            {
                fixed4 = true;
                System.Console.WriteLine($"{dice4}/ dice 4 is fixed");
            }
            else
            {
                fixed4 = false;
                System.Console.WriteLine($"{dice4}/ dice 4 is not fixed");
            }
        }
        else if (diceFixer == "5")
        {
            if (fixed5 == false)
            {
                fixed5 = true;
                System.Console.WriteLine($"{dice5}/ dice 5 is fixed");
            }
            else
            {
                fixed5 = false;
                System.Console.WriteLine($"{dice5}/ dice 5 is not fixed");
            }
        }
    }
    diceFixer = "l";


}
void PlayGame(int player)
{
    System.Console.WriteLine();
    System.Console.WriteLine($"Player {player}");
    System.Console.WriteLine("=============");
    for (int i = 0; i < 3 && !(fixed1 && fixed2 && fixed3 && fixed4 && fixed5); i++)
    {
        RollDice();
        SortDice();
        PrintDice(i);
        if (i < 2)
        {
            FixDice();
        }
    }
}
PlayGame(1);
PlayGame(2);

System.Console.WriteLine($"The resoult is  {dice1}; {dice2}; {dice3}; {dice4}; {dice5};");



