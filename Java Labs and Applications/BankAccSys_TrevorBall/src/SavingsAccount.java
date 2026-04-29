/*
 * 
 * 
 * Trevor Ball
 * CPT-236-A01H Java
 * Lab 7 - Lab 6 but no JOption
 * 
 * 
 */
public class SavingsAccount extends BankAccount
{
    private double interestRate;

    public SavingsAccount(String accNum, String name, String email, String phone, double balance, double rate)
    {
        super(accNum, name, email, phone, balance);
        this.interestRate = rate;
    }

    @Override
    public String displayAccountInfo()
    {
        return super.displayAccountInfo() + "\nInterest Rate: " + interestRate;
    }
}