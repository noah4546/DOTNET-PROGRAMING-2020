
namespace Lab5B
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.firstEpTB = new System.Windows.Forms.TextBox();
            this.imagePB = new System.Windows.Forms.PictureBox();
            this.startAgeTB = new System.Windows.Forms.TextBox();
            this.seriesTB = new System.Windows.Forms.TextBox();
            this.yearTB = new System.Windows.Forms.TextBox();
            this.playedByTB = new System.Windows.Forms.TextBox();
            this.doctorCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.companionsLB = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.queryLinqRB = new System.Windows.Forms.RadioButton();
            this.querySqlRB = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePB)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(969, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.firstEpTB);
            this.groupBox1.Controls.Add(this.imagePB);
            this.groupBox1.Controls.Add(this.startAgeTB);
            this.groupBox1.Controls.Add(this.seriesTB);
            this.groupBox1.Controls.Add(this.yearTB);
            this.groupBox1.Controls.Add(this.playedByTB);
            this.groupBox1.Controls.Add(this.doctorCB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 358);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "The Doctor";
            // 
            // firstEpTB
            // 
            this.firstEpTB.BackColor = System.Drawing.SystemColors.Window;
            this.firstEpTB.Location = new System.Drawing.Point(27, 323);
            this.firstEpTB.Name = "firstEpTB";
            this.firstEpTB.ReadOnly = true;
            this.firstEpTB.Size = new System.Drawing.Size(343, 26);
            this.firstEpTB.TabIndex = 12;
            this.firstEpTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // imagePB
            // 
            this.imagePB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imagePB.Location = new System.Drawing.Point(210, 112);
            this.imagePB.Name = "imagePB";
            this.imagePB.Size = new System.Drawing.Size(160, 200);
            this.imagePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePB.TabIndex = 11;
            this.imagePB.TabStop = false;
            // 
            // startAgeTB
            // 
            this.startAgeTB.BackColor = System.Drawing.SystemColors.Window;
            this.startAgeTB.Location = new System.Drawing.Point(125, 182);
            this.startAgeTB.Name = "startAgeTB";
            this.startAgeTB.ReadOnly = true;
            this.startAgeTB.Size = new System.Drawing.Size(55, 26);
            this.startAgeTB.TabIndex = 10;
            // 
            // seriesTB
            // 
            this.seriesTB.BackColor = System.Drawing.SystemColors.Window;
            this.seriesTB.Location = new System.Drawing.Point(125, 147);
            this.seriesTB.Name = "seriesTB";
            this.seriesTB.ReadOnly = true;
            this.seriesTB.Size = new System.Drawing.Size(55, 26);
            this.seriesTB.TabIndex = 9;
            // 
            // yearTB
            // 
            this.yearTB.BackColor = System.Drawing.SystemColors.Window;
            this.yearTB.Location = new System.Drawing.Point(125, 112);
            this.yearTB.Name = "yearTB";
            this.yearTB.ReadOnly = true;
            this.yearTB.Size = new System.Drawing.Size(55, 26);
            this.yearTB.TabIndex = 8;
            // 
            // playedByTB
            // 
            this.playedByTB.BackColor = System.Drawing.SystemColors.Window;
            this.playedByTB.Location = new System.Drawing.Point(125, 77);
            this.playedByTB.Name = "playedByTB";
            this.playedByTB.ReadOnly = true;
            this.playedByTB.Size = new System.Drawing.Size(245, 26);
            this.playedByTB.TabIndex = 7;
            // 
            // doctorCB
            // 
            this.doctorCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorCB.FormattingEnabled = true;
            this.doctorCB.Location = new System.Drawing.Point(125, 42);
            this.doctorCB.Name = "doctorCB";
            this.doctorCB.Size = new System.Drawing.Size(245, 28);
            this.doctorCB.TabIndex = 6;
            this.doctorCB.SelectedIndexChanged += new System.EventHandler(this.doctorCB_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "First full episode:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Age at start:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Series:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Played by:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.companionsLB);
            this.groupBox2.Location = new System.Drawing.Point(409, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 358);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Companions and their first episode with this Doctor:";
            // 
            // companionsLB
            // 
            this.companionsLB.FormattingEnabled = true;
            this.companionsLB.ItemHeight = 20;
            this.companionsLB.Location = new System.Drawing.Point(6, 25);
            this.companionsLB.Name = "companionsLB";
            this.companionsLB.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.companionsLB.Size = new System.Drawing.Size(378, 324);
            this.companionsLB.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(805, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 217);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.queryLinqRB);
            this.groupBox3.Controls.Add(this.querySqlRB);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(805, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 119);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Query";
            // 
            // queryLinqRB
            // 
            this.queryLinqRB.AutoSize = true;
            this.queryLinqRB.Location = new System.Drawing.Point(6, 64);
            this.queryLinqRB.Name = "queryLinqRB";
            this.queryLinqRB.Size = new System.Drawing.Size(129, 20);
            this.queryLinqRB.TabIndex = 1;
            this.queryLinqRB.Text = "Solve using LINQ";
            this.queryLinqRB.UseVisualStyleBackColor = true;
            // 
            // querySqlRB
            // 
            this.querySqlRB.AutoSize = true;
            this.querySqlRB.Checked = true;
            this.querySqlRB.Location = new System.Drawing.Point(6, 38);
            this.querySqlRB.Name = "querySqlRB";
            this.querySqlRB.Size = new System.Drawing.Size(125, 20);
            this.querySqlRB.TabIndex = 0;
            this.querySqlRB.TabStop = true;
            this.querySqlRB.Text = "Solve using SQL";
            this.querySqlRB.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 391);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(969, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLbl
            // 
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 413);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Doctor and Compainions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePB)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstEpTB;
        private System.Windows.Forms.PictureBox imagePB;
        private System.Windows.Forms.TextBox startAgeTB;
        private System.Windows.Forms.TextBox seriesTB;
        private System.Windows.Forms.TextBox yearTB;
        private System.Windows.Forms.TextBox playedByTB;
        private System.Windows.Forms.ComboBox doctorCB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox companionsLB;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton queryLinqRB;
        private System.Windows.Forms.RadioButton querySqlRB;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLbl;
    }
}

