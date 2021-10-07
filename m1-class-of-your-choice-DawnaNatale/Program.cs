using System;
using System.Collections.Generic;
using System.Linq;


namespace Choose_Your_Class
{
    class Program
    {
        public static Store Martin = new Store();
        public static Bag myBag = new Bag();
        public static BagFund myFund = new BagFund();


        public static void Main(string[] args)
        {

            bool keepThinking = true;
            while (keepThinking)
            {
                Console.Clear();
                Console.WriteLine("Hello! Welcome to the boujee shopping center!");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. View ALL bags and purchase");
                Console.WriteLine("2. Browse by BRAND and purchase");
                Console.WriteLine("3. Sell a bag");
                Console.WriteLine("4. Check balance of bag fund");
                Console.WriteLine("5. Complete a job for bag fund money");
                Console.WriteLine("6. View your bag collection");
                Console.WriteLine("Press Q to quit");
                string userChoice = Console.ReadLine().ToLower();
                switch (userChoice)
                {
                    case "1":
                        Purchase();
                        break;
                    case "2":
                        BrowseAndPurchase();
                        break;
                    case "3":
                        Sell();
                        break;
                    case "4":
                        CheckMyBalance();
                        break;
                    case "5":
                       MakeMoney();
                        break;
                    case "6":
                        ViewMyCollection();
                        break;
                    case "q":
                        keepThinking = false;
                        Console.WriteLine("Good bye!");
                        break;
                }

            }

        }

        

        public static void Purchase()
        {
            Console.Clear();

                Bag selectedBag = Martin.AllBagPurchase();
                if(myFund.Balance >= selectedBag.Price)
            {
                Console.WriteLine("Congratulations on your purchase of your new " + selectedBag.Brand + " " + selectedBag.Type + "!");
                Martin.UserCollection.Add(selectedBag);
                Martin.ListOfAllBags.Remove(selectedBag);
                myFund.Balance -= selectedBag.Price;
            }
            else
            {
                Console.WriteLine("Awkward... you don't have enough money to purchase this bag right now.");
            }
         
              

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void BrowseAndPurchase()
        {
            Console.Clear();

            Bag selectedBag = Martin.SelectedBagPurchase();
            if (myFund.Balance >= selectedBag.Price)
            {
                Console.WriteLine("Congratulations on your purchase of your new " + selectedBag.Brand + " " + selectedBag.Type + "!");
                Martin.UserCollection.Add(selectedBag);
                Martin.ListOfAllBags.Remove(selectedBag);
                myFund.Balance -= selectedBag.Price;
            }
            else
            {
                Console.WriteLine("Awkward... you don't have enough money to purchase this bag right now.");
            }
             

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();

        }
        public static void Sell()
        {
            Console.Clear();

            if(!Martin.UserCollection.Any())
            {
                Console.WriteLine("You don't have any bags in your collection to sell.");
            }
            else
            {
                Bag selectedBag = Martin.SellBag();
                Console.WriteLine("Thank you for selling your " + selectedBag.Brand + ". You now have $" + selectedBag.Price + " added to your account!");
                Martin.UserCollection.Remove(selectedBag);
                Martin.ListOfAllBags.Add(selectedBag);
                myFund.Balance += selectedBag.Price;
            }
           
            

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();

        }
        public static void CheckMyBalance()
        {
            Console.Clear();

            myFund.CheckBalance();

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();

        }
        public static void MakeMoney()
        {
            Console.Clear();
            Console.WriteLine("Please select a job that you want to complete: ");
            Console.WriteLine("1. Wash Dishes");
            Console.WriteLine("2. Mow Neighbor's Lawn");
            Console.WriteLine("3. Garage Sale");
            Console.WriteLine("4. Contracting Work");
            Console.WriteLine("5. Sell Soul");


            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    myFund.WashDishes();
                    break;
                case "2":
                    myFund.MowLawn();
                    break;
                case "3":
                    myFund.GarageSale();
                    break;
                case "4":
                    myFund.ContractingWork();
                    break;
                case "5":
                    myFund.SellSoul();
                    break;
            }


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();

        }

        public static void ViewMyCollection()
        {
            Martin.ViewUserCollection();

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }
    }
}
