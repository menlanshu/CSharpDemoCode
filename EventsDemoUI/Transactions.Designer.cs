namespace EventsDemoUI
{
    partial class Transactions
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.customerValue = new System.Windows.Forms.Label();
            this.amountDU = new System.Windows.Forms.NumericUpDown();
            this.makePurchaseButon = new System.Windows.Forms.Button();
            this.summaryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amountDU)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(71, 28);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(311, 45);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Credit Card Machine";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(74, 96);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(107, 30);
            this.customerLabel.TabIndex = 1;
            this.customerLabel.Text = "Customer";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(74, 161);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(94, 30);
            this.amountLabel.TabIndex = 2;
            this.amountLabel.Text = "Amount";
            // 
            // customerValue
            // 
            this.customerValue.AutoSize = true;
            this.customerValue.Location = new System.Drawing.Point(220, 96);
            this.customerValue.Name = "customerValue";
            this.customerValue.Size = new System.Drawing.Size(88, 30);
            this.customerValue.TabIndex = 3;
            this.customerValue.Text = "<none>";
            // 
            // amountDU
            // 
            this.amountDU.Location = new System.Drawing.Point(225, 161);
            this.amountDU.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.amountDU.Name = "amountDU";
            this.amountDU.Size = new System.Drawing.Size(120, 35);
            this.amountDU.TabIndex = 4;
            // 
            // makePurchaseButon
            // 
            this.makePurchaseButon.Location = new System.Drawing.Point(122, 239);
            this.makePurchaseButon.Name = "makePurchaseButon";
            this.makePurchaseButon.Size = new System.Drawing.Size(173, 65);
            this.makePurchaseButon.TabIndex = 5;
            this.makePurchaseButon.Text = "Make Purchase";
            this.makePurchaseButon.UseVisualStyleBackColor = true;
            this.makePurchaseButon.Click += new System.EventHandler(this.makePurchaseButon_Click);
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.ForeColor = System.Drawing.Color.Red;
            this.summaryLabel.Location = new System.Drawing.Point(107, 329);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(201, 30);
            this.summaryLabel.TabIndex = 9;
            this.summaryLabel.Text = "You are overdrafting";
            this.summaryLabel.Visible = false;
            this.summaryLabel.Click += new System.EventHandler(this.summaryLabel_Click);
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(436, 382);
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.makePurchaseButon);
            this.Controls.Add(this.amountDU);
            this.Controls.Add(this.customerValue);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Transactions";
            this.Text = "Transactions";
            ((System.ComponentModel.ISupportInitialize)(this.amountDU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label customerValue;
        private System.Windows.Forms.NumericUpDown amountDU;
        private System.Windows.Forms.Button makePurchaseButon;
        private System.Windows.Forms.Label summaryLabel;
    }
}