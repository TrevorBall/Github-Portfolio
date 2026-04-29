/*
 * 
 * 
 * Trevor Ball
 * CPT-236-A01H Java
 * Lab 8 - Lab 7 but error handling
 * 
 * 
 */
package Bank;

public class CheckingAccount extends bankAccount
{
    private double overdraftLimit;

    public CheckingAccount(String accountNumber, String ownerName, String email,
                           String phoneNumber, double balance, double overdraftLimit)
    {
        super(accountNumber, ownerName, email, phoneNumber, balance);

        // helps prevent negative overdraft
        if(overdraftLimit < 0)
            this.overdraftLimit = 0;
        else
            this.overdraftLimit = overdraftLimit;
    }

    @Override
    public boolean withdraw(double amount)
    {
        if(amount > 0 && amount <= (balance + overdraftLimit))
        {
            balance -= amount;
            return true;
        }
        return false;
    }

    @Override
    public String displayAccountInfo()
    {
        return super.displayAccountInfo() +
               "\nAccount Type: Checking" +
               "\nOverdraft Limit: $" + String.format("%.2f", overdraftLimit);
    }
}