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

            while (IsValidInput(userInput))
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

            while (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("The text was empty. Please enter a valid name!!");
                userInput = Console.ReadLine();
            }
            return userInput;
        }