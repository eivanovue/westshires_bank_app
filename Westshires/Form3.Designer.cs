namespace Westshires
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.customername = new System.Windows.Forms.TextBox();
            this.accountnumber = new System.Windows.Forms.TextBox();
            this.customercode = new System.Windows.Forms.TextBox();
            this.deposit = new System.Windows.Forms.Button();
            this.withdraw = new System.Windows.Forms.Button();
            this.txt_deposit = new System.Windows.Forms.TextBox();
            this.txt_withdraw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.overdraft = new System.Windows.Forms.TextBox();
            this.txt_interest = new System.Windows.Forms.TextBox();
            this.txt_fees = new System.Windows.Forms.TextBox();
            this.txt_ATM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go back to main menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(203, 118);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(297, 21);
            this.comboBox1.TabIndex = 37;
            this.comboBox1.Text = "Select customer";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "customer name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "account code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "customer code";
            // 
            // customername
            // 
            this.customername.Location = new System.Drawing.Point(31, 118);
            this.customername.Name = "customername";
            this.customername.ReadOnly = true;
            this.customername.Size = new System.Drawing.Size(142, 20);
            this.customername.TabIndex = 33;
            // 
            // accountnumber
            // 
            this.accountnumber.Location = new System.Drawing.Point(31, 79);
            this.accountnumber.Name = "accountnumber";
            this.accountnumber.ReadOnly = true;
            this.accountnumber.Size = new System.Drawing.Size(142, 20);
            this.accountnumber.TabIndex = 32;
            // 
            // customercode
            // 
            this.customercode.Location = new System.Drawing.Point(31, 40);
            this.customercode.Multiline = true;
            this.customercode.Name = "customercode";
            this.customercode.ReadOnly = true;
            this.customercode.Size = new System.Drawing.Size(142, 20);
            this.customercode.TabIndex = 31;
            // 
            // deposit
            // 
            this.deposit.Location = new System.Drawing.Point(203, 65);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(135, 40);
            this.deposit.TabIndex = 38;
            this.deposit.Text = "Deposit";
            this.deposit.UseVisualStyleBackColor = true;
            this.deposit.Click += new System.EventHandler(this.deposit_Click);
            // 
            // withdraw
            // 
            this.withdraw.Location = new System.Drawing.Point(365, 66);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(135, 40);
            this.withdraw.TabIndex = 39;
            this.withdraw.Text = "Withdraw";
            this.withdraw.UseVisualStyleBackColor = true;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // txt_deposit
            // 
            this.txt_deposit.Location = new System.Drawing.Point(203, 39);
            this.txt_deposit.Name = "txt_deposit";
            this.txt_deposit.Size = new System.Drawing.Size(135, 20);
            this.txt_deposit.TabIndex = 40;
            // 
            // txt_withdraw
            // 
            this.txt_withdraw.Location = new System.Drawing.Point(365, 40);
            this.txt_withdraw.Name = "txt_withdraw";
            this.txt_withdraw.Size = new System.Drawing.Size(135, 20);
            this.txt_withdraw.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Enter amount to deposit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Enter amount to withdraw";
            // 
            // balance
            // 
            this.balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.Location = new System.Drawing.Point(31, 157);
            this.balance.Name = "balance";
            this.balance.ReadOnly = true;
            this.balance.Size = new System.Drawing.Size(142, 31);
            this.balance.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "account ballance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "account overdraft";
            // 
            // overdraft
            // 
            this.overdraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overdraft.Location = new System.Drawing.Point(31, 206);
            this.overdraft.Name = "overdraft";
            this.overdraft.ReadOnly = true;
            this.overdraft.Size = new System.Drawing.Size(142, 31);
            this.overdraft.TabIndex = 46;
            // 
            // txt_interest
            // 
            this.txt_interest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_interest.Location = new System.Drawing.Point(203, 177);
            this.txt_interest.Multiline = true;
            this.txt_interest.Name = "txt_interest";
            this.txt_interest.ReadOnly = true;
            this.txt_interest.Size = new System.Drawing.Size(297, 31);
            this.txt_interest.TabIndex = 48;
            // 
            // txt_fees
            // 
            this.txt_fees.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fees.Location = new System.Drawing.Point(203, 226);
            this.txt_fees.Multiline = true;
            this.txt_fees.Name = "txt_fees";
            this.txt_fees.ReadOnly = true;
            this.txt_fees.Size = new System.Drawing.Size(297, 31);
            this.txt_fees.TabIndex = 49;
            // 
            // txt_ATM
            // 
            this.txt_ATM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ATM.Location = new System.Drawing.Point(203, 275);
            this.txt_ATM.Multiline = true;
            this.txt_ATM.Name = "txt_ATM";
            this.txt_ATM.ReadOnly = true;
            this.txt_ATM.Size = new System.Drawing.Size(297, 31);
            this.txt_ATM.TabIndex = 50;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 457);
            this.Controls.Add(this.txt_ATM);
            this.Controls.Add(this.txt_fees);
            this.Controls.Add(this.txt_interest);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.overdraft);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_withdraw);
            this.Controls.Add(this.txt_deposit);
            this.Controls.Add(this.withdraw);
            this.Controls.Add(this.deposit);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.customername);
            this.Controls.Add(this.accountnumber);
            this.Controls.Add(this.customercode);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit and Withdraw";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox customername;
        private System.Windows.Forms.TextBox accountnumber;
        private System.Windows.Forms.TextBox customercode;
        private System.Windows.Forms.Button deposit;
        private System.Windows.Forms.Button withdraw;
        private System.Windows.Forms.TextBox txt_deposit;
        private System.Windows.Forms.TextBox txt_withdraw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox overdraft;
        private System.Windows.Forms.TextBox txt_interest;
        private System.Windows.Forms.TextBox txt_fees;
        private System.Windows.Forms.TextBox txt_ATM;
    }
}