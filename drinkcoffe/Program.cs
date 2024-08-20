using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<string> coffeeList = new List<string>();

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"{i}. kahve ismini giriniz: ");
            string coffeeName = Console.ReadLine();
            coffeeList.Add(coffeeName);
        }

        Console.WriteLine("\nGirdiğiniz kahve isimleri:");
        foreach (string coffee in coffeeList)
        {
            Console.WriteLine(coffee);
        }
    }
}



