namespace Week9_Events
{
    partial class Events
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
            this.pubTB = new System.Windows.Forms.TextBox();
            this.subTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addPubBtn = new System.Windows.Forms.Button();
            this.addSubBtn = new System.Windows.Forms.Button();
            this.pubCLB = new System.Windows.Forms.CheckedListBox();
            this.subLB = new System.Windows.Forms.ListBox();
            this.newBtn = new System.Windows.Forms.Button();
            this.subBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Publisher:";
            // 
            // pubTB
            // 
            this.pubTB.Location = new System.Drawing.Point(128, 19);
            this.pubTB.Name = "pubTB";
            this.pubTB.Size = new System.Drawing.Size(158, 29);
            this.pubTB.TabIndex = 1;
            // 
            // subTB
            // 
            this.subTB.Location = new System.Drawing.Point(582, 19);
            this.subTB.Name = "subTB";
            this.subTB.Size = new System.Drawing.Size(158, 29);
            this.subTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subscriber:";
            // 
            // addPubBtn
            // 
            this.addPubBtn.Location = new System.Drawing.Point(320, 19);
            this.addPubBtn.Name = "addPubBtn";
            this.addPubBtn.Size = new System.Drawing.Size(88, 29);
            this.addPubBtn.TabIndex = 4;
            this.addPubBtn.Text = "Add";
            this.addPubBtn.UseVisualStyleBackColor = true;
            this.addPubBtn.Click += new System.EventHandler(this.addPubBtn_Click);
            // 
            // addSubBtn
            // 
            this.addSubBtn.Location = new System.Drawing.Point(769, 19);
            this.addSubBtn.Name = "addSubBtn";
            this.addSubBtn.Size = new System.Drawing.Size(88, 29);
            this.addSubBtn.TabIndex = 5;
            this.addSubBtn.Text = "Add";
            this.addSubBtn.UseVisualStyleBackColor = true;
            this.addSubBtn.Click += new System.EventHandler(this.addSubBtn_Click);
            // 
            // pubCLB
            // 
            this.pubCLB.FormattingEnabled = true;
            this.pubCLB.Location = new System.Drawing.Point(29, 63);
            this.pubCLB.Name = "pubCLB";
            this.pubCLB.Size = new System.Drawing.Size(410, 292);
            this.pubCLB.TabIndex = 6;
            // 
            // subLB
            // 
            this.subLB.FormattingEnabled = true;
            this.subLB.ItemHeight = 24;
            this.subLB.Location = new System.Drawing.Point(469, 63);
            this.subLB.Name = "subLB";
            this.subLB.Size = new System.Drawing.Size(415, 292);
            this.subLB.TabIndex = 7;
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(167, 361);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(128, 42);
            this.newBtn.TabIndex = 8;
            this.newBtn.Text = "New Issue";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // subBtn
            // 
            this.subBtn.Location = new System.Drawing.Point(612, 361);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(128, 42);
            this.subBtn.TabIndex = 9;
            this.subBtn.Text = "Subscribe";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 424);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.subLB);
            this.Controls.Add(this.pubCLB);
            this.Controls.Add(this.addSubBtn);
            this.Controls.Add(this.addPubBtn);
            this.Controls.Add(this.subTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pubTB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimizeBox = false;
            this.Name = "Events";
            this.Text = "Events";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pubTB;
        private System.Windows.Forms.TextBox subTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addPubBtn;
        private System.Windows.Forms.Button addSubBtn;
        private System.Windows.Forms.CheckedListBox pubCLB;
        private System.Windows.Forms.ListBox subLB;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button subBtn;
    }
}

