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

public class CryptoAccount extends bankAccount
{
    private double cryptoBalance;
    private String cryptoType;

    public CryptoAccount(String accountNumber, String ownerName, String email,
                         String phoneNumber, double balance, double cryptoBalance, String cryptoType)
    {
        super(accountNumber, ownerName, email, phoneNumber, balance);

        // helps prevent negative crypto balance
        if(cryptoBalance < 0)
            this.cryptoBalance = 0;
        else
            this.cryptoBalance = cryptoBalance;

        // help prevent blank crypto type made
        if(cryptoType == null || cryptoType.trim().equals(""))
            this.cryptoType = "Unknown";
        else
            this.cryptoType = cryptoType;
    }

    @Override
    public String displayAccountInfo()
    {
        return super.displayAccountInfo() +
               "\nAccount Type: Crypto" +
               "\nCrypto Balance: " + cryptoBalance +
               "\nCrypto Type: " + cryptoType;
    }
}