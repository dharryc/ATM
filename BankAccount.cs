namespace ATM;

class BankAccount
{
    private double balance;

    bool hasSufficientFunds(double amount)
    {
        if (amount > balance) return false;

        return true;
    }

    bool Withdraw(double amount)
    {
        balance -= amount;

        return true;
    }

    double GetBalance()
    {
        return balance;
    }

    public BankAccount(int amount)
    {
        balance = amount;
    }
}