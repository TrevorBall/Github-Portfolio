/*
 * 
 * 
 * Trevor Ball
 * CPT-236-A01H Java
 * Lab 7 - Lab 6 but no JOption
 * 
 * 
 */
import java.awt.*;
import java.awt.GridBagLayout;
import java.awt.event.*;
import javax.swing.*;

public class BankAppGUI extends JFrame implements ActionListener
{
    JLabel lblWelcome, lblBalance;
    JTextField tbAmount;
    JButton btnDeposit, btnWithdraw, btnInfo;

    BankAccount account;

    public BankAppGUI()
    {
        setTitle("Bank App");
        setSize(350, 200);
        setLocationRelativeTo(null);
        setLayout(new FlowLayout());

        createAccount();

        lblWelcome = new JLabel("Welcome " + account.ownerName);
        lblBalance = new JLabel("Balance: $" + account.balance);

        tbAmount = new JTextField(10);

        btnDeposit = new JButton("Deposit");
        btnWithdraw = new JButton("Withdraw");
        btnInfo = new JButton("Info");

        add(lblWelcome);
        add(lblBalance);
        add(new JLabel("Amount:"));
        add(tbAmount);
        add(btnDeposit);
        add(btnWithdraw);
        add(btnInfo);

        btnDeposit.addActionListener(this);
        btnWithdraw.addActionListener(this);
        btnInfo.addActionListener(this);

        setVisible(true);
    }

    private void createAccount()
    {
        String[] options = {"Savings", "Checking", "Mutual", "Crypto"};

        String choice = (String) JOptionPane.showInputDialog(null, "Select Account Type", "Menu", JOptionPane.QUESTION_MESSAGE, null, options, options[0]);

        String name = JOptionPane.showInputDialog("Name:");
        double balance = Double.parseDouble(JOptionPane.showInputDialog("Balance:"));


        if(choice.equals("Savings"))
            account = new SavingsAccount("1", name, "", "", balance, 2.0);
        else if(choice.equals("Checking"))
            account = new CheckingAccount("1", name, "", "", balance, 100);
        else if(choice.equals("Mutual"))
            account = new MutualFundAccount("1", name, "", "", balance, 500, "Medium");
        else
            account = new CryptoAccount("1", name, "", "", balance, 1.5, "Bitcoin");
    }

    public void actionPerformed(ActionEvent e)
    {
        try
        {
            double amount = Double.parseDouble(tbAmount.getText());

            if(e.getSource() == btnDeposit)
                account.deposit(amount);

            if(e.getSource() == btnWithdraw)
                account.withdraw(amount);

            if(e.getSource() == btnInfo)
                JOptionPane.showMessageDialog(this, account.displayAccountInfo());

            lblBalance.setText("Balance: $" + account.balance);
        }
        catch(Exception ex)
        {
            JOptionPane.showMessageDialog(this, "Invalid input");
        }
    }

    public static void main(String[] args)
    {
        new BankAppGUI();
    }
}