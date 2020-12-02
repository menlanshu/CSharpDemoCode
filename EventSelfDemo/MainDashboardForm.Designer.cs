
namespace EventSelfDemo
{
    partial class MainDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbBankDashBoard = new System.Windows.Forms.Label();
            this.lbCheckAccount = new System.Windows.Forms.Label();
            this.lbBackupAccount = new System.Windows.Forms.Label();
            this.lbAccountName = new System.Windows.Forms.Label();
            this.txAccountName = new System.Windows.Forms.TextBox();
            this.txCheckAccountDeposit = new System.Windows.Forms.TextBox();
            this.txBackupAccountDeposit = new System.Windows.Forms.TextBox();
            this.lbCheckAccountTransaction = new System.Windows.Forms.Label();
            this.lbBackupAccountTransaction = new System.Windows.Forms.Label();
            this.lbOverDraftRemind = new System.Windows.Forms.Label();
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.lbCATransactions = new System.Windows.Forms.ListBox();
            this.lbBATransactions = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbBankDashBoard
            // 
            this.lbBankDashBoard.AutoSize = true;
            this.lbBankDashBoard.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBankDashBoard.Location = new System.Drawing.Point(42, 27);
            this.lbBankDashBoard.Name = "lbBankDashBoard";
            this.lbBankDashBoard.Size = new System.Drawing.Size(310, 48);
            this.lbBankDashBoard.TabIndex = 0;
            this.lbBankDashBoard.Text = "Bank DashBoard";
            // 
            // lbCheckAccount
            // 
            this.lbCheckAccount.AutoSize = true;
            this.lbCheckAccount.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckAccount.Location = new System.Drawing.Point(12, 164);
            this.lbCheckAccount.Name = "lbCheckAccount";
            this.lbCheckAccount.Size = new System.Drawing.Size(155, 25);
            this.lbCheckAccount.TabIndex = 1;
            this.lbCheckAccount.Text = "Check Account:";
            // 
            // lbBackupAccount
            // 
            this.lbBackupAccount.AutoSize = true;
            this.lbBackupAccount.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBackupAccount.Location = new System.Drawing.Point(12, 231);
            this.lbBackupAccount.Name = "lbBackupAccount";
            this.lbBackupAccount.Size = new System.Drawing.Size(166, 25);
            this.lbBackupAccount.TabIndex = 2;
            this.lbBackupAccount.Text = "Backup Account:";
            // 
            // lbAccountName
            // 
            this.lbAccountName.AutoSize = true;
            this.lbAccountName.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountName.Location = new System.Drawing.Point(12, 103);
            this.lbAccountName.Name = "lbAccountName";
            this.lbAccountName.Size = new System.Drawing.Size(154, 25);
            this.lbAccountName.TabIndex = 3;
            this.lbAccountName.Text = "Account Name:";
            // 
            // txAccountName
            // 
            this.txAccountName.Enabled = false;
            this.txAccountName.Location = new System.Drawing.Point(186, 105);
            this.txAccountName.Name = "txAccountName";
            this.txAccountName.Size = new System.Drawing.Size(200, 25);
            this.txAccountName.TabIndex = 4;
            // 
            // txCheckAccountDeposit
            // 
            this.txCheckAccountDeposit.Enabled = false;
            this.txCheckAccountDeposit.Location = new System.Drawing.Point(186, 166);
            this.txCheckAccountDeposit.Name = "txCheckAccountDeposit";
            this.txCheckAccountDeposit.Size = new System.Drawing.Size(200, 25);
            this.txCheckAccountDeposit.TabIndex = 5;
            // 
            // txBackupAccountDeposit
            // 
            this.txBackupAccountDeposit.Enabled = false;
            this.txBackupAccountDeposit.Location = new System.Drawing.Point(186, 233);
            this.txBackupAccountDeposit.Name = "txBackupAccountDeposit";
            this.txBackupAccountDeposit.Size = new System.Drawing.Size(200, 25);
            this.txBackupAccountDeposit.TabIndex = 6;
            // 
            // lbCheckAccountTransaction
            // 
            this.lbCheckAccountTransaction.AutoSize = true;
            this.lbCheckAccountTransaction.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckAccountTransaction.Location = new System.Drawing.Point(442, 50);
            this.lbCheckAccountTransaction.Name = "lbCheckAccountTransaction";
            this.lbCheckAccountTransaction.Size = new System.Drawing.Size(277, 25);
            this.lbCheckAccountTransaction.TabIndex = 9;
            this.lbCheckAccountTransaction.Text = "Check Account Transactions:";
            // 
            // lbBackupAccountTransaction
            // 
            this.lbBackupAccountTransaction.AutoSize = true;
            this.lbBackupAccountTransaction.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBackupAccountTransaction.Location = new System.Drawing.Point(827, 50);
            this.lbBackupAccountTransaction.Name = "lbBackupAccountTransaction";
            this.lbBackupAccountTransaction.Size = new System.Drawing.Size(288, 25);
            this.lbBackupAccountTransaction.TabIndex = 10;
            this.lbBackupAccountTransaction.Text = "Backup Account Transactions:";
            // 
            // lbOverDraftRemind
            // 
            this.lbOverDraftRemind.AutoSize = true;
            this.lbOverDraftRemind.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOverDraftRemind.ForeColor = System.Drawing.Color.Red;
            this.lbOverDraftRemind.Location = new System.Drawing.Point(442, 9);
            this.lbOverDraftRemind.Name = "lbOverDraftRemind";
            this.lbOverDraftRemind.Size = new System.Drawing.Size(409, 25);
            this.lbOverDraftRemind.TabIndex = 11;
            this.lbOverDraftRemind.Text = "You have a overdraft protection warning {}!";
            this.lbOverDraftRemind.Visible = false;
            this.lbOverDraftRemind.Click += new System.EventHandler(this.lbOverDraftRemind_Click);
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.Location = new System.Drawing.Point(82, 286);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(242, 46);
            this.btnMakePayment.TabIndex = 12;
            this.btnMakePayment.Text = "Make Payment";
            this.btnMakePayment.UseVisualStyleBackColor = true;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // lbCATransactions
            // 
            this.lbCATransactions.FormattingEnabled = true;
            this.lbCATransactions.ItemHeight = 19;
            this.lbCATransactions.Location = new System.Drawing.Point(447, 90);
            this.lbCATransactions.Name = "lbCATransactions";
            this.lbCATransactions.Size = new System.Drawing.Size(356, 251);
            this.lbCATransactions.TabIndex = 13;
            // 
            // lbBATransactions
            // 
            this.lbBATransactions.FormattingEnabled = true;
            this.lbBATransactions.ItemHeight = 19;
            this.lbBATransactions.Location = new System.Drawing.Point(832, 90);
            this.lbBATransactions.Name = "lbBATransactions";
            this.lbBATransactions.Size = new System.Drawing.Size(356, 251);
            this.lbBATransactions.TabIndex = 14;
            // 
            // MainDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1206, 360);
            this.Controls.Add(this.lbBATransactions);
            this.Controls.Add(this.lbCATransactions);
            this.Controls.Add(this.btnMakePayment);
            this.Controls.Add(this.lbOverDraftRemind);
            this.Controls.Add(this.lbBackupAccountTransaction);
            this.Controls.Add(this.lbCheckAccountTransaction);
            this.Controls.Add(this.txBackupAccountDeposit);
            this.Controls.Add(this.txCheckAccountDeposit);
            this.Controls.Add(this.txAccountName);
            this.Controls.Add(this.lbAccountName);
            this.Controls.Add(this.lbBackupAccount);
            this.Controls.Add(this.lbCheckAccount);
            this.Controls.Add(this.lbBankDashBoard);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainDashboardForm";
            this.Text = "Bank Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBankDashBoard;
        private System.Windows.Forms.Label lbCheckAccount;
        private System.Windows.Forms.Label lbBackupAccount;
        private System.Windows.Forms.Label lbAccountName;
        private System.Windows.Forms.TextBox txAccountName;
        private System.Windows.Forms.TextBox txCheckAccountDeposit;
        private System.Windows.Forms.TextBox txBackupAccountDeposit;
        private System.Windows.Forms.Label lbCheckAccountTransaction;
        private System.Windows.Forms.Label lbBackupAccountTransaction;
        private System.Windows.Forms.Label lbOverDraftRemind;
        private System.Windows.Forms.Button btnMakePayment;
        private System.Windows.Forms.ListBox lbCATransactions;
        private System.Windows.Forms.ListBox lbBATransactions;
    }
}

