using System;
using System.Collections.Generic;
using System.Threading;

class MainMenu
{
    public const double PEAR_PRICE = 3, APPLE_PRICE = 5;
    public static double totalSales = 0;
    public static int appleCount = 0, pearCount = 0;
    public static void Menu()
    {
        for( ; ;)
        {
            Console.Clear();
            OptionMessage("1", "Open Menu");
            OptionMessage("2", "Summary Sales");
            OptionMessage("3", "Quit");
            Console.ReadKey(true);
            string ? option = Console.ReadLine();
            if(option == "1")
            {
                OpenMenu();
            }
            else if(option == "2")
            {
                OpenSummary();
            }
            else if(option == "3")
            {
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid! Choose other option");
                Thread.Sleep(1500);
            }
        }
        
    }
    public static void OpenSummary()
    {
        Console.Clear();
        Console.WriteLine("We sold: "  +  appleCount + " apples and " + pearCount + " pears");
        Console.WriteLine("Total sales today: " + totalSales);
        OptionMessage("1", "Open Menu");
        OptionMessage("2", "Quit");
        Console.ReadKey(true);
        string ? option = Console.ReadLine();
        if(option == "1")
        {
            Menu();
        }
        else if(option == "2")
        {
            System.Environment.Exit(0);
        }

    }
    public static void OpenMenu()
    {
        for(; ;)
        {
            Console.Clear();
            OptionMessage("1", "Apple for $" + APPLE_PRICE);
            OptionMessage("2", "Pear for $" + PEAR_PRICE);
            OptionMessage("3", "Return to home");
            Console.ReadKey(true);
            string ? option = Console.ReadLine();
            if(option == "1")
            {
                Console.WriteLine("Thank you, come again!");
                appleCount++; 
                totalSales += APPLE_PRICE;
                Thread.Sleep(1000);

            }
            else if(option == "2")
            {
                Console.WriteLine("Thank you, come again");
                pearCount++; 
                totalSales += PEAR_PRICE;
                Thread.Sleep(1000);
            }
            else if(option =="3")
            {
                Menu();
            }
            else{
                Console.WriteLine("Invalid! Try again!");
                Thread.Sleep(1500);
            }
        }
    }
    
    public static void OptionMessage(string option, string message)
    {
        Console.Write(option);
        Console.WriteLine(": " + message);
    }   
}