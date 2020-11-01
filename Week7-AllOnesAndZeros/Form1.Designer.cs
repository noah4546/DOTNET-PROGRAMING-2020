namespace Week7_AllOnesAndZeros
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
            this.asciiTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generateBtn = new System.Windows.Forms.Button();
            this.clearStringTB = new System.Windows.Forms.TextBox();
            this.encryptStringTB = new System.Windows.Forms.TextBox();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.hashedTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hashSaltTB = new System.Windows.Forms.TextBox();
            this.hashBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // asciiTextBox
            // 
            this.asciiTextBox.Location = new System.Drawing.Point(15, 47);
            this.asciiTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.asciiTextBox.Multiline = true;
            this.asciiTextBox.Name = "asciiTextBox";
            this.asciiTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.asciiTextBox.Size = new System.Drawing.Size(1007, 587);
            this.asciiTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "The ASCII Table";
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(12, 643);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(145, 38);
            this.generateBtn.TabIndex = 2;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // clearStringTB
            // 
            this.clearStringTB.Location = new System.Drawing.Point(12, 687);
            this.clearStringTB.Name = "clearStringTB";
            this.clearStringTB.Size = new System.Drawing.Size(583, 29);
            this.clearStringTB.TabIndex = 3;
            // 
            // encryptStringTB
            // 
            this.encryptStringTB.Location = new System.Drawing.Point(12, 722);
            this.encryptStringTB.Name = "encryptStringTB";
            this.encryptStringTB.ReadOnly = true;
            this.encryptStringTB.Size = new System.Drawing.Size(583, 29);
            this.encryptStringTB.TabIndex = 4;
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(12, 766);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(145, 38);
            this.encryptBtn.TabIndex = 5;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(450, 766);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(145, 38);
            this.decryptBtn.TabIndex = 6;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // hashedTB
            // 
            this.hashedTB.Location = new System.Drawing.Point(218, 825);
            this.hashedTB.Name = "hashedTB";
            this.hashedTB.Size = new System.Drawing.Size(1037, 29);
            this.hashedTB.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 828);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hashed Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 865);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hashed && Salt Value:";
            // 
            // hashSaltTB
            // 
            this.hashSaltTB.Location = new System.Drawing.Point(218, 862);
            this.hashSaltTB.Name = "hashSaltTB";
            this.hashSaltTB.Size = new System.Drawing.Size(1037, 29);
            this.hashSaltTB.TabIndex = 9;
            // 
            // hashBtn
            // 
            this.hashBtn.Location = new System.Drawing.Point(218, 906);
            this.hashBtn.Name = "hashBtn";
            this.hashBtn.Size = new System.Drawing.Size(128, 38);
            this.hashBtn.TabIndex = 11;
            this.hashBtn.Text = "Hash";
            this.hashBtn.UseVisualStyleBackColor = true;
            this.hashBtn.Click += new System.EventHandler(this.hashBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 998);
            this.Controls.Add(this.hashBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hashSaltTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hashedTB);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.encryptStringTB);
            this.Controls.Add(this.clearStringTB);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.asciiTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox asciiTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.TextBox clearStringTB;
        private System.Windows.Forms.TextBox encryptStringTB;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.TextBox hashedTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hashSaltTB;
        private System.Windows.Forms.Button hashBtn;
    }
}

