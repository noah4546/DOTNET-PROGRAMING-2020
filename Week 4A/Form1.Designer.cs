namespace Week_4A
{
    partial class membershipFeeCalculator
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
            this.typeOfMembershipGB = new System.Windows.Forms.GroupBox();
            this.membershipSeniorRB = new System.Windows.Forms.RadioButton();
            this.membershipStudentRB = new System.Windows.Forms.RadioButton();
            this.membershipChildRB = new System.Windows.Forms.RadioButton();
            this.membershipAdultRB = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.optionsGB = new System.Windows.Forms.GroupBox();
            this.trainerCB = new System.Windows.Forms.CheckBox();
            this.karateCB = new System.Windows.Forms.CheckBox();
            this.yogaCB = new System.Windows.Forms.CheckBox();
            this.membershipLengthGB = new System.Windows.Forms.GroupBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.monthsNUD = new System.Windows.Forms.NumericUpDown();
            this.membershipFeesGB = new System.Windows.Forms.GroupBox();
            this.totalTB = new System.Windows.Forms.TextBox();
            this.monthlyFeeTB = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.mothlyFeeLabel = new System.Windows.Forms.Label();
            this.calculateBTN = new System.Windows.Forms.Button();
            this.clearBTN = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.Button();
            this.typeOfMembershipGB.SuspendLayout();
            this.optionsGB.SuspendLayout();
            this.membershipLengthGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthsNUD)).BeginInit();
            this.membershipFeesGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeOfMembershipGB
            // 
            this.typeOfMembershipGB.Controls.Add(this.membershipSeniorRB);
            this.typeOfMembershipGB.Controls.Add(this.membershipStudentRB);
            this.typeOfMembershipGB.Controls.Add(this.membershipChildRB);
            this.typeOfMembershipGB.Controls.Add(this.membershipAdultRB);
            this.typeOfMembershipGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeOfMembershipGB.Location = new System.Drawing.Point(12, 12);
            this.typeOfMembershipGB.Name = "typeOfMembershipGB";
            this.typeOfMembershipGB.Size = new System.Drawing.Size(206, 159);
            this.typeOfMembershipGB.TabIndex = 0;
            this.typeOfMembershipGB.TabStop = false;
            this.typeOfMembershipGB.Text = "Type of Membership";
            // 
            // membershipSeniorRB
            // 
            this.membershipSeniorRB.AutoSize = true;
            this.membershipSeniorRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membershipSeniorRB.Location = new System.Drawing.Point(26, 124);
            this.membershipSeniorRB.Name = "membershipSeniorRB";
            this.membershipSeniorRB.Size = new System.Drawing.Size(125, 24);
            this.membershipSeniorRB.TabIndex = 3;
            this.membershipSeniorRB.TabStop = true;
            this.membershipSeniorRB.Text = "Senior Citizen";
            this.membershipSeniorRB.UseVisualStyleBackColor = true;
            // 
            // membershipStudentRB
            // 
            this.membershipStudentRB.AutoSize = true;
            this.membershipStudentRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membershipStudentRB.Location = new System.Drawing.Point(26, 94);
            this.membershipStudentRB.Name = "membershipStudentRB";
            this.membershipStudentRB.Size = new System.Drawing.Size(84, 24);
            this.membershipStudentRB.TabIndex = 2;
            this.membershipStudentRB.TabStop = true;
            this.membershipStudentRB.Text = "Student";
            this.membershipStudentRB.UseVisualStyleBackColor = true;
            // 
            // membershipChildRB
            // 
            this.membershipChildRB.AutoSize = true;
            this.membershipChildRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membershipChildRB.Location = new System.Drawing.Point(26, 64);
            this.membershipChildRB.Name = "membershipChildRB";
            this.membershipChildRB.Size = new System.Drawing.Size(154, 24);
            this.membershipChildRB.TabIndex = 1;
            this.membershipChildRB.TabStop = true;
            this.membershipChildRB.Text = "Child (12 && under)";
            this.membershipChildRB.UseVisualStyleBackColor = true;
            // 
            // membershipAdultRB
            // 
            this.membershipAdultRB.AutoSize = true;
            this.membershipAdultRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membershipAdultRB.Location = new System.Drawing.Point(26, 34);
            this.membershipAdultRB.Name = "membershipAdultRB";
            this.membershipAdultRB.Size = new System.Drawing.Size(134, 24);
            this.membershipAdultRB.TabIndex = 0;
            this.membershipAdultRB.TabStop = true;
            this.membershipAdultRB.Text = "Standard Adult";
            this.membershipAdultRB.UseVisualStyleBackColor = true;
            // 
            // optionsGB
            // 
            this.optionsGB.Controls.Add(this.trainerCB);
            this.optionsGB.Controls.Add(this.karateCB);
            this.optionsGB.Controls.Add(this.yogaCB);
            this.optionsGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsGB.Location = new System.Drawing.Point(224, 12);
            this.optionsGB.Name = "optionsGB";
            this.optionsGB.Size = new System.Drawing.Size(279, 159);
            this.optionsGB.TabIndex = 1;
            this.optionsGB.TabStop = false;
            this.optionsGB.Text = "Options";
            // 
            // trainerCB
            // 
            this.trainerCB.AutoSize = true;
            this.trainerCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainerCB.Location = new System.Drawing.Point(60, 105);
            this.trainerCB.Name = "trainerCB";
            this.trainerCB.Size = new System.Drawing.Size(143, 24);
            this.trainerCB.TabIndex = 2;
            this.trainerCB.Text = "Personal Trainer";
            this.trainerCB.UseVisualStyleBackColor = true;
            // 
            // karateCB
            // 
            this.karateCB.AutoSize = true;
            this.karateCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.karateCB.Location = new System.Drawing.Point(60, 75);
            this.karateCB.Name = "karateCB";
            this.karateCB.Size = new System.Drawing.Size(75, 24);
            this.karateCB.TabIndex = 1;
            this.karateCB.Text = "Karate";
            this.karateCB.UseVisualStyleBackColor = true;
            // 
            // yogaCB
            // 
            this.yogaCB.AutoSize = true;
            this.yogaCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yogaCB.Location = new System.Drawing.Point(60, 45);
            this.yogaCB.Name = "yogaCB";
            this.yogaCB.Size = new System.Drawing.Size(66, 24);
            this.yogaCB.TabIndex = 0;
            this.yogaCB.Text = "Yoga";
            this.yogaCB.UseVisualStyleBackColor = true;
            // 
            // membershipLengthGB
            // 
            this.membershipLengthGB.Controls.Add(this.lengthLabel);
            this.membershipLengthGB.Controls.Add(this.monthsNUD);
            this.membershipLengthGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membershipLengthGB.Location = new System.Drawing.Point(12, 177);
            this.membershipLengthGB.Name = "membershipLengthGB";
            this.membershipLengthGB.Size = new System.Drawing.Size(206, 146);
            this.membershipLengthGB.TabIndex = 2;
            this.membershipLengthGB.TabStop = false;
            this.membershipLengthGB.Text = "Membership Length";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthLabel.Location = new System.Drawing.Point(25, 50);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(135, 40);
            this.lengthLabel.TabIndex = 1;
            this.lengthLabel.Text = "Enter the Number\r\nof Months:\r\n";
            // 
            // monthsNUD
            // 
            this.monthsNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthsNUD.Location = new System.Drawing.Point(26, 99);
            this.monthsNUD.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.monthsNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.monthsNUD.Name = "monthsNUD";
            this.monthsNUD.Size = new System.Drawing.Size(154, 26);
            this.monthsNUD.TabIndex = 0;
            this.monthsNUD.Tag = "12";
            this.monthsNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // membershipFeesGB
            // 
            this.membershipFeesGB.Controls.Add(this.totalTB);
            this.membershipFeesGB.Controls.Add(this.monthlyFeeTB);
            this.membershipFeesGB.Controls.Add(this.totalLabel);
            this.membershipFeesGB.Controls.Add(this.mothlyFeeLabel);
            this.membershipFeesGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membershipFeesGB.Location = new System.Drawing.Point(224, 177);
            this.membershipFeesGB.Name = "membershipFeesGB";
            this.membershipFeesGB.Size = new System.Drawing.Size(279, 146);
            this.membershipFeesGB.TabIndex = 3;
            this.membershipFeesGB.TabStop = false;
            this.membershipFeesGB.Text = "Membership Fees";
            // 
            // totalTB
            // 
            this.totalTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTB.Location = new System.Drawing.Point(132, 98);
            this.totalTB.Name = "totalTB";
            this.totalTB.ReadOnly = true;
            this.totalTB.Size = new System.Drawing.Size(125, 26);
            this.totalTB.TabIndex = 3;
            // 
            // monthlyFeeTB
            // 
            this.monthlyFeeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyFeeTB.Location = new System.Drawing.Point(132, 47);
            this.monthlyFeeTB.Name = "monthlyFeeTB";
            this.monthlyFeeTB.ReadOnly = true;
            this.monthlyFeeTB.Size = new System.Drawing.Size(125, 26);
            this.monthlyFeeTB.TabIndex = 2;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(78, 99);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(48, 20);
            this.totalLabel.TabIndex = 1;
            this.totalLabel.Text = "Total:";
            // 
            // mothlyFeeLabel
            // 
            this.mothlyFeeLabel.AutoSize = true;
            this.mothlyFeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mothlyFeeLabel.Location = new System.Drawing.Point(26, 50);
            this.mothlyFeeLabel.Name = "mothlyFeeLabel";
            this.mothlyFeeLabel.Size = new System.Drawing.Size(100, 20);
            this.mothlyFeeLabel.TabIndex = 0;
            this.mothlyFeeLabel.Text = "Monthly Fee:";
            // 
            // calculateBTN
            // 
            this.calculateBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBTN.Location = new System.Drawing.Point(92, 340);
            this.calculateBTN.Name = "calculateBTN";
            this.calculateBTN.Size = new System.Drawing.Size(100, 35);
            this.calculateBTN.TabIndex = 4;
            this.calculateBTN.Text = "Calculate";
            this.calculateBTN.UseVisualStyleBackColor = true;
            this.calculateBTN.Click += new System.EventHandler(this.calculateBTN_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBTN.Location = new System.Drawing.Point(198, 340);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(100, 35);
            this.clearBTN.TabIndex = 5;
            this.clearBTN.Text = "Clear";
            this.clearBTN.UseVisualStyleBackColor = true;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBTN.Location = new System.Drawing.Point(304, 340);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(100, 35);
            this.exitBTN.TabIndex = 6;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // membershipFeeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 390);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.calculateBTN);
            this.Controls.Add(this.membershipFeesGB);
            this.Controls.Add(this.membershipLengthGB);
            this.Controls.Add(this.optionsGB);
            this.Controls.Add(this.typeOfMembershipGB);
            this.Name = "membershipFeeCalculator";
            this.Text = "Membership Fee Calculator";
            this.typeOfMembershipGB.ResumeLayout(false);
            this.typeOfMembershipGB.PerformLayout();
            this.optionsGB.ResumeLayout(false);
            this.optionsGB.PerformLayout();
            this.membershipLengthGB.ResumeLayout(false);
            this.membershipLengthGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthsNUD)).EndInit();
            this.membershipFeesGB.ResumeLayout(false);
            this.membershipFeesGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox typeOfMembershipGB;
        private System.Windows.Forms.RadioButton membershipAdultRB;
        private System.Windows.Forms.RadioButton membershipSeniorRB;
        private System.Windows.Forms.RadioButton membershipStudentRB;
        private System.Windows.Forms.RadioButton membershipChildRB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox optionsGB;
        private System.Windows.Forms.CheckBox trainerCB;
        private System.Windows.Forms.CheckBox karateCB;
        private System.Windows.Forms.CheckBox yogaCB;
        private System.Windows.Forms.GroupBox membershipLengthGB;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.NumericUpDown monthsNUD;
        private System.Windows.Forms.GroupBox membershipFeesGB;
        private System.Windows.Forms.TextBox totalTB;
        private System.Windows.Forms.TextBox monthlyFeeTB;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label mothlyFeeLabel;
        private System.Windows.Forms.Button calculateBTN;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.Button exitBTN;
    }
}

