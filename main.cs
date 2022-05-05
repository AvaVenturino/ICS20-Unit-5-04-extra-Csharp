// Created by: Ava Venturino
// Created on: April 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        var day = Console.ReadLine();
        int age;
        
        Console.Write("Determine whether a person gets a student discount to a museum");
        Console.WriteLine("");
        Console.Write("Enter the day of the week : ");
        day = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("Enter age : ");
        age = Convert.ToInt32(Console.ReadLine());
        if (( day == "Tuesday" || day == "Thursday" ) || (age > 12 && age < 21)) 
            Console.WriteLine("You're eligible for student pricing");
         else 
            Console.WriteLine("You must pay regular price");
        
        Console.WriteLine("\nDone.");
    }
}