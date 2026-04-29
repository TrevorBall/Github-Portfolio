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

public class bankAccount
{
    protected String accountNumber;
    protected String ownerName;
    protected String email;
    protected String phoneNumber;
    protected double balance;

    public bankAccount(String accountNumber, String ownerName, String email, String phoneNumber, double balance)
    {
        // help prevent null or empty strings
        if(accountNumber == null || accountNumber.trim().equals(""))
            this.accountNumber = "0000";
        else
            this.accountNumber = accountNumber;

        if(ownerName == null || ownerName.trim().equals(""))
            this.ownerName = "Unknown";
        else
            this.ownerName = ownerName;

        this.email = email;
        this.phoneNumber = phoneNumber;

        // help prevent negative balance at start
        if(balance < 0)
            this.balance = 0;
        else
            this.balance = balance;
    }

    public boolean deposit(double amount)
    {
    	//no negative deposit
        if(amount > 0)
        {
            balance += amount;
            return true;
        }
        return false;
    }

    public boolean withdraw(double amount)
    {
    	//no withdrawal bigger than balance and no neg withdrawals
        if(amount > 0 && amount <= balance)
        {
            balance -= amount;
            return true;
        }
        return false;
    }

    public String displayAccountInfo()
    {
        return "Account Number: " + accountNumber +
               "\nOwner Name: " + ownerName +
               "\nEmail: " + email +
               "\nPhone Number: " + phoneNumber +
               "\nBalance: $" + balance;
    }

    public double getBalance()
    {
        return balance;
    }

    public String getOwnerName()
    {
        return ownerName;
    }
}