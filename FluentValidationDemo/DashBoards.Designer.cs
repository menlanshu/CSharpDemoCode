
namespace FluentValidationDemo
{
    partial class DashBoards
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
            this.lbCreateUser = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbAccountBalance = new System.Windows.Forms.Label();
            this.lbDataOfBirth = new System.Windows.Forms.Label();
            this.txFirstName = new System.Windows.Forms.TextBox();
            this.txLastName = new System.Windows.Forms.TextBox();
            this.txAccountBalance = new System.Windows.Forms.TextBox();
            this.dtpDataOfBirth = new System.Windows.Forms.DateTimePicker();
            this.listErrorList = new System.Windows.Forms.ListBox();
            this.lbErrorList = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCreateUser
            // 
            this.lbCreateUser.AutoSize = true;
            this.lbCreateUser.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreateUser.Location = new System.Drawing.Point(14, 36);
            this.lbCreateUser.Name = "lbCreateUser";
            this.lbCreateUser.Size = new System.Drawing.Size(164, 35);
            this.lbCreateUser.TabIndex = 0;
            this.lbCreateUser.Text = "Create User";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(12, 128);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(111, 25);
            this.lbFirstName.TabIndex = 0;
            this.lbFirstName.Text = "First Name";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(12, 169);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(110, 25);
            this.lbLastName.TabIndex = 0;
            this.lbLastName.Text = "Last Name";
            // 
            // lbAccountBalance
            // 
            this.lbAccountBalance.AutoSize = true;
            this.lbAccountBalance.Location = new System.Drawing.Point(12, 212);
            this.lbAccountBalance.Name = "lbAccountBalance";
            this.lbAccountBalance.Size = new System.Drawing.Size(166, 25);
            this.lbAccountBalance.TabIndex = 0;
            this.lbAccountBalance.Text = "Account Balance";
            // 
            // lbDataOfBirth
            // 
            this.lbDataOfBirth.AutoSize = true;
            this.lbDataOfBirth.Location = new System.Drawing.Point(12, 260);
            this.lbDataOfBirth.Name = "lbDataOfBirth";
            this.lbDataOfBirth.Size = new System.Drawing.Size(129, 25);
            this.lbDataOfBirth.TabIndex = 0;
            this.lbDataOfBirth.Text = "Data of Birth";
            // 
            // txFirstName
            // 
            this.txFirstName.Location = new System.Drawing.Point(183, 125);
            this.txFirstName.Name = "txFirstName";
            this.txFirstName.Size = new System.Drawing.Size(243, 33);
            this.txFirstName.TabIndex = 1;
            // 
            // txLastName
            // 
            this.txLastName.Location = new System.Drawing.Point(183, 166);
            this.txLastName.Name = "txLastName";
            this.txLastName.Size = new System.Drawing.Size(243, 33);
            this.txLastName.TabIndex = 1;
            // 
            // txAccountBalance
            // 
            this.txAccountBalance.Location = new System.Drawing.Point(183, 209);
            this.txAccountBalance.Name = "txAccountBalance";
            this.txAccountBalance.Size = new System.Drawing.Size(243, 33);
            this.txAccountBalance.TabIndex = 1;
            // 
            // dtpDataOfBirth
            // 
            this.dtpDataOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataOfBirth.Location = new System.Drawing.Point(183, 260);
            this.dtpDataOfBirth.Name = "dtpDataOfBirth";
            this.dtpDataOfBirth.Size = new System.Drawing.Size(243, 33);
            this.dtpDataOfBirth.TabIndex = 2;
            // 
            // listErrorList
            // 
            this.listErrorList.FormattingEnabled = true;
            this.listErrorList.ItemHeight = 25;
            this.listErrorList.Location = new System.Drawing.Point(447, 84);
            this.listErrorList.Name = "listErrorList";
            this.listErrorList.Size = new System.Drawing.Size(976, 254);
            this.listErrorList.TabIndex = 3;
            // 
            // lbErrorList
            // 
            this.lbErrorList.AutoSize = true;
            this.lbErrorList.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorList.Location = new System.Drawing.Point(441, 36);
            this.lbErrorList.Name = "lbErrorList";
            this.lbErrorList.Size = new System.Drawing.Size(129, 35);
            this.lbErrorList.TabIndex = 0;
            this.lbErrorList.Text = "Error List";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(124, 316);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(212, 38);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // DashBoards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1435, 388);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.listErrorList);
            this.Controls.Add(this.dtpDataOfBirth);
            this.Controls.Add(this.txAccountBalance);
            this.Controls.Add(this.txLastName);
            this.Controls.Add(this.txFirstName);
            this.Controls.Add(this.lbDataOfBirth);
            this.Controls.Add(this.lbAccountBalance);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.lbErrorList);
            this.Controls.Add(this.lbCreateUser);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "DashBoards";
            this.Text = "Fluent Validation Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCreateUser;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbAccountBalance;
        private System.Windows.Forms.Label lbDataOfBirth;
        private System.Windows.Forms.TextBox txFirstName;
        private System.Windows.Forms.TextBox txLastName;
        private System.Windows.Forms.TextBox txAccountBalance;
        private System.Windows.Forms.DateTimePicker dtpDataOfBirth;
        private System.Windows.Forms.ListBox listErrorList;
        private System.Windows.Forms.Label lbErrorList;
        private System.Windows.Forms.Button btnCreate;
    }
}

