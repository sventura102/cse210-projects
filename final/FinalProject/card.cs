using System;
using System.Threading.Tasks.Dataflow;
using System.Diagnostics;
public class Card {
    private static string _number;
    private static int _pin;
    private static string _firstName;
    private static string _lastName;
    private static double _checkingBalance;
    private static double _savingBalance;
    
    

    public Card(string number, int pin, string firstName, string lastName, double checking, double savings) {
        // Access private variables
        _number = number;
        _pin = pin;
        _firstName = firstName;
        _lastName = lastName;
        _checkingBalance = checking;
        _savingBalance = savings;
    }


    public static List<Card> cards = new List<Card>();
    
    //Able to add card details. Will manually insert in Menu.
    public static void addCard(string number, int pin, string firstName, string lastName, double checking, double savings) {
        Card card1 = new Card(number, pin, firstName, lastName, checking, savings);
        cards.Add(card1);
    }

    public string getNum() {
        // Get card number
        return _number;
    }

    public int getPin() {
        // Gets card's pin number
        return _pin;
    }

    public static string getName() {
        // Get users full name
        return $"{_firstName} {_lastName}";
    }

    public double getCheckingBalance() {
        // Get user balance
        return _checkingBalance;
    }
    public double getSavingBalance() {
        // Get user balance
        return _savingBalance;
    }

    // SETTERS

    public void setNum(string newCardNumber) {
        _number = newCardNumber;
    }

    public void setPin(int newPin) {
        _pin = newPin;
    }

    public void fullName(string newFirstName, string newLastName) {
        _firstName = newFirstName;
        _lastName = newLastName;
    }

    public void setCheckingBalance(double newChecking) {
        _checkingBalance = newChecking;
    }
    public void setSavingBalance(double newSaving) {
        _savingBalance = newSaving;
    }
}
