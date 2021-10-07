using System;
namespace Choose_Your_Class
{
    public class BagFund
    {
        public int Balance;

        public BagFund()
        {
            this.Balance = 5000;
        }

       public void CheckBalance()
        {
            Console.WriteLine("Your balance is $" + Balance + ".");
        }

        public void WashDishes()
        {
            Console.WriteLine("You helped out your local restaurant by washing dishes for a week. Here's $400.");
            Console.WriteLine("Your balance is now " + (this.Balance += 400) + ".");
        }

        public void MowLawn()
        {
            Console.WriteLine("It's not much, but it's honest work. Here's $300.");
            Console.WriteLine("Your balance is now " + (this.Balance += 300) + ".");
        }

        public void GarageSale()
        {
            Console.WriteLine("You don't have much left... but at least you can get your bag now! Here's $1,000");
            Console.WriteLine("Your balance is now " + (this.Balance += 1000) + ".");
        }

        public void ContractingWork()
        {
            Console.WriteLine("You were hired out this week using your special skills. Here's $2,000");
            Console.WriteLine("Your balance is now " + (this.Balance += 2000) + ".");
        }

        

        public void SellSoul()
        {
            Console.WriteLine("I can't believe you resorted to this...and for a Hermes bag.");
            Console.WriteLine("Sorry... but now that you've sold your soul, you've lost rights to owning anything...OH and your balance is now $" + (this.Balance = 0) + ".");
        }
    }
}
