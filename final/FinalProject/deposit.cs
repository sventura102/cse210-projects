using System;
public abstract class Deposit {

    public double _deposit;

    public Deposit(double deposit) {
        _deposit = deposit;
    }

    public abstract void checking(Card currentUser);

    public abstract void savings(Card currentUser);

}