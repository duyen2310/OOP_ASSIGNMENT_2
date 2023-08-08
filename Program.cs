using System;
using static System.Console;
namespace COMP1202_Ass2_32
{

    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our store");
            while (true)
            {
                // First we ask the user what they would like to do.
                Console.WriteLine("Welcome to our store. Please chose on of the following options");
                Console.WriteLine("1. To add a new product");
                Console.WriteLine("2. To search based on an item number");
                Console.WriteLine("3. To search based on maximum price");
                Console.WriteLine("4. Statistical analysis");
                Console.WriteLine("5. To exit");
                Console.WriteLine("Pleasse chose one of the respective options: 1, 2, 3, 4, 5");
                int chosen_option = Convert.ToInt32(Console.ReadLine());
                switch (chosen_option)
                {
                    case 1:
                        Console.WriteLine("We will create a new game in the inventory!");
                        Console.WriteLine("Do you want to type in the item number, or have it generated? y/n");
                        string user_choice;
                        int randomNumber;
                        while (true)
                        {
                            // We keep promting the user to chose a valid option between yes or no
                            user_choice = Console.ReadLine();
                            if (user_choice == "y")
                            {
                                Console.WriteLine("Please enter a 4-digit number");
                                string input = Console.ReadLine();
                                while (!Game.CheckItemNumber(input))
                                {
                                    Console.WriteLine("Please enter a 4 digit number");
                                    input = Console.ReadLine();
                                }
                                break;
                            }
                            else if (user_choice == "n")
                            {
                                Random random = new Random();
                                randomNumber = random.Next(1000, 10000);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid option, y/n");
                            }
                        }
                        Console.WriteLine("Please type in the item name");



                }
            }
        }

        static void printGame(Game[] gameList)
        {
            foreach (Game g in gameList)
            {
                WriteLine("\nItem Number: ===> " + g.getItemNumber() + "\n");
                WriteLine("Item Name: ====> " + g.getItemName() + "\n");
                WriteLine("Price: =====> " + g.getPrice() + "\n");
                WriteLine("User Rating: =====> " + g.getUserRating() + "\n");
                WriteLine("Quantity: ========> " + g.getQuantity() + "\n\n");
            }
        }

    }
}
