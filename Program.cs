// See https://aka.ms/new-console-template for more information

using static System.Console;

namespace COMP1201_Ass2_32
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

        public void SearchingOnMaxPrice()
        {
            Console.WriteLine("Games with price less than or equal to: \n ");
            maxPrice = Console.ReadLine();
            foreach (Game game in games)
            {
                if (game.getPrice() <= maxPrice)
                {
                    WriteLine(game.ToString());
    }
}
        }
    }

    public static void Main(string[] args)
{
    // Add games
    Storage hehe = new Storage(new Game[]
    {
            new Game(1212, "mario", 2, 2, 1),
            new Game(1414, "now", 2, 2, 1)
    });

    hehe.printGame();
}
}
