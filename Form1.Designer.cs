namespace BankAccountApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            OwnerTxt = new TextBox();
            AmountNum = new NumericUpDown();
            BankAccountGrid = new DataGridView();
            DepositBtn = new Button();
            WithdrawBtn = new Button();
            CreateAccountBtn = new Button();
            label5 = new Label();
            InterestRateNum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 0;
            label1.Text = "Owner";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 233);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 2;
            label2.Text = "Amount";
            // 
            // OwnerTxt
            // 
            OwnerTxt.Location = new Point(72, 12);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(266, 31);
            OwnerTxt.TabIndex = 4;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(100, 231);
            AmountNum.Maximum = new decimal(new int[] { -1593835520, 466537709, 54210, 0 });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(180, 31);
            AmountNum.TabIndex = 5;
            // 
            // BankAccountGrid
            // 
            BankAccountGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccountGrid.BackgroundColor = SystemColors.ActiveCaption;
            BankAccountGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountGrid.GridColor = SystemColors.ScrollBar;
            BankAccountGrid.Location = new Point(422, 33);
            BankAccountGrid.Name = "BankAccountGrid";
            BankAccountGrid.RowHeadersWidth = 62;
            BankAccountGrid.Size = new Size(490, 225);
            BankAccountGrid.TabIndex = 6;
            // 
            // DepositBtn
            // 
            DepositBtn.Location = new Point(422, 274);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(234, 34);
            DepositBtn.TabIndex = 7;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            DepositBtn.Click += DepositBtn_Click;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.Location = new Point(671, 274);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(241, 34);
            WithdrawBtn.TabIndex = 8;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = true;
            WithdrawBtn.Click += WithdrawBtn_Click;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.Location = new Point(99, 111);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(239, 48);
            CreateAccountBtn.TabIndex = 9;
            CreateAccountBtn.Text = "Create account";
            CreateAccountBtn.UseVisualStyleBackColor = true;
            CreateAccountBtn.Click += CreateAccountBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 62);
            label5.Name = "label5";
            label5.Size = new Size(145, 25);
            label5.TabIndex = 12;
            label5.Text = "Intereset rate (%)";
            label5.Click += label5_Click;
            // 
            // InterestRateNum
            // 
            InterestRateNum.ForeColor = SystemColors.MenuText;
            InterestRateNum.Location = new Point(153, 62);
            InterestRateNum.Maximum = new decimal(new int[] { 1241513984, 370409800, 542101, 0 });
            InterestRateNum.Name = "InterestRateNum";
            InterestRateNum.Size = new Size(185, 31);
            InterestRateNum.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 333);
            Controls.Add(InterestRateNum);
            Controls.Add(label5);
            Controls.Add(CreateAccountBtn);
            Controls.Add(WithdrawBtn);
            Controls.Add(DepositBtn);
            Controls.Add(BankAccountGrid);
            Controls.Add(AmountNum);
            Controls.Add(OwnerTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox OwnerTxt;
        private NumericUpDown AmountNum;
        private DataGridView BankAccountGrid;
        private Button DepositBtn;
        private Button WithdrawBtn;
        private Button CreateAccountBtn;
        private Label label5;
        private NumericUpDown InterestRateNum;
    }
}
