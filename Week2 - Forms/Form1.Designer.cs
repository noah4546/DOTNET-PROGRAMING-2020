namespace Week2___Forms
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
            this.listAllCarsBTN = new System.Windows.Forms.Button();
            this.carBestMileageBTN = new System.Windows.Forms.Button();
            this.carsByFordBTN = new System.Windows.Forms.Button();
            this.openCars = new System.Windows.Forms.OpenFileDialog();
            this.openFile = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listAllCarsBTN
            // 
            this.listAllCarsBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAllCarsBTN.Location = new System.Drawing.Point(36, 12);
            this.listAllCarsBTN.Name = "listAllCarsBTN";
            this.listAllCarsBTN.Size = new System.Drawing.Size(242, 40);
            this.listAllCarsBTN.TabIndex = 0;
            this.listAllCarsBTN.Text = "List All Cars";
            this.listAllCarsBTN.UseVisualStyleBackColor = true;
            this.listAllCarsBTN.Click += new System.EventHandler(this.listAllCarsBTN_Click);
            // 
            // carBestMileageBTN
            // 
            this.carBestMileageBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carBestMileageBTN.Location = new System.Drawing.Point(36, 58);
            this.carBestMileageBTN.Name = "carBestMileageBTN";
            this.carBestMileageBTN.Size = new System.Drawing.Size(242, 40);
            this.carBestMileageBTN.TabIndex = 1;
            this.carBestMileageBTN.Text = "Car With Best Mileage";
            this.carBestMileageBTN.UseVisualStyleBackColor = true;
            // 
            // carsByFordBTN
            // 
            this.carsByFordBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carsByFordBTN.Location = new System.Drawing.Point(36, 104);
            this.carsByFordBTN.Name = "carsByFordBTN";
            this.carsByFordBTN.Size = new System.Drawing.Size(242, 40);
            this.carsByFordBTN.TabIndex = 2;
            this.carsByFordBTN.Text = "Cars Built by Ford";
            this.carsByFordBTN.UseVisualStyleBackColor = true;
            // 
            // openCars
            // 
            this.openCars.DefaultExt = "csv";
            this.openCars.FileName = "cars.csv";
            this.openCars.Filter = "CSV Files | *.csv";
            // 
            // openFile
            // 
            this.openFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFile.Location = new System.Drawing.Point(36, 532);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(133, 27);
            this.openFile.TabIndex = 3;
            this.openFile.Text = "Open File";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 164);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(506, 352);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 581);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.carsByFordBTN);
            this.Controls.Add(this.carBestMileageBTN);
            this.Controls.Add(this.listAllCarsBTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Week 2 - Forms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listAllCarsBTN;
        private System.Windows.Forms.Button carBestMileageBTN;
        private System.Windows.Forms.Button carsByFordBTN;
        private System.Windows.Forms.OpenFileDialog openCars;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.TextBox textBox1;
    }
}

