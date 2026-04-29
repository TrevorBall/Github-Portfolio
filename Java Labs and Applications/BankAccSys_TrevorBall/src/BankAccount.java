/*
 * 
 * 
 * Trevor Ball
 * CPT-236-A01H Java
 * Lab 7 - Lab 6 but no JOption
 * 
 * 
 */
public class BankAccount
{
    protected String accountNumber;
    protected String ownerName;
    protected String email;
    protected String phoneNumber;
    protected double balance;

    public BankAccount(String accNum, String name, String email, String phone, double balance)
    {
        this.accountNumber = accNum;
        this.ownerName = name;
        this.email = email;
        this.phoneNumber = phone;
        this.balance = balance;
    }

    public void deposit(double amount)
    {
        if(amount > 0)
            balance += amount;
    }

    public void withdraw(double amount)
    {
        if(amount > 0 && amount <= balance)
            balance -= amount;
    }

    public String displayAccountInfo()
    {
        return "Account #: " + accountNumber +
               "\nName: " + ownerName +
               "\nEmail: " + email +
               "\nPhone: " + phoneNumber +
               "\nBalance: $" + balance;
    }
}