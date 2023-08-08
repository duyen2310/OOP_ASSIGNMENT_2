using System;
using System.Diagnostics;
using System.Linq;
using static System.Console;
namespace COMP1202_Ass2_32
{
    public class Game
    {
        private int itemNumber;
        private string itemName;
        private int Price;
        private int UserRating;
        private int Quantity;

        public Game(int itemNumber, string itemName, int Price, int UserRating, int Quantity)
        {
            this.itemNumber = itemNumber;
            this.itemName = itemName;
            this.Price = Price;
            this.UserRating = UserRating;
            this.Quantity = Quantity;
        }

        public int getitemNumber()
        {
            return itemNumber;
        }

        public string getitemName()
        {
            return itemName;
        }

        public int getPrice()
        {
            return Price;
        }

        public int getUserRating()
        {
            return UserRating;
        }

        public int getQuantity()
        {
            return Quantity;
        }

        public override string ToString()
        {
            return $"{itemNumber},{itemName},{Price},{UserRating},{Quantity}";
        }
        public static bool CheckItemNumber(string str)
        {
            if(str.Length !=4)
            {
                return false;
            }
            else if(!int.TryParse(str, out _))
            {
                return false;
            }
            return true;
        }
        public static int checkPriceValidation()
        {
            Console.WriteLine("Please enter a price for the game.");
            string userInput = Console.ReadLine();
            while (!int.TryParse(userInput, out _))
            {
                Console.WriteLine("Invalid input. Please enter a valid number (double):");
                userInput = Console.ReadLine();
            }

            int validDouble = int.Parse(userInput);
            return validDouble;
        }
        static bool IsValidInput(string input)
        {
            if (int.TryParse(input, out int number) && number >= 1 && number <= 5)
            {
                return true;
            }
            return false;
        }
        public static int userRatingCheck()
        {
            Console.WriteLine("Please enter a number between 1 and 5: ");
            string userInput = Console.ReadLine();

            while (!IsValidInput(userInput))
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5:");
                userInput = Console.ReadLine();
            }
            int validNumber = int.Parse(userInput);
            return validNumber;
        }
        public static int GetValidIntegerFromUser()
        {
            Console.WriteLine("Please enter an integer: ");
            string userInput = Console.ReadLine();

            while (!int.TryParse(userInput, out int result))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer:");
                userInput = Console.ReadLine();
            }

            return int.Parse(userInput);
        }
        public static string ItemNameValidation()
        {
            Console.WriteLine("Please enter the name of the item");
            string userInput = Console.ReadLine();

            while (!string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("The text was empty. Please enter a valid name!!");
                userInput = Console.ReadLine();
            }
            return userInput;
        }
    }

    public class Storage
    {

        public Game[] games;
        public int maxPrice;

        public Storage(Game[] games)
        {
            this.games = games;
        }

        public void printGame()
        {
            foreach (Game game in games)
            {
                WriteLine("\nItem Number: ===> " + game.getitemNumber() + "\n");
                WriteLine("Item Name: ====> " + game.getitemName() + "\n");
                WriteLine("Price: =====> " + game.getPrice() + "\n");
                WriteLine("User Rating: =====> " + game.getUserRating() + "\n");
                WriteLine("Quantity: ========> " + game.getQuantity() + "\n\n");
            }
        }
        public static void addGameToStorage(Game game)
        {

        }


        public void SearchingOnMaxPrice()
        {
            Console.WriteLine("Games with price less than or equal to: \n ");
            maxPrice = Game.GetValidIntegerFromUser(); 
            foreach (Game game in games)
            {
                if (game.getPrice() <= maxPrice) 
                {
                    WriteLine(game.ToString());
                }
            }
        }
        public static void addProduct()
        {
            Console.WriteLine("We will create a new product!");
            Console.WriteLine("Do you know the item number? y/n");
            string user_choice;
            int item_number;
            string item_name;
            int item_price;
            int user_rating;
            int quantity;
            while (true)
            {
                // We keep promting the user to chose a valid option between yes or no
                user_choice = Console.ReadLine();
                if (user_choice == "y")
                {
                    Console.WriteLine("Please enter your 4-digit number");
                    string input = Console.ReadLine();
                    while (!Game.CheckItemNumber(input))
                    {
                        Console.WriteLine("Please enter a 4 digit number");
                        input = Console.ReadLine();
                    }
                    item_number = Convert.ToInt32(input);
                    break;
                }
                else if (user_choice == "n")
                {
                    Random random = new Random();
                    item_number = random.Next(1000, 10000);
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid option, y/n");
                }
            }
            Console.WriteLine("Please type in the item name");
            item_name = Game.ItemNameValidation();
            Console.WriteLine("Please enter the price for the item");
            item_price = Game.checkPriceValidation();
            Console.WriteLine("Please choose a rating for the game, 1-5");
            user_rating = Game.userRatingCheck();
            quantity = Game.GetValidIntegerFromUser();
            // Add the game remaining to the storage...
            Game new_game = new Game(item_number, item_name, item_price, user_rating, quantity);
            Storage.addGameToStorage(new_game); // to be fixed
        }
    }
    public class Program
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
                int chosen_option = Game.userRatingCheck();

                if (chosen_option == 1) {
                    Storage.addProduct();
                }
                
            }
        }
    }
}
