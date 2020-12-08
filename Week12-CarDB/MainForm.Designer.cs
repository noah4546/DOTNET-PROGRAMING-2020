
namespace Week12_CarDB
{
    partial class MainFrom
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
            this.listCarsBtn = new System.Windows.Forms.Button();
            this.resultLB = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectedVehicleTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mileageTB = new System.Windows.Forms.TextBox();
            this.addCarBtn = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listCarsBtn
            // 
            this.listCarsBtn.Location = new System.Drawing.Point(12, 12);
            this.listCarsBtn.Name = "listCarsBtn";
            this.listCarsBtn.Size = new System.Drawing.Size(148, 40);
            this.listCarsBtn.TabIndex = 0;
            this.listCarsBtn.Text = "Get List of Cars";
            this.listCarsBtn.UseVisualStyleBackColor = true;
            this.listCarsBtn.Click += new System.EventHandler(this.listCarsBtn_Click);
            // 
            // resultLB
            // 
            this.resultLB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLB.FormattingEnabled = true;
            this.resultLB.ItemHeight = 18;
            this.resultLB.Location = new System.Drawing.Point(12, 58);
            this.resultLB.Name = "resultLB";
            this.resultLB.Size = new System.Drawing.Size(574, 490);
            this.resultLB.TabIndex = 1;
            this.resultLB.SelectedIndexChanged += new System.EventHandler(this.resultLB_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 573);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1064, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLbl
            // 
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(23, 17);
            this.statusLbl.Text = "OK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selected Vehicle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Average Mileage:";
            // 
            // selectedVehicleTB
            // 
            this.selectedVehicleTB.Location = new System.Drawing.Point(730, 58);
            this.selectedVehicleTB.Name = "selectedVehicleTB";
            this.selectedVehicleTB.ReadOnly = true;
            this.selectedVehicleTB.Size = new System.Drawing.Size(259, 26);
            this.selectedVehicleTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(852, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "L/100 km";
            // 
            // mileageTB
            // 
            this.mileageTB.Location = new System.Drawing.Point(730, 98);
            this.mileageTB.Name = "mileageTB";
            this.mileageTB.ReadOnly = true;
            this.mileageTB.Size = new System.Drawing.Size(116, 26);
            this.mileageTB.TabIndex = 7;
            // 
            // addCarBtn
            // 
            this.addCarBtn.Location = new System.Drawing.Point(597, 179);
            this.addCarBtn.Name = "addCarBtn";
            this.addCarBtn.Size = new System.Drawing.Size(90, 40);
            this.addCarBtn.TabIndex = 8;
            this.addCarBtn.Text = "Add Car";
            this.addCarBtn.UseVisualStyleBackColor = true;
            this.addCarBtn.Click += new System.EventHandler(this.addCarBtn_Click);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 595);
            this.Controls.Add(this.addCarBtn);
            this.Controls.Add(this.mileageTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectedVehicleTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.resultLB);
            this.Controls.Add(this.listCarsBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainFrom";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainFrom_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listCarsBtn;
        private System.Windows.Forms.ListBox resultLB;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox selectedVehicleTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mileageTB;
        private System.Windows.Forms.Button addCarBtn;
    }
}

