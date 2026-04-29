public class MutualFundAccount extends BankAccount
{
    private double investmentBalance;
    private String riskLevel;

    public MutualFundAccount(String accNum, String name, String email, String phone, double balance,
                             double invest, String risk)
    {
        super(accNum, name, email, phone, balance);
        this.investmentBalance = invest;
        this.riskLevel = risk;
    }

    @Override
    public String displayAccountInfo()
    {
        return super.displayAccountInfo() +
               "\nInvestment Balance: " + investmentBalance +
               "\nRisk Level: " + riskLevel;
    }
}