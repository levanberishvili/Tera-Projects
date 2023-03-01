using System;

class firstlesson
{
    static void Main()
    {
        // Task N1

        Console.Write("Pleas Enter Your Name ");
        String Name = Console.ReadLine();
        Console.Write("Pleas Enter Your Surname ");
        String SurName = Console.ReadLine();
        Console.Write("Pleas Enter Your Age ");
        String Age = Console.ReadLine();
        Console.Write("Pleas Enter Your Height ");
        String Height = Console.ReadLine();
        Console.Write("Pleas Enter Your Weight ");
        String Weight = Console.ReadLine();
        Console.WriteLine(Name + " " + SurName + " " + Age + " " + Height + " " + Weight);


        //Task N2


        int x = 3;
        int z = 4;
        int y = 2;
        int d = x + (z * y);
        Console.WriteLine(d);

        //Task N3

        int weight = 120;
        Double height = 1.85;
        Console.WriteLine(weight / height);

        //Taks N4

        Console.WriteLine("   |   |   ");
        Console.WriteLine(" 1 | 2 | 3 ");
        Console.WriteLine("___|___|___");
        Console.WriteLine("   |   |   ");
        Console.WriteLine(" 4 | 5 | 6 ");
        Console.WriteLine("___|___|___");
        Console.WriteLine("   |   |   ");
        Console.WriteLine(" 7 | 8 | 9 ");
        Console.WriteLine("   |   |   ");
    }
}

