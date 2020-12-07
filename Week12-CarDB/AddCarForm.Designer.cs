
namespace Week12_CarDB
{
    partial class AddCarForm
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
            this.makeTB = new System.Windows.Forms.TextBox();
            this.yearNUD = new System.Windows.Forms.NumericUpDown();
            this.modelTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yearNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make:";
            // 
            // makeTB
            // 
            this.makeTB.Location = new System.Drawing.Point(85, 23);
            this.makeTB.Name = "makeTB";
            this.makeTB.Size = new System.Drawing.Size(120, 26);
            this.makeTB.TabIndex = 1;
            // 
            // yearNUD
            // 
            this.yearNUD.Location = new System.Drawing.Point(85, 109);
            this.yearNUD.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.yearNUD.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.yearNUD.Name = "yearNUD";
            this.yearNUD.Size = new System.Drawing.Size(120, 26);
            this.yearNUD.TabIndex = 2;
            this.yearNUD.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // modelTB
            // 
            this.modelTB.Location = new System.Drawing.Point(85, 66);
            this.modelTB.Name = "modelTB";
            this.modelTB.Size = new System.Drawing.Size(120, 26);
            this.modelTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year:";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(27, 152);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(79, 31);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add Car";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(126, 152);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(79, 31);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 200);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modelTB);
            this.Controls.Add(this.yearNUD);
            this.Controls.Add(this.makeTB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddCarForm";
            this.Text = "AddCarForm";
            ((System.ComponentModel.ISupportInitialize)(this.yearNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox makeTB;
        private System.Windows.Forms.NumericUpDown yearNUD;
        private System.Windows.Forms.TextBox modelTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}