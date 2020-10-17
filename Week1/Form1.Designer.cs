namespace Week1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.errorLbl = new System.Windows.Forms.Label();
            this.calculateBTN = new System.Windows.Forms.Button();
            this.grossPayTB = new System.Windows.Forms.TextBox();
            this.hourlyPayTB = new System.Windows.Forms.TextBox();
            this.hoursWorkedTB = new System.Windows.Forms.TextBox();
            this.grossPayLbl = new System.Windows.Forms.Label();
            this.hourlyPayLbl = new System.Windows.Forms.Label();
            this.hoursWorkedLbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.hourlyPayNUD = new System.Windows.Forms.NumericUpDown();
            this.hoursWorkedNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.calculateBtn2 = new System.Windows.Forms.Button();
            this.grossPayTB2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hourlyPayNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursWorkedNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.errorLbl);
            this.tabPage1.Controls.Add(this.calculateBTN);
            this.tabPage1.Controls.Add(this.grossPayTB);
            this.tabPage1.Controls.Add(this.hourlyPayTB);
            this.tabPage1.Controls.Add(this.hoursWorkedTB);
            this.tabPage1.Controls.Add(this.grossPayLbl);
            this.tabPage1.Controls.Add(this.hourlyPayLbl);
            this.tabPage1.Controls.Add(this.hoursWorkedLbl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Text Boxes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(196, 248);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 25);
            this.errorLbl.TabIndex = 7;
            // 
            // calculateBTN
            // 
            this.calculateBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBTN.Location = new System.Drawing.Point(199, 174);
            this.calculateBTN.Name = "calculateBTN";
            this.calculateBTN.Size = new System.Drawing.Size(149, 50);
            this.calculateBTN.TabIndex = 6;
            this.calculateBTN.Text = "Calculate";
            this.calculateBTN.UseVisualStyleBackColor = true;
            this.calculateBTN.Click += new System.EventHandler(this.calculateBTN_Click);
            // 
            // grossPayTB
            // 
            this.grossPayTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossPayTB.Location = new System.Drawing.Point(199, 129);
            this.grossPayTB.Name = "grossPayTB";
            this.grossPayTB.ReadOnly = true;
            this.grossPayTB.Size = new System.Drawing.Size(149, 29);
            this.grossPayTB.TabIndex = 5;
            // 
            // hourlyPayTB
            // 
            this.hourlyPayTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourlyPayTB.Location = new System.Drawing.Point(199, 80);
            this.hourlyPayTB.Name = "hourlyPayTB";
            this.hourlyPayTB.Size = new System.Drawing.Size(149, 29);
            this.hourlyPayTB.TabIndex = 4;
            // 
            // hoursWorkedTB
            // 
            this.hoursWorkedTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursWorkedTB.Location = new System.Drawing.Point(199, 33);
            this.hoursWorkedTB.Name = "hoursWorkedTB";
            this.hoursWorkedTB.Size = new System.Drawing.Size(149, 29);
            this.hoursWorkedTB.TabIndex = 3;
            // 
            // grossPayLbl
            // 
            this.grossPayLbl.AutoSize = true;
            this.grossPayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossPayLbl.Location = new System.Drawing.Point(93, 132);
            this.grossPayLbl.Name = "grossPayLbl";
            this.grossPayLbl.Size = new System.Drawing.Size(100, 24);
            this.grossPayLbl.TabIndex = 2;
            this.grossPayLbl.Text = "Gross Pay:";
            // 
            // hourlyPayLbl
            // 
            this.hourlyPayLbl.AutoSize = true;
            this.hourlyPayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourlyPayLbl.Location = new System.Drawing.Point(87, 83);
            this.hourlyPayLbl.Name = "hourlyPayLbl";
            this.hourlyPayLbl.Size = new System.Drawing.Size(106, 24);
            this.hourlyPayLbl.TabIndex = 1;
            this.hourlyPayLbl.Text = "Hourly Pay:";
            // 
            // hoursWorkedLbl
            // 
            this.hoursWorkedLbl.AutoSize = true;
            this.hoursWorkedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursWorkedLbl.Location = new System.Drawing.Point(56, 36);
            this.hoursWorkedLbl.Name = "hoursWorkedLbl";
            this.hoursWorkedLbl.Size = new System.Drawing.Size(137, 24);
            this.hoursWorkedLbl.TabIndex = 0;
            this.hoursWorkedLbl.Text = "Hours Worked:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.hourlyPayNUD);
            this.tabPage2.Controls.Add(this.hoursWorkedNUD);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.calculateBtn2);
            this.tabPage2.Controls.Add(this.grossPayTB2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Numeric Up Down";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // hourlyPayNUD
            // 
            this.hourlyPayNUD.DecimalPlaces = 2;
            this.hourlyPayNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourlyPayNUD.Location = new System.Drawing.Point(182, 82);
            this.hourlyPayNUD.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.hourlyPayNUD.Minimum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.hourlyPayNUD.Name = "hourlyPayNUD";
            this.hourlyPayNUD.Size = new System.Drawing.Size(147, 29);
            this.hourlyPayNUD.TabIndex = 17;
            this.hourlyPayNUD.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // hoursWorkedNUD
            // 
            this.hoursWorkedNUD.DecimalPlaces = 2;
            this.hoursWorkedNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursWorkedNUD.Location = new System.Drawing.Point(182, 33);
            this.hoursWorkedNUD.Name = "hoursWorkedNUD";
            this.hoursWorkedNUD.Size = new System.Drawing.Size(147, 29);
            this.hoursWorkedNUD.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(177, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 15;
            // 
            // calculateBtn2
            // 
            this.calculateBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBtn2.Location = new System.Drawing.Point(180, 173);
            this.calculateBtn2.Name = "calculateBtn2";
            this.calculateBtn2.Size = new System.Drawing.Size(149, 50);
            this.calculateBtn2.TabIndex = 14;
            this.calculateBtn2.Text = "Calculate";
            this.calculateBtn2.UseVisualStyleBackColor = true;
            this.calculateBtn2.Click += new System.EventHandler(this.calculateBtn2_Click);
            // 
            // grossPayTB2
            // 
            this.grossPayTB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossPayTB2.Location = new System.Drawing.Point(180, 128);
            this.grossPayTB2.Name = "grossPayTB2";
            this.grossPayTB2.ReadOnly = true;
            this.grossPayTB2.Size = new System.Drawing.Size(149, 29);
            this.grossPayTB2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gross Pay:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hourly Pay:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hours Worked:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "COMP 10204 - Week 1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hourlyPayNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursWorkedNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label grossPayLbl;
        private System.Windows.Forms.Label hourlyPayLbl;
        private System.Windows.Forms.Label hoursWorkedLbl;
        private System.Windows.Forms.TextBox grossPayTB;
        private System.Windows.Forms.TextBox hourlyPayTB;
        private System.Windows.Forms.TextBox hoursWorkedTB;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button calculateBTN;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculateBtn2;
        private System.Windows.Forms.TextBox grossPayTB2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown hourlyPayNUD;
        private System.Windows.Forms.NumericUpDown hoursWorkedNUD;
    }
}

