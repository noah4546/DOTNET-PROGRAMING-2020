namespace Lab3B
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hairdresserCB = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.servicesLB = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chargedItemsLB = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.priceLB = new System.Windows.Forms.ListBox();
            this.totalPriceTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addServiceBtn = new System.Windows.Forms.Button();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hairdresserCB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Hairdresser:";
            // 
            // hairdresserCB
            // 
            this.hairdresserCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hairdresserCB.FormattingEnabled = true;
            this.hairdresserCB.Items.AddRange(new object[] {
            "Jane Samley",
            "Pat Johnson",
            "Ron Chambers",
            "Sue Pallon",
            "Laura Renkins"});
            this.hairdresserCB.Location = new System.Drawing.Point(6, 25);
            this.hairdresserCB.Name = "hairdresserCB";
            this.hairdresserCB.Size = new System.Drawing.Size(171, 28);
            this.hairdresserCB.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.servicesLB);
            this.groupBox2.Location = new System.Drawing.Point(208, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select a Service:";
            // 
            // servicesLB
            // 
            this.servicesLB.FormattingEnabled = true;
            this.servicesLB.ItemHeight = 20;
            this.servicesLB.Items.AddRange(new object[] {
            "Cut",
            "Wash, blow-dry, and style",
            "Colour",
            "Highlights",
            "Extension",
            "Up-do"});
            this.servicesLB.Location = new System.Drawing.Point(6, 25);
            this.servicesLB.Name = "servicesLB";
            this.servicesLB.Size = new System.Drawing.Size(207, 164);
            this.servicesLB.TabIndex = 0;
            this.servicesLB.SelectedIndexChanged += new System.EventHandler(this.servicesLB_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chargedItemsLB);
            this.groupBox3.Location = new System.Drawing.Point(433, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 207);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Charged Items:";
            // 
            // chargedItemsLB
            // 
            this.chargedItemsLB.FormattingEnabled = true;
            this.chargedItemsLB.ItemHeight = 20;
            this.chargedItemsLB.Location = new System.Drawing.Point(6, 25);
            this.chargedItemsLB.Name = "chargedItemsLB";
            this.chargedItemsLB.Size = new System.Drawing.Size(207, 164);
            this.chargedItemsLB.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.priceLB);
            this.groupBox4.Location = new System.Drawing.Point(658, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(114, 207);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Price:";
            // 
            // priceLB
            // 
            this.priceLB.FormattingEnabled = true;
            this.priceLB.ItemHeight = 20;
            this.priceLB.Location = new System.Drawing.Point(6, 24);
            this.priceLB.Name = "priceLB";
            this.priceLB.Size = new System.Drawing.Size(97, 164);
            this.priceLB.TabIndex = 1;
            // 
            // totalPriceTB
            // 
            this.totalPriceTB.Location = new System.Drawing.Point(658, 237);
            this.totalPriceTB.Name = "totalPriceTB";
            this.totalPriceTB.ReadOnly = true;
            this.totalPriceTB.Size = new System.Drawing.Size(114, 26);
            this.totalPriceTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(565, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Price:";
            // 
            // addServiceBtn
            // 
            this.addServiceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addServiceBtn.Location = new System.Drawing.Point(139, 279);
            this.addServiceBtn.Name = "addServiceBtn";
            this.addServiceBtn.Size = new System.Drawing.Size(154, 32);
            this.addServiceBtn.TabIndex = 5;
            this.addServiceBtn.Text = "Add Service";
            this.addServiceBtn.UseVisualStyleBackColor = true;
            this.addServiceBtn.Click += new System.EventHandler(this.addServiceBtn_Click);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBtn.Location = new System.Drawing.Point(299, 279);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(154, 32);
            this.calculateBtn.TabIndex = 6;
            this.calculateBtn.Text = "Calculate Total";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(459, 279);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(154, 32);
            this.resetBtn.TabIndex = 7;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(619, 279);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(154, 32);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 326);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.addServiceBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalPriceTB);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox hairdresserCB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox servicesLB;
        private System.Windows.Forms.ListBox chargedItemsLB;
        private System.Windows.Forms.ListBox priceLB;
        private System.Windows.Forms.TextBox totalPriceTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addServiceBtn;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

