namespace Westshires
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.button1 = new System.Windows.Forms.Button();
            this.change_nickname = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.customername = new System.Windows.Forms.TextBox();
            this.accountnumber = new System.Windows.Forms.TextBox();
            this.customercode = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.accountnickname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.overdraft = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(341, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go back to main menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // change_nickname
            // 
            this.change_nickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_nickname.Location = new System.Drawing.Point(199, 67);
            this.change_nickname.Name = "change_nickname";
            this.change_nickname.Size = new System.Drawing.Size(165, 98);
            this.change_nickname.TabIndex = 7;
            this.change_nickname.Text = "Change account nickname and overdraft";
            this.change_nickname.UseVisualStyleBackColor = true;
            this.change_nickname.Click += new System.EventHandler(this.change_nickname_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "customer name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "account code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "customer code";
            // 
            // customername
            // 
            this.customername.Location = new System.Drawing.Point(23, 148);
            this.customername.Name = "customername";
            this.customername.ReadOnly = true;
            this.customername.Size = new System.Drawing.Size(142, 20);
            this.customername.TabIndex = 20;
            // 
            // accountnumber
            // 
            this.accountnumber.Location = new System.Drawing.Point(23, 109);
            this.accountnumber.Name = "accountnumber";
            this.accountnumber.ReadOnly = true;
            this.accountnumber.Size = new System.Drawing.Size(142, 20);
            this.accountnumber.TabIndex = 19;
            // 
            // customercode
            // 
            this.customercode.Location = new System.Drawing.Point(23, 70);
            this.customercode.Multiline = true;
            this.customercode.Name = "customercode";
            this.customercode.ReadOnly = true;
            this.customercode.Size = new System.Drawing.Size(142, 20);
            this.customercode.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 21);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // accountnickname
            // 
            this.accountnickname.Location = new System.Drawing.Point(23, 187);
            this.accountnickname.Name = "accountnickname";
            this.accountnickname.Size = new System.Drawing.Size(142, 20);
            this.accountnickname.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "account nickname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "overdraft";
            // 
            // overdraft
            // 
            this.overdraft.Location = new System.Drawing.Point(23, 224);
            this.overdraft.Name = "overdraft";
            this.overdraft.Size = new System.Drawing.Size(142, 20);
            this.overdraft.TabIndex = 31;
            this.overdraft.MouseClick += new System.Windows.Forms.MouseEventHandler(this.overdraft_MouseClick);
            this.overdraft.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.overdraft_KeyPress);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 307);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.overdraft);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.accountnickname);
            this.Controls.Add(this.customername);
            this.Controls.Add(this.accountnumber);
            this.Controls.Add(this.customercode);
            this.Controls.Add(this.change_nickname);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Overdraft limit and Nickname";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button change_nickname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox customername;
        private System.Windows.Forms.TextBox accountnumber;
        private System.Windows.Forms.TextBox customercode;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox accountnickname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox overdraft;
    }
}