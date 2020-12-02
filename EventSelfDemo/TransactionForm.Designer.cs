
namespace EventSelfDemo
{
    partial class TransactionForm
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
            this.lbTransactionTitle = new System.Windows.Forms.Label();
            this.lbTransctionName = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.lbOverDraftWarning = new System.Windows.Forms.Label();
            this.txTransactionName = new System.Windows.Forms.TextBox();
            this.nudAmmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTransactionTitle
            // 
            this.lbTransactionTitle.AutoSize = true;
            this.lbTransactionTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransactionTitle.Location = new System.Drawing.Point(36, 32);
            this.lbTransactionTitle.Name = "lbTransactionTitle";
            this.lbTransactionTitle.Size = new System.Drawing.Size(362, 48);
            this.lbTransactionTitle.TabIndex = 0;
            this.lbTransactionTitle.Text = "Transaction Record";
            // 
            // lbTransctionName
            // 
            this.lbTransctionName.AutoSize = true;
            this.lbTransctionName.Location = new System.Drawing.Point(39, 127);
            this.lbTransctionName.Name = "lbTransctionName";
            this.lbTransctionName.Size = new System.Drawing.Size(92, 25);
            this.lbTransctionName.TabIndex = 1;
            this.lbTransctionName.Text = "Purpose:";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(39, 202);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(86, 25);
            this.lbAmount.TabIndex = 2;
            this.lbAmount.Text = "Amount";
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Location = new System.Drawing.Point(96, 266);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(221, 47);
            this.btnAddTransaction.TabIndex = 3;
            this.btnAddTransaction.Text = "Make Transaction";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // lbOverDraftWarning
            // 
            this.lbOverDraftWarning.AutoSize = true;
            this.lbOverDraftWarning.ForeColor = System.Drawing.Color.Red;
            this.lbOverDraftWarning.Location = new System.Drawing.Point(12, 346);
            this.lbOverDraftWarning.Name = "lbOverDraftWarning";
            this.lbOverDraftWarning.Size = new System.Drawing.Size(234, 25);
            this.lbOverDraftWarning.TabIndex = 4;
            this.lbOverDraftWarning.Text = "This is a overdraft alarm";
            this.lbOverDraftWarning.Visible = false;
            this.lbOverDraftWarning.Click += new System.EventHandler(this.lbOverDraftWarning_Click);
            // 
            // txTransactionName
            // 
            this.txTransactionName.Location = new System.Drawing.Point(164, 124);
            this.txTransactionName.Name = "txTransactionName";
            this.txTransactionName.Size = new System.Drawing.Size(211, 32);
            this.txTransactionName.TabIndex = 5;
            // 
            // nudAmmount
            // 
            this.nudAmmount.Location = new System.Drawing.Point(164, 200);
            this.nudAmmount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudAmmount.Name = "nudAmmount";
            this.nudAmmount.Size = new System.Drawing.Size(211, 32);
            this.nudAmmount.TabIndex = 7;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 397);
            this.Controls.Add(this.nudAmmount);
            this.Controls.Add(this.txTransactionName);
            this.Controls.Add(this.lbOverDraftWarning);
            this.Controls.Add(this.btnAddTransaction);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.lbTransctionName);
            this.Controls.Add(this.lbTransactionTitle);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudAmmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTransactionTitle;
        private System.Windows.Forms.Label lbTransctionName;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.Label lbOverDraftWarning;
        private System.Windows.Forms.TextBox txTransactionName;
        private System.Windows.Forms.NumericUpDown nudAmmount;
    }
}