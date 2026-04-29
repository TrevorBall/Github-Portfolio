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

public class MutualFundAccount extends bankAccount
{
    private double investmentBalance;
    private String riskLevel;

    public MutualFundAccount(String accountNumber, String ownerName, String email,
                             String phoneNumber, double balance, double investmentBalance, String riskLevel)
    {
        super(accountNumber, ownerName, email, phoneNumber, balance);

        // helps prevent negative investment balance
        if(investmentBalance < 0)
            this.investmentBalance = 0;
        else
            this.investmentBalance = investmentBalance;

        if(riskLevel == null || riskLevel.trim().equals(""))
            this.riskLevel = "Unknown";
        else
            this.riskLevel = riskLevel;
    }

    @Override
    public String displayAccountInfo()
    {
        return super.displayAccountInfo() +
               "\nAccount Type: Mutual Fund" +
               "\nInvestment Balance: $" + String.format("%.2f", investmentBalance) +
               "\nRisk Level: " + riskLevel;
    }
}