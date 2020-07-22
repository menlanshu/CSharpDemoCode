namespace EventsDemoUI
{
    partial class BankDashboard
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
            this.bandDemoLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.checkBalanceLabel = new System.Windows.Forms.Label();
            this.savingBalanceLabel = new System.Windows.Forms.Label();
            this.customerValue = new System.Windows.Forms.Label();
            this.checkBalanceValue = new System.Windows.Forms.Label();
            this.savingBalanceValue = new System.Windows.Forms.Label();
            this.recordTransactionButton = new System.Windows.Forms.Button();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.checkingTransactionLabel = new System.Windows.Forms.Label();
            this.savingTransactionLabel = new System.Windows.Forms.Label();
            this.checkingTransactions = new System.Windows.Forms.ListBox();
            this.savingsTransactions = new System.Windows.Forms.ListBox();
            this.allowOverDraftCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bandDemoLabel
            // 
            this.bandDemoLabel.AutoSize = true;
            this.bandDemoLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bandDemoLabel.Location = new System.Drawing.Point(30, 49);
            this.bandDemoLabel.Name = "bandDemoLabel";
            this.bandDemoLabel.Size = new System.Drawing.Size(204, 40);
            this.bandDemoLabel.TabIndex = 0;
            this.bandDemoLabel.Text = "Banking Demo";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(32, 129);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(107, 30);
            this.customerLabel.TabIndex = 1;
            this.customerLabel.Text = "Customer";
            // 
            // checkBalanceLabel
            // 
            this.checkBalanceLabel.AutoSize = true;
            this.checkBalanceLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBalanceLabel.Location = new System.Drawing.Point(32, 196);
            this.checkBalanceLabel.Name = "checkBalanceLabel";
            this.checkBalanceLabel.Size = new System.Drawing.Size(185, 30);
            this.checkBalanceLabel.TabIndex = 2;
            this.checkBalanceLabel.Text = "Checking Balance";
            // 
            // savingBalanceLabel
            // 
            this.savingBalanceLabel.AutoSize = true;
            this.savingBalanceLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingBalanceLabel.Location = new System.Drawing.Point(32, 268);
            this.savingBalanceLabel.Name = "savingBalanceLabel";
            this.savingBalanceLabel.Size = new System.Drawing.Size(160, 30);
            this.savingBalanceLabel.TabIndex = 3;
            this.savingBalanceLabel.Text = "Saving Balance";
            // 
            // customerValue
            // 
            this.customerValue.AutoSize = true;
            this.customerValue.Location = new System.Drawing.Point(228, 129);
            this.customerValue.Name = "customerValue";
            this.customerValue.Size = new System.Drawing.Size(88, 30);
            this.customerValue.TabIndex = 4;
            this.customerValue.Text = "<none>";
            // 
            // checkBalanceValue
            // 
            this.checkBalanceValue.AutoSize = true;
            this.checkBalanceValue.Location = new System.Drawing.Point(228, 196);
            this.checkBalanceValue.Name = "checkBalanceValue";
            this.checkBalanceValue.Size = new System.Drawing.Size(62, 30);
            this.checkBalanceValue.TabIndex = 5;
            this.checkBalanceValue.Text = "$0.00";
            // 
            // savingBalanceValue
            // 
            this.savingBalanceValue.AutoSize = true;
            this.savingBalanceValue.Location = new System.Drawing.Point(228, 268);
            this.savingBalanceValue.Name = "savingBalanceValue";
            this.savingBalanceValue.Size = new System.Drawing.Size(62, 30);
            this.savingBalanceValue.TabIndex = 6;
            this.savingBalanceValue.Text = "$0.00";
            // 
            // recordTransactionButton
            // 
            this.recordTransactionButton.Location = new System.Drawing.Point(94, 371);
            this.recordTransactionButton.Name = "recordTransactionButton";
            this.recordTransactionButton.Size = new System.Drawing.Size(173, 77);
            this.recordTransactionButton.TabIndex = 7;
            this.recordTransactionButton.Text = "Record Transactions";
            this.recordTransactionButton.UseVisualStyleBackColor = true;
            this.recordTransactionButton.Click += new System.EventHandler(this.recordTransactionButton_Click);
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.ForeColor = System.Drawing.Color.Red;
            this.summaryLabel.Location = new System.Drawing.Point(402, 49);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(458, 30);
            this.summaryLabel.TabIndex = 8;
            this.summaryLabel.Text = "You had an overdraft proection transfer of $0.00";
            this.summaryLabel.Click += new System.EventHandler(this.summaryLabel_Click);
            // 
            // checkingTransactionLabel
            // 
            this.checkingTransactionLabel.AutoSize = true;
            this.checkingTransactionLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkingTransactionLabel.Location = new System.Drawing.Point(402, 110);
            this.checkingTransactionLabel.Name = "checkingTransactionLabel";
            this.checkingTransactionLabel.Size = new System.Drawing.Size(231, 30);
            this.checkingTransactionLabel.TabIndex = 9;
            this.checkingTransactionLabel.Text = "Checking Transactions";
            // 
            // savingTransactionLabel
            // 
            this.savingTransactionLabel.AutoSize = true;
            this.savingTransactionLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingTransactionLabel.Location = new System.Drawing.Point(838, 110);
            this.savingTransactionLabel.Name = "savingTransactionLabel";
            this.savingTransactionLabel.Size = new System.Drawing.Size(206, 30);
            this.savingTransactionLabel.TabIndex = 10;
            this.savingTransactionLabel.Text = "Saving Transactions";
            // 
            // checkingTransactions
            // 
            this.checkingTransactions.FormattingEnabled = true;
            this.checkingTransactions.ItemHeight = 30;
            this.checkingTransactions.Location = new System.Drawing.Point(407, 153);
            this.checkingTransactions.Name = "checkingTransactions";
            this.checkingTransactions.Size = new System.Drawing.Size(403, 334);
            this.checkingTransactions.TabIndex = 11;
            // 
            // savingsTransactions
            // 
            this.savingsTransactions.FormattingEnabled = true;
            this.savingsTransactions.ItemHeight = 30;
            this.savingsTransactions.Location = new System.Drawing.Point(843, 153);
            this.savingsTransactions.Name = "savingsTransactions";
            this.savingsTransactions.Size = new System.Drawing.Size(390, 334);
            this.savingsTransactions.TabIndex = 12;
            // 
            // allowOverDraftCB
            // 
            this.allowOverDraftCB.AutoSize = true;
            this.allowOverDraftCB.Location = new System.Drawing.Point(94, 331);
            this.allowOverDraftCB.Name = "allowOverDraftCB";
            this.allowOverDraftCB.Size = new System.Drawing.Size(180, 34);
            this.allowOverDraftCB.TabIndex = 13;
            this.allowOverDraftCB.Text = "Allow OverDraft";
            this.allowOverDraftCB.UseVisualStyleBackColor = true;
            // 
            // BankDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1273, 539);
            this.Controls.Add(this.allowOverDraftCB);
            this.Controls.Add(this.savingsTransactions);
            this.Controls.Add(this.checkingTransactions);
            this.Controls.Add(this.savingTransactionLabel);
            this.Controls.Add(this.checkingTransactionLabel);
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.recordTransactionButton);
            this.Controls.Add(this.savingBalanceValue);
            this.Controls.Add(this.checkBalanceValue);
            this.Controls.Add(this.customerValue);
            this.Controls.Add(this.savingBalanceLabel);
            this.Controls.Add(this.checkBalanceLabel);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.bandDemoLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "BankDashboard";
            this.Text = "Banking Dashboard - A C# Events Demo by Fu Long";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bandDemoLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label checkBalanceLabel;
        private System.Windows.Forms.Label savingBalanceLabel;
        private System.Windows.Forms.Label customerValue;
        private System.Windows.Forms.Label checkBalanceValue;
        private System.Windows.Forms.Label savingBalanceValue;
        private System.Windows.Forms.Button recordTransactionButton;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.Label checkingTransactionLabel;
        private System.Windows.Forms.Label savingTransactionLabel;
        private System.Windows.Forms.ListBox checkingTransactions;
        private System.Windows.Forms.ListBox savingsTransactions;
        private System.Windows.Forms.CheckBox allowOverDraftCB;
    }
}

