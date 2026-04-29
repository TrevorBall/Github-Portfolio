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

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class BankAccountGUI extends JFrame implements ActionListener
{
	//Labels
    JLabel lblAccountType;
    JLabel lblAccountNumber;
    JLabel lblOwnerName;
    JLabel lblEmail;
    JLabel lblPhoneNumber;
    JLabel lblBalance;
    JLabel lblExtra1;
    JLabel lblExtra2;
    JLabel lblAmount;
    JLabel lblWelcome;
    JLabel lblCurrentBalance;
    JLabel lblMessage;

    // Text
    JTextField tbAccountNumber;
    JTextField tbOwnerName;
    JTextField tbEmail;
    JTextField tbPhoneNumber;
    JTextField tbBalance;
    JTextField tbExtra1;
    JTextField tbExtra2;
    JTextField tbAmount;

    // ComboBoxes
    JComboBox<String> cbAccountType;

    // Buttons
    JButton btnCreateAccount;
    JButton btnDeposit;
    JButton btnWithdraw;
    JButton btnViewInfo;
    JButton btnClear;

    //Text
    JTextArea taOutput;
    JScrollPane scrollPane;

    bankAccount account;

    public BankAccountGUI()
    {
        setTitle("Bank Account System");
        setSize(500, 650);
        setLocationRelativeTo(null);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLayout(new FlowLayout());

        lblAccountType = new JLabel("Account Type:");
        lblAccountNumber = new JLabel("Account Number:");
        lblOwnerName = new JLabel("Owner Name:");
        lblEmail = new JLabel("Email:");
        lblPhoneNumber = new JLabel("Phone Number:");
        lblBalance = new JLabel("Starting Balance:");
        lblExtra1 = new JLabel("Interest Rate:");
        lblExtra2 = new JLabel("Extra Field:");
        lblAmount = new JLabel("Amount:");
        lblWelcome = new JLabel("Welcome: No Account Yet");
        lblCurrentBalance = new JLabel("Current Balance: $0.00");
        lblMessage = new JLabel(" ");

        String[] accountTypes = {"Savings", "Checking", "Mutual Fund", "Crypto"};
        cbAccountType = new JComboBox<String>(accountTypes);
        cbAccountType.addActionListener(this);

        tbAccountNumber = new JTextField(20);
        tbOwnerName = new JTextField(20);
        tbEmail = new JTextField(20);
        tbPhoneNumber = new JTextField(20);
        tbBalance = new JTextField(20);
        tbExtra1 = new JTextField(20);
        tbExtra2 = new JTextField(20);
        tbAmount = new JTextField(20);

        btnCreateAccount = new JButton("Create Account");
        btnDeposit = new JButton("Deposit");
        btnWithdraw = new JButton("Withdraw");
        btnViewInfo = new JButton("View Info");
        btnClear = new JButton("Clear");

        btnCreateAccount.addActionListener(this);
        btnDeposit.addActionListener(this);
        btnWithdraw.addActionListener(this);
        btnViewInfo.addActionListener(this);
        btnClear.addActionListener(this);

        taOutput = new JTextArea(15, 35);
        taOutput.setEditable(false);
        scrollPane = new JScrollPane(taOutput);

        add(lblAccountType);
        add(cbAccountType);

        add(lblAccountNumber);
        add(tbAccountNumber);

        add(lblOwnerName);
        add(tbOwnerName);

        add(lblEmail);
        add(tbEmail);

        add(lblPhoneNumber);
        add(tbPhoneNumber);

        add(lblBalance);
        add(tbBalance);

        add(lblExtra1);
        add(tbExtra1);

        add(lblExtra2);
        add(tbExtra2);

        add(lblAmount);
        add(tbAmount);

        add(btnCreateAccount);
        add(btnDeposit);
        add(btnWithdraw);
        add(btnViewInfo);
        add(btnClear);

        add(lblWelcome);
        add(lblCurrentBalance);
        add(lblMessage);
        add(scrollPane);

        updateExtraFields();

        setVisible(true);
    }

    public void updateExtraFields()
    {
        String selectedType = cbAccountType.getSelectedItem().toString();

        if(selectedType.equals("Savings"))
        {
            lblExtra1.setText("Interest Rate:");
            lblExtra2.setText("Extra Field:");
            tbExtra2.setEnabled(false);
            tbExtra2.setText("");
        }
        else if(selectedType.equals("Checking"))
        {
            lblExtra1.setText("Overdraft Limit:");
            lblExtra2.setText("Extra Field:");
            tbExtra2.setEnabled(false);
            tbExtra2.setText("");
        }
        else if(selectedType.equals("Mutual Fund"))
        {
            lblExtra1.setText("Investment Balance:");
            lblExtra2.setText("Risk Level:");
            tbExtra2.setEnabled(true);
        }
        else if(selectedType.equals("Crypto"))
        {
            lblExtra1.setText("Crypto Balance:");
            lblExtra2.setText("Crypto Type:");
            tbExtra2.setEnabled(true);
        }
    }

    public void updateDisplay()
    {
        if(account != null)
        {
            lblWelcome.setText("Welcome " + account.getOwnerName());
            lblCurrentBalance.setText("Current Balance: $" + String.format("%.2f", account.getBalance()));
        }
    }

    public void clearFields()
    {
        tbAccountNumber.setText("");
        tbOwnerName.setText("");
        tbEmail.setText("");
        tbPhoneNumber.setText("");
        tbBalance.setText("");
        tbExtra1.setText("");
        tbExtra2.setText("");
        tbAmount.setText("");
        taOutput.setText("");
        lblMessage.setText(" ");
        lblWelcome.setText("Welcome: No Account Yet");
        lblCurrentBalance.setText("Current Balance: $0.00");
        account = null;
        updateExtraFields();
    }

    @Override
    public void actionPerformed(ActionEvent e)
    {
        if(e.getSource() == cbAccountType)
        {
            updateExtraFields();
        }

        if(e.getSource() == btnCreateAccount)
        {
            try
            {
                String type = cbAccountType.getSelectedItem().toString();
                String accountNumber = tbAccountNumber.getText().trim();
                String ownerName = tbOwnerName.getText().trim();
                String email = tbEmail.getText().trim();
                String phoneNumber = tbPhoneNumber.getText().trim();

                // SIMPLE blank check (just one error type like you wanted)
                if(accountNumber.equals("") || ownerName.equals(""))
                {
                    lblMessage.setText("Enter account number and name.");
                    return;
                }

                double balance = Double.parseDouble(tbBalance.getText().trim());

                if(balance < 0)
                {
                    lblMessage.setText("Balance cannot be negative.");
                    return;
                }

                if(type.equals("Savings"))
                {
                    double interestRate = Double.parseDouble(tbExtra1.getText().trim());
                    account = new savingsAccount(accountNumber, ownerName, email, phoneNumber, balance, interestRate);
                }
                else if(type.equals("Checking"))
                {
                    double overdraftLimit = Double.parseDouble(tbExtra1.getText().trim());
                    account = new CheckingAccount(accountNumber, ownerName, email, phoneNumber, balance, overdraftLimit);
                }
                else if(type.equals("Mutual Fund"))
                {
                    double investmentBalance = Double.parseDouble(tbExtra1.getText().trim());
                    String riskLevel = tbExtra2.getText().trim();

                    // simple check (only one error type like you said)
                    if(riskLevel.equals(""))
                    {
                        lblMessage.setText("Enter risk level.");
                        return;
                    }

                    account = new MutualFundAccount(accountNumber, ownerName, email, phoneNumber, balance, investmentBalance, riskLevel);
                }
                else if(type.equals("Crypto"))
                {
                    double cryptoBalance = Double.parseDouble(tbExtra1.getText().trim());
                    String cryptoType = tbExtra2.getText().trim();

                    if(cryptoType.equals(""))
                    {
                        lblMessage.setText("Enter crypto type.");
                        return;
                    }

                    account = new CryptoAccount(accountNumber, ownerName, email, phoneNumber, balance, cryptoBalance, cryptoType);
                }

                lblMessage.setText("Account created successfully.");
                updateDisplay();
                taOutput.setText(account.displayAccountInfo());
            }
            catch(Exception ex)
            {
                lblMessage.setText("Error creating account. Check input.");
            }
        }

        if(e.getSource() == btnDeposit)
        {
            if(account == null)
            {
                lblMessage.setText("Create an account first.");
                return;
            }

            try
            {
                double amount = Double.parseDouble(tbAmount.getText());

                if(account.deposit(amount))
                {
                    lblMessage.setText("Deposit successful.");
                    updateDisplay();
                    taOutput.setText(account.displayAccountInfo());
                }
                else
                {
                    lblMessage.setText("Deposit amount must be greater than 0.");
                }
            }
            catch(Exception ex)
            {
                lblMessage.setText("Enter a valid deposit amount.");
            }
        }

        if(e.getSource() == btnWithdraw)
        {
            if(account == null)
            {
                lblMessage.setText("Create an account first.");
                return;
            }

            try
            {
                double amount = Double.parseDouble(tbAmount.getText());

                if(account.withdraw(amount))
                {
                    lblMessage.setText("Withdrawal successful.");
                    updateDisplay();
                    taOutput.setText(account.displayAccountInfo());
                }
                else
                {
                    lblMessage.setText("Withdrawal failed. Check amount or balance.");
                }
            }
            catch(Exception ex)
            {
                lblMessage.setText("Enter a valid withdrawal amount.");
            }
        }

        if(e.getSource() == btnViewInfo)
        {
            if(account == null)
            {
                lblMessage.setText("Create an account first.");
            }
            else
            {
                taOutput.setText(account.displayAccountInfo());
                updateDisplay();
                lblMessage.setText("Showing account info.");
            }
        }

        if(e.getSource() == btnClear)
        {
            clearFields();
        }
    }

    public static void main(String[] args)
    {
        new BankAccountGUI();
    }
}