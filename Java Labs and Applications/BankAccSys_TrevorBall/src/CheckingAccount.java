public class CheckingAccount extends BankAccount
{
    private double overdraftLimit;

    public CheckingAccount(String accNum, String name, String email, String phone, double balance, double limit)
    {
        super(accNum, name, email, phone, balance);
        this.overdraftLimit = limit;
    }

    @Override
    public void withdraw(double amount)
    {
        if(amount > 0 && amount <= (balance + overdraftLimit))
            balance -= amount;
    }

    @Override
    public String displayAccountInfo()
    {
        return super.displayAccountInfo() + "\nOverdraft Limit: " + overdraftLimit;
    }
}