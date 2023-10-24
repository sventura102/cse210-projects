using System;
using System.Threading.Tasks.Dataflow;
using System.Diagnostics;
public class Balance {
    public static void balance(Card currentUser) {
        Console.WriteLine($"Checking: ${currentUser.getCheckingBalance()}");
        Console.WriteLine($"Saving: ${currentUser.getSavingBalance()}");
    }
}