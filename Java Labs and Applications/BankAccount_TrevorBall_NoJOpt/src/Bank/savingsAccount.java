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

public class savingsAccount extends bankAccount
{
    private double interestRate;

    public savingsAccount(String accountNumber, String ownerName, String email,
                          String phoneNumber, double balance, double interestRate)
    {
        super(accountNumber, ownerName, email, phoneNumber, balance);

        //helps precent negative interest rate
        if(interestRate < 0)
            this.interestRate = 0;
        else
            this.interestRate = interestRate;
    }

    @Override
    public String displayAccountInfo()
    {
        return super.displayAccountInfo() +
               "\nAccount Type: Savings" +
               "\nInterest Rate: " + interestRate + "%";
    }
}