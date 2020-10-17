using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4B
{
    public partial class Form1 : Form
    {
        private Branch branch;
        //internal Branch Branch {
        //    get => default;
        //    set 
        //    {
        //        Branch = value;
        //    }
        //}

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            branch = new Branch("Mohwak College");
        }

        private void createBTN_Click(object sender, EventArgs e)
        {
            //get and validate input
            if (firstNameTB.TextLength < 2 || lastNameTB.TextLength < 2)
            {
                DisplayError("Create account denied. Fist and last name must have at least 2 characters");
                return;
            }

            Person owner = new Person(firstNameTB.Text, lastNameTB.Text);
            BankAccount account;

            if (checkingRB.Checked)
                account = new ChequingAccount(owner);
            else if (savingRB.Checked)
                account = new SavingsAccount(owner);
            else
            {
                DisplayError("Create account denied. No type of banking account selected");
                return;
            }

            branch.Accounts.Add(account);
            accountsLB.Items.Add(account);
            accountsLB.SelectedIndex = accountsLB.Items.Count - 1;

            DisplaySuccess("Create account successful!");
        }

        private void addTransactionBTN_Click(object sender, EventArgs e)
        {
            if (accountsLB.SelectedItem == null)
            {
                DisplayError("Transaction rejected. Please select an account for transaction");
                return;
            }

            BankAccount account = (BankAccount)accountsLB.SelectedItem;
            Transaction transaction;
            if (depositRB.Checked)
                transaction = account.Deposit(amountNUD.Value);
            else if (withdrawRB.Checked)
                transaction = account.Withdraw(amountNUD.Value);
            else
            {
                DisplayError("Transaction denied. Deposit/Withdraw not selected");
                return;
            }

            transactionsLB.Items.Add(transaction);
            currentBalanceTB.Text = account.Balance.ToString("C");

            DisplaySuccess("Added new transaction successfuly!");
        }

        private void DisplayError(string error)
        {
            resultLbl.ForeColor = Color.Red;
            resultLbl.Text = error;
        }

        private void DisplaySuccess(String message)
        {
            resultLbl.ForeColor = Color.Green;
            resultLbl.Text = message;
        }

        private void accountsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            transactionsLB.Items.Clear();
            BankAccount account = (BankAccount)accountsLB.SelectedItem;
            transactionsLB.Items.AddRange(account.Transactions.ToArray());
            currentBalanceTB.Text = account.Balance.ToString("C");
            accountNumberTB.Text = account.Number.ToString();
        }
    }
}
