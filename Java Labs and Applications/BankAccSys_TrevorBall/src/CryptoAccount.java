public class CryptoAccount extends BankAccount
{
    private double cryptoBalance;
    private String cryptoType;

    public CryptoAccount(String accNum, String name, String email, String phone, double balance,
                         double cryptoBal, String type)
    {
        super(accNum, name, email, phone, balance);
        this.cryptoBalance = cryptoBal;
        this.cryptoType = type;
    }

    @Override
    public String displayAccountInfo()
    {
        return super.displayAccountInfo() +
               "\nCrypto Balance: " + cryptoBalance +
               "\nCrypto Type: " + cryptoType;
    }
}