namespace Week4B
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.savingRB = new System.Windows.Forms.RadioButton();
            this.checkingRB = new System.Windows.Forms.RadioButton();
            this.createBTN = new System.Windows.Forms.Button();
            this.clearBTN = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.accountNumberTB = new System.Windows.Forms.TextBox();
            this.resultLbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addTransactionBTN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.amountNUD = new System.Windows.Forms.NumericUpDown();
            this.depositRB = new System.Windows.Forms.RadioButton();
            this.withdrawRB = new System.Windows.Forms.RadioButton();
            this.transactionsLB = new System.Windows.Forms.ListBox();
            this.accountsLB = new System.Windows.Forms.ListBox();
            this.currentBalanceTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // firstNameTB
            // 
            this.firstNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTB.Location = new System.Drawing.Point(124, 23);
            this.firstNameTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(223, 26);
            this.firstNameTB.TabIndex = 2;
            // 
            // lastNameTB
            // 
            this.lastNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTB.Location = new System.Drawing.Point(477, 23);
            this.lastNameTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(223, 26);
            this.lastNameTB.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.savingRB);
            this.groupBox1.Controls.Add(this.checkingRB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 81);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(288, 95);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Type";
            // 
            // savingRB
            // 
            this.savingRB.AutoSize = true;
            this.savingRB.Location = new System.Drawing.Point(29, 57);
            this.savingRB.Name = "savingRB";
            this.savingRB.Size = new System.Drawing.Size(138, 24);
            this.savingRB.TabIndex = 1;
            this.savingRB.TabStop = true;
            this.savingRB.Text = "Saving Account";
            this.savingRB.UseVisualStyleBackColor = true;
            // 
            // checkingRB
            // 
            this.checkingRB.AutoSize = true;
            this.checkingRB.Checked = true;
            this.checkingRB.Location = new System.Drawing.Point(29, 27);
            this.checkingRB.Name = "checkingRB";
            this.checkingRB.Size = new System.Drawing.Size(158, 24);
            this.checkingRB.TabIndex = 0;
            this.checkingRB.TabStop = true;
            this.checkingRB.Text = "Chequing Account";
            this.checkingRB.UseVisualStyleBackColor = true;
            // 
            // createBTN
            // 
            this.createBTN.Location = new System.Drawing.Point(39, 184);
            this.createBTN.Name = "createBTN";
            this.createBTN.Size = new System.Drawing.Size(98, 30);
            this.createBTN.TabIndex = 5;
            this.createBTN.Text = "Create";
            this.createBTN.UseVisualStyleBackColor = true;
            this.createBTN.Click += new System.EventHandler(this.createBTN_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.Location = new System.Drawing.Point(220, 184);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(102, 30);
            this.clearBTN.TabIndex = 6;
            this.clearBTN.Text = "Clear";
            this.clearBTN.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.accountNumberTB);
            this.groupBox2.Controls.Add(this.resultLbl);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.transactionsLB);
            this.groupBox2.Controls.Add(this.accountsLB);
            this.groupBox2.Controls.Add(this.currentBalanceTB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(39, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 460);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Infromation";
            // 
            // accountNumberTB
            // 
            this.accountNumberTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumberTB.Location = new System.Drawing.Point(156, 39);
            this.accountNumberTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accountNumberTB.Name = "accountNumberTB";
            this.accountNumberTB.ReadOnly = true;
            this.accountNumberTB.Size = new System.Drawing.Size(125, 26);
            this.accountNumberTB.TabIndex = 14;
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(20, 437);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 20);
            this.resultLbl.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addTransactionBTN);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.amountNUD);
            this.groupBox3.Controls.Add(this.depositRB);
            this.groupBox3.Controls.Add(this.withdrawRB);
            this.groupBox3.Location = new System.Drawing.Point(491, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(164, 334);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Transaction";
            // 
            // addTransactionBTN
            // 
            this.addTransactionBTN.Location = new System.Drawing.Point(23, 220);
            this.addTransactionBTN.Name = "addTransactionBTN";
            this.addTransactionBTN.Size = new System.Drawing.Size(111, 51);
            this.addTransactionBTN.TabIndex = 6;
            this.addTransactionBTN.Text = "Add Transaction";
            this.addTransactionBTN.UseVisualStyleBackColor = true;
            this.addTransactionBTN.Click += new System.EventHandler(this.addTransactionBTN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Amount:";
            // 
            // amountNUD
            // 
            this.amountNUD.DecimalPlaces = 2;
            this.amountNUD.Location = new System.Drawing.Point(23, 170);
            this.amountNUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.amountNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.amountNUD.Name = "amountNUD";
            this.amountNUD.Size = new System.Drawing.Size(111, 26);
            this.amountNUD.TabIndex = 4;
            this.amountNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // depositRB
            // 
            this.depositRB.AutoSize = true;
            this.depositRB.Location = new System.Drawing.Point(23, 78);
            this.depositRB.Name = "depositRB";
            this.depositRB.Size = new System.Drawing.Size(82, 24);
            this.depositRB.TabIndex = 3;
            this.depositRB.Text = "Deposit";
            this.depositRB.UseVisualStyleBackColor = true;
            // 
            // withdrawRB
            // 
            this.withdrawRB.AutoSize = true;
            this.withdrawRB.Checked = true;
            this.withdrawRB.Location = new System.Drawing.Point(23, 48);
            this.withdrawRB.Name = "withdrawRB";
            this.withdrawRB.Size = new System.Drawing.Size(93, 24);
            this.withdrawRB.TabIndex = 2;
            this.withdrawRB.TabStop = true;
            this.withdrawRB.Text = "Withdraw";
            this.withdrawRB.UseVisualStyleBackColor = true;
            // 
            // transactionsLB
            // 
            this.transactionsLB.FormattingEnabled = true;
            this.transactionsLB.ItemHeight = 20;
            this.transactionsLB.Location = new System.Drawing.Point(6, 257);
            this.transactionsLB.Name = "transactionsLB";
            this.transactionsLB.Size = new System.Drawing.Size(479, 164);
            this.transactionsLB.TabIndex = 11;
            // 
            // accountsLB
            // 
            this.accountsLB.FormattingEnabled = true;
            this.accountsLB.ItemHeight = 20;
            this.accountsLB.Location = new System.Drawing.Point(6, 87);
            this.accountsLB.Name = "accountsLB";
            this.accountsLB.Size = new System.Drawing.Size(479, 164);
            this.accountsLB.TabIndex = 10;
            this.accountsLB.SelectedIndexChanged += new System.EventHandler(this.accountsLB_SelectedIndexChanged);
            // 
            // currentBalanceTB
            // 
            this.currentBalanceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentBalanceTB.Location = new System.Drawing.Point(459, 39);
            this.currentBalanceTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currentBalanceTB.Name = "currentBalanceTB";
            this.currentBalanceTB.ReadOnly = true;
            this.currentBalanceTB.Size = new System.Drawing.Size(125, 26);
            this.currentBalanceTB.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(327, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Current Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Account Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 710);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.createBTN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Bank Account Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton checkingRB;
        private System.Windows.Forms.RadioButton savingRB;
        private System.Windows.Forms.Button createBTN;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox currentBalanceTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown amountNUD;
        private System.Windows.Forms.RadioButton depositRB;
        private System.Windows.Forms.RadioButton withdrawRB;
        private System.Windows.Forms.ListBox transactionsLB;
        private System.Windows.Forms.ListBox accountsLB;
        private System.Windows.Forms.TextBox accountNumberTB;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Button addTransactionBTN;
    }
}

