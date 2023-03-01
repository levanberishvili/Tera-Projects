using System;

class HomeWork4
{
    // შევქმნათ მეთოდი, რომელსაც გადავცემთ ორ სრულ რიცხვს. მეთოდმა უნდა დააბრუნოს
    // ორი რიცხვის ჯამი. გამოვიყენოთ ეს ჯამი შესვლის წერტილის მეთოდის მეშვეობით კონსოლში.

    static void Main(string[] args)
    {
        Console.WriteLine(getIntegerSum(-400, 18));

        Console.WriteLine();
        getMaxMin();

        Console.WriteLine("Pleas Enter a Fruit:\n" +
            "apple, watermelon, melon, cherry, strawberry.");
        getFruit(Console.ReadLine());
    }

    static int getIntegerSum(int number1, int number2)
    {

        return number1 + number2;
    }


    // შევქმნათ მეთოდი. ვთხოვოთ მომხმარებელს შევიყვანოთ ოთხი ნებისმიერი ტიპის
    // რიცხვი ( ანუ არა მხოლოდ ინტეჯერი). მეთოდის ჯამში უნდა მოიძებნოს ამ ოთხი
    // რიცხვიდან ყველაზე დიდი და ყველაზე პატარა.მეთოდმა უნდა გამოიყვანოს კონსოლში
    // ეს ორი რიცხვი

    static void getMaxMin()
    {
        Console.Write("Pleas Enter a First Number  ");
        double numOne = double.Parse(Console.ReadLine());
        Console.Write("Pleas Enter a Second Number  ");
        double numTwo = double.Parse(Console.ReadLine());
        Console.Write("Pleas Enter a Third Number  ");
        double numThree = double.Parse(Console.ReadLine());
        Console.Write("Pleas Enter a Fourth Number  ");
        double numFour = double.Parse(Console.ReadLine());

        Console.WriteLine(numOne + " " + numTwo + " " + numThree + " " + numFour);

        double max = 0;
        double min = 0;

        if (numOne > numTwo)
        {
            max = numOne;

        }
        else max = numTwo;

        if (max < numThree) //  თუ მაქსი მეტია მესამე ციფრზე პროგრამა ავტომატურად ანგარიშობს ამას?
        {
            max = numThree;
        }
        if (max < numFour)
        {
            max = numFour;
        }

        Console.WriteLine("The Max Number Is    " + max);

        if (numOne < numTwo)
        {
            min = numOne;
        }
        else min = numTwo;

        if (min > numThree)
        {
            min = numThree;
        }

        if (min > numFour)
        {
            min = numFour;
        }
        Console.WriteLine("The min Number Is    " + min);
    }

    // შევქმნათ მეთოდი, რომელმაც უნდა მიიღოს მეორე მეთოდის მეშვეობით
    // მომხმარებლისგან ხილის დასახელება. ამ ხილის დასახელების მიღების შემდეგ Switch
    // ოპერატორის მეშვეობით ნახოს რომელი ხილია და გამოიყვანოს შესაბამისი შეტყობინება
    // თუ ესეთი ხილი არ მოიძებნა მომხმარებელმა უნდა მიიღოს შესაბამისი შეტყობინება.
    // ხილი: apple, watermelon, melon, cherry, strawberry.

    static void getFruit(string fruit)
    {
        switch (fruit)
        {
            case "apple":
                Console.WriteLine("This is an apple ");
                break;
            case "strawberry":
                Console.WriteLine("This is an strawberry");
                break;
            case "melon":
                Console.WriteLine("This is an melon");
                break;
            case "watermelon":
                Console.WriteLine("This is an watermelon");
                break;
            case "cherry":
                Console.WriteLine("This is an cherry");
                break;
            default:
                Console.WriteLine("You have entered wrong name");
                break;
        }


    }

}

