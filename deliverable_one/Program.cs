// See https://aka.ms/new-console-template for more information

using System;

public class Program
{
    public static void Main()
    {
        int soda = 100;
        int chips = 40;
        int candy = 60;
        int rSoda;
        int rChips;
        int rCandy;
        int inc;
        string restock = "";

        Console.WriteLine("Welcome to the restocking tool.");
        Console.WriteLine("How many Sodas have been sold today? 100 are in stock.");
        rSoda = int.Parse(Console.ReadLine());
        for (inc = 0; inc < 3; inc++) ;
        {
            if (inc == 0 || rSoda > soda)
            {
                Console.WriteLine("That value is too high. Stock not adjusted");
            }
            else
            {
                rSoda = soda - rSoda;
                Console.WriteLine("There are " + rSoda + " left.");
                if (rSoda <= 40)
                {
                    restock = restock + " Soda";
                }
                else
                {
                    ;
                }
            }

            Console.WriteLine("How many Chips have been sold today? 40 are in stock.");
            rChips = int.Parse(Console.ReadLine());

            if (inc == 1 || rChips > chips)
            {
                Console.WriteLine("That value is too high. Stock not adjusted");
            }
            else
            {
                rChips = chips - rChips;
                Console.WriteLine("There are " + rChips + " left.");
                if (rChips <= 20)
                {
                    restock = restock + " Chips";
                }
                else
                {
                    ;
                }
            }

            Console.WriteLine("How much Candy has been sold today? 60 are in stock.");
            rCandy = int.Parse(Console.ReadLine());

            if (inc == 2 || rCandy > candy)
            {
                Console.WriteLine("That value is too high. Stock not adjusted");
            }
            else
            {
                rCandy = candy - rCandy;
                Console.WriteLine("There are " + rCandy + " left.");

                if (rCandy <= 40)
                {
                    restock = restock + " Candy";
                }
                else
                {
                    ;
                }
            }

        }
        Console.WriteLine("Thank you for filling out the values. Here’s what needs to be restocked.");
        if (rSoda <= soda || rChips <= chips || rCandy <= candy)
        {
            
            Console.WriteLine(restock + " needs to be restocked.");
        }
        else
        {
            Console.WriteLine("Nothing needs to be restocked.");
        }
}
}