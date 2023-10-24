using System;
using System.Threading.Tasks.Dataflow;
using System.Diagnostics;
public class Withdrawal {

    public static void checkingWithdrawal(Card currentUser) {
        Console.Write("Checking: ");
        Console.WriteLine("How much money would you like to withdraw?");
        double withdraw = Double.Parse(Console.ReadLine());

        //check if user has enough $
        if (currentUser.getCheckingBalance() < withdraw)
        {
            Console.WriteLine("Not enough funds.");
        }
        else 
        {
            currentUser.setSavingBalance(currentUser.getCheckingBalance() - withdraw);
            Console.WriteLine("Withdrawing... \n Withdrawal Complete!");
        }
        return;
    }

    public static void savingWithdrawal(Card currentUser) {
        Console.Write("Saving: ");
        Console.WriteLine("How much money would you like to withdraw?");
        double withdraw = Double.Parse(Console.ReadLine());

        //check if user has enough $
        if (currentUser.getSavingBalance() > withdraw)
        {
            Console.WriteLine("Not enough funds.");
        }
        else 
        {
            currentUser.setSavingBalance(currentUser.getSavingBalance() - withdraw);
            Console.WriteLine("Withdrawing... \n Withdrawal Complete!");
        }
    }
}