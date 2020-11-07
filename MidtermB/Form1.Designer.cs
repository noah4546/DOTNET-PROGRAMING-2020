namespace MidtermB
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
            this.weatherLB = new System.Windows.Forms.ListBox();
            this.legendLabel = new System.Windows.Forms.Label();
            this.averageTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.highestTB = new System.Windows.Forms.TextBox();
            this.addMonthCB = new System.Windows.Forms.ComboBox();
            this.addYearNUD = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addRainNUD = new System.Windows.Forms.NumericUpDown();
            this.addTempNUD = new System.Windows.Forms.NumericUpDown();
            this.addNewBtn = new System.Windows.Forms.Button();
            this.sortRainFall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.addYearNUD)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addRainNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addTempNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // weatherLB
            // 
            this.weatherLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weatherLB.FormattingEnabled = true;
            this.weatherLB.ItemHeight = 24;
            this.weatherLB.Location = new System.Drawing.Point(15, 48);
            this.weatherLB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.weatherLB.Name = "weatherLB";
            this.weatherLB.Size = new System.Drawing.Size(612, 508);
            this.weatherLB.TabIndex = 0;
            // 
            // legendLabel
            // 
            this.legendLabel.AutoSize = true;
            this.legendLabel.Location = new System.Drawing.Point(11, 18);
            this.legendLabel.Name = "legendLabel";
            this.legendLabel.Size = new System.Drawing.Size(603, 24);
            this.legendLabel.TabIndex = 1;
            this.legendLabel.Text = "Month                         | Year        | RainFall (mm)          | Temperatur" +
    "e (°c)";
            // 
            // averageTB
            // 
            this.averageTB.Location = new System.Drawing.Point(196, 565);
            this.averageTB.Name = "averageTB";
            this.averageTB.ReadOnly = true;
            this.averageTB.Size = new System.Drawing.Size(100, 29);
            this.averageTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 568);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Average Temp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 568);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Highest Temp:";
            // 
            // highestTB
            // 
            this.highestTB.Location = new System.Drawing.Point(460, 565);
            this.highestTB.Name = "highestTB";
            this.highestTB.ReadOnly = true;
            this.highestTB.Size = new System.Drawing.Size(100, 29);
            this.highestTB.TabIndex = 4;
            // 
            // addMonthCB
            // 
            this.addMonthCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addMonthCB.FormattingEnabled = true;
            this.addMonthCB.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.addMonthCB.Location = new System.Drawing.Point(162, 116);
            this.addMonthCB.Name = "addMonthCB";
            this.addMonthCB.Size = new System.Drawing.Size(121, 32);
            this.addMonthCB.TabIndex = 6;
            // 
            // addYearNUD
            // 
            this.addYearNUD.Location = new System.Drawing.Point(163, 154);
            this.addYearNUD.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.addYearNUD.Name = "addYearNUD";
            this.addYearNUD.Size = new System.Drawing.Size(120, 29);
            this.addYearNUD.TabIndex = 7;
            this.addYearNUD.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addNewBtn);
            this.groupBox1.Controls.Add(this.addTempNUD);
            this.groupBox1.Controls.Add(this.addRainNUD);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.addMonthCB);
            this.groupBox1.Controls.Add(this.addYearNUD);
            this.groupBox1.Location = new System.Drawing.Point(636, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 538);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Month:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Year:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rain Fall:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Temperature:";
            // 
            // addRainNUD
            // 
            this.addRainNUD.Location = new System.Drawing.Point(163, 189);
            this.addRainNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.addRainNUD.Name = "addRainNUD";
            this.addRainNUD.Size = new System.Drawing.Size(120, 29);
            this.addRainNUD.TabIndex = 12;
            // 
            // addTempNUD
            // 
            this.addTempNUD.DecimalPlaces = 1;
            this.addTempNUD.Location = new System.Drawing.Point(163, 224);
            this.addTempNUD.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.addTempNUD.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.addTempNUD.Name = "addTempNUD";
            this.addTempNUD.Size = new System.Drawing.Size(120, 29);
            this.addTempNUD.TabIndex = 13;
            // 
            // addNewBtn
            // 
            this.addNewBtn.Location = new System.Drawing.Point(106, 301);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Size = new System.Drawing.Size(120, 66);
            this.addNewBtn.TabIndex = 14;
            this.addNewBtn.Text = "Add New";
            this.addNewBtn.UseVisualStyleBackColor = true;
            this.addNewBtn.Click += new System.EventHandler(this.addNewBtn_Click);
            // 
            // sortRainFall
            // 
            this.sortRainFall.Location = new System.Drawing.Point(708, 563);
            this.sortRainFall.Name = "sortRainFall";
            this.sortRainFall.Size = new System.Drawing.Size(179, 34);
            this.sortRainFall.TabIndex = 9;
            this.sortRainFall.Text = "Sort by Rain Fall";
            this.sortRainFall.UseVisualStyleBackColor = true;
            this.sortRainFall.Click += new System.EventHandler(this.sortRainFall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 609);
            this.Controls.Add(this.sortRainFall);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.highestTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.averageTB);
            this.Controls.Add(this.legendLabel);
            this.Controls.Add(this.weatherLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Weather, Noah Tomkins, 000790079";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addYearNUD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addRainNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addTempNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox weatherLB;
        private System.Windows.Forms.Label legendLabel;
        private System.Windows.Forms.TextBox averageTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox highestTB;
        private System.Windows.Forms.ComboBox addMonthCB;
        private System.Windows.Forms.NumericUpDown addYearNUD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown addTempNUD;
        private System.Windows.Forms.NumericUpDown addRainNUD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addNewBtn;
        private System.Windows.Forms.Button sortRainFall;
    }
}

