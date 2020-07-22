namespace DelegatesDemoWinformUI
{
    partial class Dashboard
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
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.textBoxDemoButton = new System.Windows.Forms.Button();
            this.messageBoxDemoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Location = new System.Drawing.Point(286, 42);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(90, 30);
            this.subTotalLabel.TabIndex = 11;
            this.subTotalLabel.Text = "Subtotal";
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.Location = new System.Drawing.Point(292, 78);
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.Size = new System.Drawing.Size(231, 35);
            this.subTotalTextBox.TabIndex = 10;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(286, 121);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(57, 30);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(292, 157);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(231, 35);
            this.totalTextBox.TabIndex = 8;
            // 
            // textBoxDemoButton
            // 
            this.textBoxDemoButton.Location = new System.Drawing.Point(292, 226);
            this.textBoxDemoButton.Name = "textBoxDemoButton";
            this.textBoxDemoButton.Size = new System.Drawing.Size(231, 108);
            this.textBoxDemoButton.TabIndex = 7;
            this.textBoxDemoButton.Text = "TextBox Demo";
            this.textBoxDemoButton.UseVisualStyleBackColor = true;
            this.textBoxDemoButton.Click += new System.EventHandler(this.textBoxDemoButton_Click);
            // 
            // messageBoxDemoButton
            // 
            this.messageBoxDemoButton.Location = new System.Drawing.Point(38, 226);
            this.messageBoxDemoButton.Name = "messageBoxDemoButton";
            this.messageBoxDemoButton.Size = new System.Drawing.Size(231, 108);
            this.messageBoxDemoButton.TabIndex = 6;
            this.messageBoxDemoButton.Text = "MessageBox Demo";
            this.messageBoxDemoButton.UseVisualStyleBackColor = true;
            this.messageBoxDemoButton.Click += new System.EventHandler(this.messageBoxDemoButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 382);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.subTotalTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.textBoxDemoButton);
            this.Controls.Add(this.messageBoxDemoButton);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.TextBox subTotalTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Button textBoxDemoButton;
        private System.Windows.Forms.Button messageBoxDemoButton;
    }
}

