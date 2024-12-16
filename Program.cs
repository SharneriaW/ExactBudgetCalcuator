/*Sharneria Wright 06/05/23*/

using System;

class Project01
{
    static void Main(string[] args)

    {
        string username;
        username = "BLANK";

        Console.WriteLine($"{username} would like you to enter a monetary value:");

        string input = Console.ReadLine();
        decimal uservalue = decimal.Parse(input);


        // Calculate the number of shirts from total budget
        int num_shirts = (int)(uservalue / 19.85m);
        uservalue -= num_shirts * 19.85m;


        //Calculate the number of hats from leftover budget
        int num_hats = (int)(uservalue / 13.28m);
        uservalue -= num_hats * 13.28m;

        //Calculate the number pencils from leftover budget
        int num_pencils = (int)(uservalue / 0.12m);
        uservalue -= num_pencils * 0.12m;


        //Calculate the number of stickers from leftover budget
        int num_stickers = (int)(uservalue / 0.01m);
        uservalue -= num_stickers * 0.01m;


        //Total number of items purchased
        Console.WriteLine($" {username} purchased {num_shirts} shirts, {num_hats} hats , {num_pencils} pencils , and {num_stickers} stickers.");
        Console.WriteLine($"This is a total of {num_shirts + num_hats + num_pencils + num_stickers} items!");

    }

}