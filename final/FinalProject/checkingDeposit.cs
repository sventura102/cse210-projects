public class checkingDeposit : Deposit {
    

    public checkingDeposit(double deposit) : base(deposit) {
        _deposit = deposit;
    }

    public override void checking(Card currentUser) {
        currentUser.setCheckingBalance(currentUser.getCheckingBalance() + _deposit);
        Console.WriteLine($"Thank you! Here is your new Checking balance ${currentUser.getCheckingBalance()}");
    }

    public override void savings(Card currentUser)
    {
        throw new NotImplementedException();
    }


}