public class savingDeposit : Deposit {
    public savingDeposit(double deposit) : base(deposit) {
        _deposit = deposit;
    }

    public override void checking(Card currentUser)
    {
        throw new NotImplementedException();
    }

    public override void savings(Card currentUser) {
        currentUser.setSavingBalance(currentUser.getSavingBalance() + _deposit);
        Console.WriteLine($"Thank you! Here is your new Saving balance ${currentUser.getSavingBalance()}");
    }
}