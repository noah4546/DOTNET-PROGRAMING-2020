namespace Week10_Lambda
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
            this.studentsLB = new System.Windows.Forms.ListBox();
            this.sortLastNameBtn = new System.Windows.Forms.Button();
            this.sortGrade1Btn = new System.Windows.Forms.Button();
            this.sortGrade2Btn = new System.Windows.Forms.Button();
            this.sortGrade1then2Btn = new System.Windows.Forms.Button();
            this.sortAvgBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentsLB
            // 
            this.studentsLB.FormattingEnabled = true;
            this.studentsLB.ItemHeight = 20;
            this.studentsLB.Location = new System.Drawing.Point(12, 12);
            this.studentsLB.Margin = new System.Windows.Forms.Padding(5);
            this.studentsLB.Name = "studentsLB";
            this.studentsLB.Size = new System.Drawing.Size(704, 304);
            this.studentsLB.TabIndex = 0;
            // 
            // sortLastNameBtn
            // 
            this.sortLastNameBtn.Location = new System.Drawing.Point(12, 324);
            this.sortLastNameBtn.Name = "sortLastNameBtn";
            this.sortLastNameBtn.Size = new System.Drawing.Size(96, 53);
            this.sortLastNameBtn.TabIndex = 1;
            this.sortLastNameBtn.Text = "Sort by Last Name";
            this.sortLastNameBtn.UseVisualStyleBackColor = true;
            this.sortLastNameBtn.Click += new System.EventHandler(this.sortLastNameBtn_Click);
            // 
            // sortGrade1Btn
            // 
            this.sortGrade1Btn.Location = new System.Drawing.Point(152, 324);
            this.sortGrade1Btn.Name = "sortGrade1Btn";
            this.sortGrade1Btn.Size = new System.Drawing.Size(96, 53);
            this.sortGrade1Btn.TabIndex = 2;
            this.sortGrade1Btn.Text = "Sort by Grade 1";
            this.sortGrade1Btn.UseVisualStyleBackColor = true;
            this.sortGrade1Btn.Click += new System.EventHandler(this.sortGrade1Btn_Click);
            // 
            // sortGrade2Btn
            // 
            this.sortGrade2Btn.Location = new System.Drawing.Point(292, 324);
            this.sortGrade2Btn.Name = "sortGrade2Btn";
            this.sortGrade2Btn.Size = new System.Drawing.Size(96, 53);
            this.sortGrade2Btn.TabIndex = 3;
            this.sortGrade2Btn.Text = "Sort by Grade 2";
            this.sortGrade2Btn.UseVisualStyleBackColor = true;
            this.sortGrade2Btn.Click += new System.EventHandler(this.sortGrade2Btn_Click);
            // 
            // sortGrade1then2Btn
            // 
            this.sortGrade1then2Btn.Location = new System.Drawing.Point(572, 324);
            this.sortGrade1then2Btn.Name = "sortGrade1then2Btn";
            this.sortGrade1then2Btn.Size = new System.Drawing.Size(141, 53);
            this.sortGrade1then2Btn.TabIndex = 4;
            this.sortGrade1then2Btn.Text = "Sort by Grade 1 then Grade 2";
            this.sortGrade1then2Btn.UseVisualStyleBackColor = true;
            this.sortGrade1then2Btn.Click += new System.EventHandler(this.sortGrade1then2Btn_Click);
            // 
            // sortAvgBtn
            // 
            this.sortAvgBtn.Location = new System.Drawing.Point(432, 324);
            this.sortAvgBtn.Name = "sortAvgBtn";
            this.sortAvgBtn.Size = new System.Drawing.Size(96, 53);
            this.sortAvgBtn.TabIndex = 5;
            this.sortAvgBtn.Text = "Sort by Average";
            this.sortAvgBtn.UseVisualStyleBackColor = true;
            this.sortAvgBtn.Click += new System.EventHandler(this.sortAvgBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 394);
            this.Controls.Add(this.sortAvgBtn);
            this.Controls.Add(this.sortGrade1then2Btn);
            this.Controls.Add(this.sortGrade2Btn);
            this.Controls.Add(this.sortGrade1Btn);
            this.Controls.Add(this.sortLastNameBtn);
            this.Controls.Add(this.studentsLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox studentsLB;
        private System.Windows.Forms.Button sortLastNameBtn;
        private System.Windows.Forms.Button sortGrade1Btn;
        private System.Windows.Forms.Button sortGrade2Btn;
        private System.Windows.Forms.Button sortGrade1then2Btn;
        private System.Windows.Forms.Button sortAvgBtn;
    }
}

