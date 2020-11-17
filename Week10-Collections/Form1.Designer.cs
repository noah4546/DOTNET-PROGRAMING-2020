namespace Week10_Collections
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
            this.carsLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stackTB = new System.Windows.Forms.TextBox();
            this.listTB = new System.Windows.Forms.TextBox();
            this.queueTB = new System.Windows.Forms.TextBox();
            this.dictTB = new System.Windows.Forms.TextBox();
            this.indexNUD = new System.Windows.Forms.NumericUpDown();
            this.nextBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.findBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.indexNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // carsLB
            // 
            this.carsLB.FormattingEnabled = true;
            this.carsLB.ItemHeight = 24;
            this.carsLB.Location = new System.Drawing.Point(12, 12);
            this.carsLB.Name = "carsLB";
            this.carsLB.Size = new System.Drawing.Size(857, 340);
            this.carsLB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stack<Car>:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Queue<Car>:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Index:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 528);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dictonary<int, Car>:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 582);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "List<Car>:";
            // 
            // stackTB
            // 
            this.stackTB.Location = new System.Drawing.Point(190, 363);
            this.stackTB.Name = "stackTB";
            this.stackTB.ReadOnly = true;
            this.stackTB.Size = new System.Drawing.Size(679, 29);
            this.stackTB.TabIndex = 6;
            // 
            // listTB
            // 
            this.listTB.Location = new System.Drawing.Point(190, 579);
            this.listTB.Name = "listTB";
            this.listTB.ReadOnly = true;
            this.listTB.Size = new System.Drawing.Size(679, 29);
            this.listTB.TabIndex = 7;
            // 
            // queueTB
            // 
            this.queueTB.Location = new System.Drawing.Point(190, 417);
            this.queueTB.Name = "queueTB";
            this.queueTB.ReadOnly = true;
            this.queueTB.Size = new System.Drawing.Size(679, 29);
            this.queueTB.TabIndex = 8;
            // 
            // dictTB
            // 
            this.dictTB.Location = new System.Drawing.Point(190, 525);
            this.dictTB.Name = "dictTB";
            this.dictTB.ReadOnly = true;
            this.dictTB.Size = new System.Drawing.Size(679, 29);
            this.dictTB.TabIndex = 9;
            // 
            // indexNUD
            // 
            this.indexNUD.Location = new System.Drawing.Point(190, 472);
            this.indexNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.indexNUD.Name = "indexNUD";
            this.indexNUD.Size = new System.Drawing.Size(679, 29);
            this.indexNUD.TabIndex = 10;
            this.indexNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(753, 643);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(102, 41);
            this.nextBtn.TabIndex = 11;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.Location = new System.Drawing.Point(514, 643);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(102, 41);
            this.previousBtn.TabIndex = 12;
            this.previousBtn.Text = "Previous";
            this.previousBtn.UseVisualStyleBackColor = true;
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(36, 643);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(102, 41);
            this.loadBtn.TabIndex = 13;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(275, 643);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(102, 41);
            this.findBtn.TabIndex = 14;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 703);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.indexNUD);
            this.Controls.Add(this.dictTB);
            this.Controls.Add(this.queueTB);
            this.Controls.Add(this.listTB);
            this.Controls.Add(this.stackTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carsLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.indexNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox carsLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stackTB;
        private System.Windows.Forms.TextBox listTB;
        private System.Windows.Forms.TextBox queueTB;
        private System.Windows.Forms.TextBox dictTB;
        private System.Windows.Forms.NumericUpDown indexNUD;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button findBtn;
    }
}

