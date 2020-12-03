
namespace DelegateSelfDemo_Winform
{
    partial class DelegateDemo
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
            this.btnMessageBox = new System.Windows.Forms.Button();
            this.btnTextBox = new System.Windows.Forms.Button();
            this.txSubTotal = new System.Windows.Forms.TextBox();
            this.lbSubTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMessageBox
            // 
            this.btnMessageBox.ForeColor = System.Drawing.Color.Black;
            this.btnMessageBox.Location = new System.Drawing.Point(69, 305);
            this.btnMessageBox.Name = "btnMessageBox";
            this.btnMessageBox.Size = new System.Drawing.Size(298, 103);
            this.btnMessageBox.TabIndex = 0;
            this.btnMessageBox.Text = "MessageBox Demo";
            this.btnMessageBox.UseVisualStyleBackColor = true;
            this.btnMessageBox.Click += new System.EventHandler(this.btnMessageBox_Click);
            // 
            // btnTextBox
            // 
            this.btnTextBox.ForeColor = System.Drawing.Color.Black;
            this.btnTextBox.Location = new System.Drawing.Point(416, 305);
            this.btnTextBox.Name = "btnTextBox";
            this.btnTextBox.Size = new System.Drawing.Size(298, 103);
            this.btnTextBox.TabIndex = 1;
            this.btnTextBox.Text = "TextBox Demo";
            this.btnTextBox.UseVisualStyleBackColor = true;
            this.btnTextBox.Click += new System.EventHandler(this.btnTextBox_Click);
            // 
            // txSubTotal
            // 
            this.txSubTotal.Location = new System.Drawing.Point(499, 137);
            this.txSubTotal.Name = "txSubTotal";
            this.txSubTotal.Size = new System.Drawing.Size(215, 33);
            this.txSubTotal.TabIndex = 2;
            // 
            // lbSubTotal
            // 
            this.lbSubTotal.AutoSize = true;
            this.lbSubTotal.Location = new System.Drawing.Point(375, 140);
            this.lbSubTotal.Name = "lbSubTotal";
            this.lbSubTotal.Size = new System.Drawing.Size(93, 25);
            this.lbSubTotal.TabIndex = 3;
            this.lbSubTotal.Text = "SubTotal";
            // 
            // DelegateDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(747, 459);
            this.Controls.Add(this.lbSubTotal);
            this.Controls.Add(this.txSubTotal);
            this.Controls.Add(this.btnTextBox);
            this.Controls.Add(this.btnMessageBox);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "DelegateDemo";
            this.Text = "Delegate Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMessageBox;
        private System.Windows.Forms.Button btnTextBox;
        private System.Windows.Forms.TextBox txSubTotal;
        private System.Windows.Forms.Label lbSubTotal;
    }
}

