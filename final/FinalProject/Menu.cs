using System;
using System.Threading.Tasks.Dataflow;
using System.Diagnostics;

public class Menu {
        
        public static void displayCardInfo() {
        var list = Card.cards;
        for (int i = 0; i < list.Count; i++){
            Console.WriteLine($"{i + 1}. Card Number: {list[i].getNum()} Pin: {list[i].getPin()} Checking: {list[i].getCheckingBalance()} Saving: {list[i].getSavingBalance()}");
        }
    }
    public static void Start() {

        Card.addCard("4716344890285187", 1111, "Gale", "Grey", 2000.00, 500.55);

        Console.WriteLine("Welcome to Ventura Corporation's ATM!");
        Console.WriteLine("Enter Card Number:");
        Console.WriteLine($"Account Info:");
        displayCardInfo();
        string debitCard = "";
        Card currentUser;
        // Check Card
        while(true)
        {
            try
            {
                var list = Card.cards;
                debitCard = Console.ReadLine();
                currentUser = list.FirstOrDefault(a => a.getNum() == debitCard);

                if (currentUser != null) 
                {
                    break;
                }
                else { Console.WriteLine("Card not recognized. Please try again.");}
            }
            catch { Console.WriteLine("Card not recognized. Please try again.");}
        }
        // Check Pin
        Console.WriteLine("Enter Pin: ");
        int userPin = 0;
        while (true)
            try {
                userPin = int.Parse(Console.ReadLine());
                var list = Card.cards;
                currentUser = list.FirstOrDefault(a => a.getNum() == debitCard);
                if(currentUser.getPin() == userPin) {
                    break;
                }
                else { Console.WriteLine("Wrong Pin. Please try again.");}
        }
        catch { Console.WriteLine("Wrong pin. Please try again."); }
    
    
        Console.WriteLine($"Welcome, {Card.getName()}");
        // Display ATM Menu
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Show Balance");
        Console.WriteLine("4. Exit");

        string choice = Console.ReadLine();
        int number = int.Parse(choice);

        if (number == 1) {
            Console.WriteLine("Where would you like to deposit your money?");
            Console.WriteLine("1. Checking Account");
            Console.WriteLine("2. Saving Account");

            string choice1 = Console.ReadLine();
            int account = int.Parse(choice1);

            if (account == 1) {
                Console.Write("How much money would you like to deposit?");
                double _deposit = Double.Parse(Console.ReadLine());
                Deposit myChecking = new checkingDeposit(_deposit);
                myChecking.checking(currentUser);
            }
            if (account == 2) {
                Console.Write("How much money would you like to deposit?");
                double _deposit = Double.Parse(Console.ReadLine());
                Deposit mySaving = new savingDeposit(_deposit);
                mySaving.savings(currentUser);
            }
        }

        if (number == 2) {
            Console.Write("Where would you like to withdraw your money from?");
            Console.WriteLine("1. Checking Account");
            Console.WriteLine("2. Saving Account");

            string choice1 = Console.ReadLine();
            int account = int.Parse(choice1);

            if (account == 1) {
                Withdrawal.checkingWithdrawal(currentUser);
            }
            if (account == 2) {
                Withdrawal.savingWithdrawal(currentUser);
            }
            
        }

        if (number == 3) {
            Balance.balance(currentUser);
            return;
        }

        if (number == 4) {
            return;
        }
    }
}