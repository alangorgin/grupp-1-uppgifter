using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Datastruktur_8
{
    public static void Start()
    {
        // Datastruktur uppgfit 8
        List<String> myList = new List<String>();
        char input = '0';
        char[] validInputs = ['1', '2', '3', '4', '5'];

        while (input != '5')
        {
            Console.WriteLine("[1] Add an item to the list.");
            Console.WriteLine("[2] Remove an item from the list.");
            Console.WriteLine("[3] Search for an item in the list.");
            Console.WriteLine("[4] Display list.");
            Console.WriteLine("[5] Exit program.");

            input = Convert.ToChar(Console.ReadLine() ?? "");

            if (!validInputs.Contains(input))
            {
                Console.WriteLine("Invalid input, try again.");
                continue;
            }

            if (input == '1')
            {
                Console.WriteLine("Enter item to add:");
                String itemInput = Console.ReadLine() ?? "";
                myList.Add(itemInput);
                Console.WriteLine($"Item {itemInput} has been added.");
                continue;
            }

            if (input == '2')
            {
                Console.WriteLine("Enter item to remove:");
                String itemInput = Console.ReadLine() ?? "";
                myList.Remove(itemInput);
                Console.WriteLine($"Item {itemInput} has been removed.");
                continue;
            }

            if (input == '3')
            {
                Console.WriteLine("Enter item to search:");
                String itemInput = Console.ReadLine() ?? "";
                if (myList.Contains(itemInput) == true)
                {
                    Console.WriteLine($"Item {itemInput} is on index {myList.IndexOf(itemInput)}");
                }
                else
                {
                    Console.WriteLine($"Item {itemInput} is not available.");
                }
                continue;
            }

            if (input == '4')
            {
                foreach (String item in myList)
                {
                    Console.WriteLine(item);
                }
                continue;
            }
        }
    }



}