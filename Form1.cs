using System.Windows.Forms;

namespace BankAccountApp
{
    public partial class Form1 : Form
    {
        List<BankAccount> BankAccounts = new List<BankAccount>(); // List to hold bank accounts

        public Form1()
        {
            InitializeComponent();


        }





        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(OwnerTxt.Text))
                return;

            if (InterestRateNum.Value > 0)

                BankAccounts.Add(new SavingsAccount(OwnerTxt.Text, InterestRateNum.Value));


            else


                BankAccounts.Add(new BankAccount(OwnerTxt.Text));// Create a new bank account with the owner's name from the text box



            RefreshGrid(); // Refresh the grid to show the new account
            OwnerTxt.Text = "";
            InterestRateNum.Value = 0;




            MessageBox.Show("You have successfully created a account!");
        }
        private void RefreshGrid()
        {
            BankAccountGrid.DataSource = null; // Reset the data source to refresh the grid
            BankAccountGrid.DataSource = BankAccounts; // Set the data source to the updated list of bank accounts  
        }


        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountGrid.SelectedRows.Count == 1)
            {
                BankAccount selectedBankAccount = BankAccountGrid.SelectedRows[0].DataBoundItem as BankAccount;
                string message = selectedBankAccount.Deposit(AmountNum.Value);

                RefreshGrid();
                AmountNum.Value = 0;
                MessageBox.Show(message);
            }



        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountGrid.SelectedRows.Count == 1)
            {
                BankAccount selectedBankAccount = BankAccountGrid.SelectedRows[0].DataBoundItem as BankAccount;
                string message = selectedBankAccount.Withdraw(AmountNum.Value);

                RefreshGrid();
                AmountNum.Value = 0;
                MessageBox.Show(message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
