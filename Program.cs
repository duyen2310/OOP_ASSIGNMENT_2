// See https://aka.ms/new-console-template for more information

using static System.Console;
namespace COMP1202_Ass2_32{
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

        public string ToString()
        {
            return itemNumber + "," + itemName + "," + Price + "," + UserRating + "," + Quantity;
        }

    }

    public static void Main(string[] args){
         
    }

    static void printGame(Game[] gameList)
        {
            foreach (Game g in gameList)
            {
                WriteLine("\nItem Number: ===> " + g.getitemNumber() + "\n");
                WriteLine("Item Name: ====> " + g.getitemName() + "\n");
                WriteLine("Price: =====> " + g.getPrice() + "\n");
                WriteLine("User Rating: =====> " + g.getUserRating() + "\n");
                WriteLine("Quantity: ========> " + g.getQuantity() + "\n\n");
            }



        } 
}