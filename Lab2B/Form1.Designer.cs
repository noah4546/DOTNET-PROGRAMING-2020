namespace Lab2B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Hairdresser = new System.Windows.Forms.GroupBox();
            this.janeRB = new System.Windows.Forms.RadioButton();
            this.patRB = new System.Windows.Forms.RadioButton();
            this.ronRB = new System.Windows.Forms.RadioButton();
            this.sueRB = new System.Windows.Forms.RadioButton();
            this.lauraRB = new System.Windows.Forms.RadioButton();
            this.Serives = new System.Windows.Forms.GroupBox();
            this.cutCB = new System.Windows.Forms.CheckBox();
            this.colorCB = new System.Windows.Forms.CheckBox();
            this.highlightsCB = new System.Windows.Forms.CheckBox();
            this.extentionsCB = new System.Windows.Forms.CheckBox();
            this.ClientType = new System.Windows.Forms.GroupBox();
            this.seniorRB = new System.Windows.Forms.RadioButton();
            this.studentRB = new System.Windows.Forms.RadioButton();
            this.childRB = new System.Windows.Forms.RadioButton();
            this.adultRB = new System.Windows.Forms.RadioButton();
            this.ClientVisits = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalPriceLbl = new System.Windows.Forms.Label();
            this.calculateBTN = new System.Windows.Forms.Button();
            this.clearBTN = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.Button();
            this.visitsTB = new System.Windows.Forms.TextBox();
            this.Hairdresser.SuspendLayout();
            this.Serives.SuspendLayout();
            this.ClientType.SuspendLayout();
            this.ClientVisits.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hairdresser
            // 
            this.Hairdresser.Controls.Add(this.lauraRB);
            this.Hairdresser.Controls.Add(this.sueRB);
            this.Hairdresser.Controls.Add(this.ronRB);
            this.Hairdresser.Controls.Add(this.patRB);
            this.Hairdresser.Controls.Add(this.janeRB);
            this.Hairdresser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hairdresser.Location = new System.Drawing.Point(15, 14);
            this.Hairdresser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Hairdresser.Name = "Hairdresser";
            this.Hairdresser.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Hairdresser.Size = new System.Drawing.Size(259, 266);
            this.Hairdresser.TabIndex = 0;
            this.Hairdresser.TabStop = false;
            this.Hairdresser.Text = "Hairdresser";
            // 
            // janeRB
            // 
            this.janeRB.AutoSize = true;
            this.janeRB.Checked = true;
            this.janeRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.janeRB.Location = new System.Drawing.Point(26, 43);
            this.janeRB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.janeRB.Name = "janeRB";
            this.janeRB.Size = new System.Drawing.Size(136, 28);
            this.janeRB.TabIndex = 0;
            this.janeRB.TabStop = true;
            this.janeRB.Text = "Jane Samley";
            this.janeRB.UseVisualStyleBackColor = true;
            // 
            // patRB
            // 
            this.patRB.AutoSize = true;
            this.patRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patRB.Location = new System.Drawing.Point(26, 84);
            this.patRB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.patRB.Name = "patRB";
            this.patRB.Size = new System.Drawing.Size(132, 28);
            this.patRB.TabIndex = 1;
            this.patRB.Text = "Pat Johnson";
            this.patRB.UseVisualStyleBackColor = true;
            // 
            // ronRB
            // 
            this.ronRB.AutoSize = true;
            this.ronRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ronRB.Location = new System.Drawing.Point(26, 125);
            this.ronRB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ronRB.Name = "ronRB";
            this.ronRB.Size = new System.Drawing.Size(155, 28);
            this.ronRB.TabIndex = 2;
            this.ronRB.Text = "Ron Chambers";
            this.ronRB.UseVisualStyleBackColor = true;
            // 
            // sueRB
            // 
            this.sueRB.AutoSize = true;
            this.sueRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sueRB.Location = new System.Drawing.Point(26, 166);
            this.sueRB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sueRB.Name = "sueRB";
            this.sueRB.Size = new System.Drawing.Size(119, 28);
            this.sueRB.TabIndex = 3;
            this.sueRB.Text = "Sue Pallon";
            this.sueRB.UseVisualStyleBackColor = true;
            // 
            // lauraRB
            // 
            this.lauraRB.AutoSize = true;
            this.lauraRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lauraRB.Location = new System.Drawing.Point(26, 206);
            this.lauraRB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lauraRB.Name = "lauraRB";
            this.lauraRB.Size = new System.Drawing.Size(148, 28);
            this.lauraRB.TabIndex = 4;
            this.lauraRB.Text = "Laura Renkins";
            this.lauraRB.UseVisualStyleBackColor = true;
            // 
            // Serives
            // 
            this.Serives.Controls.Add(this.extentionsCB);
            this.Serives.Controls.Add(this.highlightsCB);
            this.Serives.Controls.Add(this.colorCB);
            this.Serives.Controls.Add(this.cutCB);
            this.Serives.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Serives.Location = new System.Drawing.Point(281, 14);
            this.Serives.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Serives.Name = "Serives";
            this.Serives.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Serives.Size = new System.Drawing.Size(259, 266);
            this.Serives.TabIndex = 1;
            this.Serives.TabStop = false;
            this.Serives.Text = "Services";
            // 
            // cutCB
            // 
            this.cutCB.AutoSize = true;
            this.cutCB.Location = new System.Drawing.Point(28, 44);
            this.cutCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cutCB.Name = "cutCB";
            this.cutCB.Size = new System.Drawing.Size(57, 28);
            this.cutCB.TabIndex = 0;
            this.cutCB.Text = "Cut";
            this.cutCB.UseVisualStyleBackColor = true;
            // 
            // colorCB
            // 
            this.colorCB.AutoSize = true;
            this.colorCB.Location = new System.Drawing.Point(28, 98);
            this.colorCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colorCB.Name = "colorCB";
            this.colorCB.Size = new System.Drawing.Size(74, 28);
            this.colorCB.TabIndex = 1;
            this.colorCB.Text = "Color";
            this.colorCB.UseVisualStyleBackColor = true;
            // 
            // highlightsCB
            // 
            this.highlightsCB.AutoSize = true;
            this.highlightsCB.Location = new System.Drawing.Point(28, 152);
            this.highlightsCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.highlightsCB.Name = "highlightsCB";
            this.highlightsCB.Size = new System.Drawing.Size(112, 28);
            this.highlightsCB.TabIndex = 2;
            this.highlightsCB.Text = "Highlights";
            this.highlightsCB.UseVisualStyleBackColor = true;
            // 
            // extentionsCB
            // 
            this.extentionsCB.AutoSize = true;
            this.extentionsCB.Location = new System.Drawing.Point(28, 206);
            this.extentionsCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.extentionsCB.Name = "extentionsCB";
            this.extentionsCB.Size = new System.Drawing.Size(117, 28);
            this.extentionsCB.TabIndex = 3;
            this.extentionsCB.Text = "Extentions";
            this.extentionsCB.UseVisualStyleBackColor = true;
            // 
            // ClientType
            // 
            this.ClientType.Controls.Add(this.seniorRB);
            this.ClientType.Controls.Add(this.studentRB);
            this.ClientType.Controls.Add(this.childRB);
            this.ClientType.Controls.Add(this.adultRB);
            this.ClientType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientType.Location = new System.Drawing.Point(15, 288);
            this.ClientType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClientType.Name = "ClientType";
            this.ClientType.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClientType.Size = new System.Drawing.Size(259, 218);
            this.ClientType.TabIndex = 2;
            this.ClientType.TabStop = false;
            this.ClientType.Text = "Client Type";
            // 
            // seniorRB
            // 
            this.seniorRB.AutoSize = true;
            this.seniorRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seniorRB.Location = new System.Drawing.Point(26, 166);
            this.seniorRB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.seniorRB.Name = "seniorRB";
            this.seniorRB.Size = new System.Drawing.Size(83, 28);
            this.seniorRB.TabIndex = 3;
            this.seniorRB.Text = "Senior";
            this.seniorRB.UseVisualStyleBackColor = true;
            // 
            // studentRB
            // 
            this.studentRB.AutoSize = true;
            this.studentRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentRB.Location = new System.Drawing.Point(26, 125);
            this.studentRB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentRB.Name = "studentRB";
            this.studentRB.Size = new System.Drawing.Size(92, 28);
            this.studentRB.TabIndex = 2;
            this.studentRB.Text = "Student";
            this.studentRB.UseVisualStyleBackColor = true;
            // 
            // childRB
            // 
            this.childRB.AutoSize = true;
            this.childRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childRB.Location = new System.Drawing.Point(26, 84);
            this.childRB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.childRB.Name = "childRB";
            this.childRB.Size = new System.Drawing.Size(181, 28);
            this.childRB.TabIndex = 1;
            this.childRB.Text = "Child (12 && under)";
            this.childRB.UseVisualStyleBackColor = true;
            // 
            // adultRB
            // 
            this.adultRB.AutoSize = true;
            this.adultRB.Checked = true;
            this.adultRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adultRB.Location = new System.Drawing.Point(26, 43);
            this.adultRB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adultRB.Name = "adultRB";
            this.adultRB.Size = new System.Drawing.Size(151, 28);
            this.adultRB.TabIndex = 0;
            this.adultRB.TabStop = true;
            this.adultRB.Text = "Standard Adult";
            this.adultRB.UseVisualStyleBackColor = true;
            // 
            // ClientVisits
            // 
            this.ClientVisits.Controls.Add(this.visitsTB);
            this.ClientVisits.Controls.Add(this.label1);
            this.ClientVisits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientVisits.Location = new System.Drawing.Point(281, 288);
            this.ClientVisits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClientVisits.Name = "ClientVisits";
            this.ClientVisits.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClientVisits.Size = new System.Drawing.Size(259, 218);
            this.ClientVisits.TabIndex = 3;
            this.ClientVisits.TabStop = false;
            this.ClientVisits.Text = "Client Visits";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Client Visits";
            // 
            // totalPriceLbl
            // 
            this.totalPriceLbl.AutoSize = true;
            this.totalPriceLbl.Location = new System.Drawing.Point(170, 526);
            this.totalPriceLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalPriceLbl.Name = "totalPriceLbl";
            this.totalPriceLbl.Size = new System.Drawing.Size(104, 24);
            this.totalPriceLbl.TabIndex = 4;
            this.totalPriceLbl.Text = "Total Price:";
            // 
            // calculateBTN
            // 
            this.calculateBTN.Location = new System.Drawing.Point(35, 570);
            this.calculateBTN.Name = "calculateBTN";
            this.calculateBTN.Size = new System.Drawing.Size(107, 46);
            this.calculateBTN.TabIndex = 6;
            this.calculateBTN.Text = "Calculate";
            this.calculateBTN.UseVisualStyleBackColor = true;
            this.calculateBTN.Click += new System.EventHandler(this.calculateBTN_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.Location = new System.Drawing.Point(213, 570);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(107, 46);
            this.clearBTN.TabIndex = 7;
            this.clearBTN.Text = "Clear";
            this.clearBTN.UseVisualStyleBackColor = true;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(391, 570);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(107, 46);
            this.exitBTN.TabIndex = 8;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // visitsTB
            // 
            this.visitsTB.Location = new System.Drawing.Point(13, 110);
            this.visitsTB.Name = "visitsTB";
            this.visitsTB.Size = new System.Drawing.Size(206, 29);
            this.visitsTB.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 636);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.calculateBTN);
            this.Controls.Add(this.totalPriceLbl);
            this.Controls.Add(this.ClientVisits);
            this.Controls.Add(this.ClientType);
            this.Controls.Add(this.Serives);
            this.Controls.Add(this.Hairdresser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Perfect Cut Hair Salon";
            this.Hairdresser.ResumeLayout(false);
            this.Hairdresser.PerformLayout();
            this.Serives.ResumeLayout(false);
            this.Serives.PerformLayout();
            this.ClientType.ResumeLayout(false);
            this.ClientType.PerformLayout();
            this.ClientVisits.ResumeLayout(false);
            this.ClientVisits.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Hairdresser;
        private System.Windows.Forms.RadioButton lauraRB;
        private System.Windows.Forms.RadioButton sueRB;
        private System.Windows.Forms.RadioButton ronRB;
        private System.Windows.Forms.RadioButton patRB;
        private System.Windows.Forms.RadioButton janeRB;
        private System.Windows.Forms.GroupBox Serives;
        private System.Windows.Forms.CheckBox extentionsCB;
        private System.Windows.Forms.CheckBox highlightsCB;
        private System.Windows.Forms.CheckBox colorCB;
        private System.Windows.Forms.CheckBox cutCB;
        private System.Windows.Forms.GroupBox ClientType;
        private System.Windows.Forms.RadioButton seniorRB;
        private System.Windows.Forms.RadioButton studentRB;
        private System.Windows.Forms.RadioButton childRB;
        private System.Windows.Forms.RadioButton adultRB;
        private System.Windows.Forms.GroupBox ClientVisits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalPriceLbl;
        private System.Windows.Forms.Button calculateBTN;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.TextBox visitsTB;
    }
}

