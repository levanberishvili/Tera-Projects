using System;

class HomeWork5
{
    // მომხმარებელს უნდა ქონდეს შესაძლებლობა, რომ სამჯერ სცადოს რიცხვის გამოცნობა. 
    // თუ რიცხვი მესამე ცდის შემდეგ ვერ გამოიცნო უნდა გამოვიდეს შეტყობინება წაგების 
    // შესახებ. თუ გამოიცნო უნდა გამოვიდეს შეტყობინება მოგების შესახებ.

   static void Main(string[] args)
    {
        startGame();

    }

    static void startGame()
    {
        welcomingmessage();
        int randomnumber = getRandomNumber();

        int usersnumber;

        int counter = 1;

        while(counter <= 3)
        {
            usersnumber = enterNumber();

            if (randomnumber == usersnumber)
            {
                Console.WriteLine("You Have Won !!!");
                return;
            }
            else if (randomnumber > usersnumber)
            {
                Console.WriteLine("Your number is higher than random number.");
            }
            else if (randomnumber < usersnumber)
            {
                Console.WriteLine("Your number is Lower than random number.");
            }counter++;
          
        }
        Console.WriteLine("Game Over");

    }

    static void welcomingmessage()
    {
        Console.WriteLine("let's play A game. I have a hidden number for you.");
        Console.WriteLine("This number is between 0 to 20. Pleas guess it.");
        Console.WriteLine("You have three attempts.");

    }
    static int getRandomNumber()
    {
        return new Random().Next(0, 21);
    }

    static int enterNumber()
        {
        Console.Write("Pleas enter a number.");
        return Int32.Parse(Console.ReadLine());
    }

}

