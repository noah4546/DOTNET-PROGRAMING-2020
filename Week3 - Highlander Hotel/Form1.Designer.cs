namespace Week3___Highlander_Hotel
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
            this.roomInfoGB = new System.Windows.Forms.GroupBox();
            this.nightsLabel = new System.Windows.Forms.Label();
            this.nightsNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nightlyChargeNUD = new System.Windows.Forms.NumericUpDown();
            this.additonalChargesGB = new System.Windows.Forms.GroupBox();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.roomServiceLabel = new System.Windows.Forms.Label();
            this.miscLabel = new System.Windows.Forms.Label();
            this.telephoneTB = new System.Windows.Forms.MaskedTextBox();
            this.roomServiceNUD = new System.Windows.Forms.NumericUpDown();
            this.miscNUD = new System.Windows.Forms.NumericUpDown();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roomInfoGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nightsNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nightlyChargeNUD)).BeginInit();
            this.additonalChargesGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomServiceNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miscNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // roomInfoGB
            // 
            this.roomInfoGB.Controls.Add(this.nightlyChargeNUD);
            this.roomInfoGB.Controls.Add(this.label1);
            this.roomInfoGB.Controls.Add(this.nightsNUD);
            this.roomInfoGB.Controls.Add(this.nightsLabel);
            this.roomInfoGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomInfoGB.Location = new System.Drawing.Point(23, 166);
            this.roomInfoGB.Name = "roomInfoGB";
            this.roomInfoGB.Size = new System.Drawing.Size(334, 163);
            this.roomInfoGB.TabIndex = 0;
            this.roomInfoGB.TabStop = false;
            this.roomInfoGB.Text = "Room Infromation";
            // 
            // nightsLabel
            // 
            this.nightsLabel.AutoSize = true;
            this.nightsLabel.Location = new System.Drawing.Point(107, 51);
            this.nightsLabel.Name = "nightsLabel";
            this.nightsLabel.Size = new System.Drawing.Size(68, 24);
            this.nightsLabel.TabIndex = 0;
            this.nightsLabel.Text = "Nights:";
            // 
            // nightsNUD
            // 
            this.nightsNUD.Location = new System.Drawing.Point(190, 49);
            this.nightsNUD.Name = "nightsNUD";
            this.nightsNUD.Size = new System.Drawing.Size(120, 29);
            this.nightsNUD.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nightly Charges:";
            // 
            // nightlyChargeNUD
            // 
            this.nightlyChargeNUD.Location = new System.Drawing.Point(190, 93);
            this.nightlyChargeNUD.Name = "nightlyChargeNUD";
            this.nightlyChargeNUD.Size = new System.Drawing.Size(120, 29);
            this.nightlyChargeNUD.TabIndex = 3;
            // 
            // additonalChargesGB
            // 
            this.additonalChargesGB.Controls.Add(this.miscNUD);
            this.additonalChargesGB.Controls.Add(this.roomServiceNUD);
            this.additonalChargesGB.Controls.Add(this.telephoneTB);
            this.additonalChargesGB.Controls.Add(this.miscLabel);
            this.additonalChargesGB.Controls.Add(this.telephoneLabel);
            this.additonalChargesGB.Controls.Add(this.roomServiceLabel);
            this.additonalChargesGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additonalChargesGB.Location = new System.Drawing.Point(378, 166);
            this.additonalChargesGB.Name = "additonalChargesGB";
            this.additonalChargesGB.Size = new System.Drawing.Size(340, 163);
            this.additonalChargesGB.TabIndex = 1;
            this.additonalChargesGB.TabStop = false;
            this.additonalChargesGB.Text = "Aditional Charges";
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Location = new System.Drawing.Point(69, 81);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(108, 24);
            this.telephoneLabel.TabIndex = 2;
            this.telephoneLabel.Text = "Telephone:";
            // 
            // roomServiceLabel
            // 
            this.roomServiceLabel.AutoSize = true;
            this.roomServiceLabel.Location = new System.Drawing.Point(49, 39);
            this.roomServiceLabel.Name = "roomServiceLabel";
            this.roomServiceLabel.Size = new System.Drawing.Size(128, 24);
            this.roomServiceLabel.TabIndex = 0;
            this.roomServiceLabel.Text = "Room Sevice:";
            // 
            // miscLabel
            // 
            this.miscLabel.AutoSize = true;
            this.miscLabel.Location = new System.Drawing.Point(123, 122);
            this.miscLabel.Name = "miscLabel";
            this.miscLabel.Size = new System.Drawing.Size(54, 24);
            this.miscLabel.TabIndex = 3;
            this.miscLabel.Text = "Misc:";
            // 
            // telephoneTB
            // 
            this.telephoneTB.Location = new System.Drawing.Point(183, 78);
            this.telephoneTB.Mask = "(999) 000-0000";
            this.telephoneTB.Name = "telephoneTB";
            this.telephoneTB.Size = new System.Drawing.Size(139, 29);
            this.telephoneTB.TabIndex = 4;
            // 
            // roomServiceNUD
            // 
            this.roomServiceNUD.Location = new System.Drawing.Point(183, 37);
            this.roomServiceNUD.Name = "roomServiceNUD";
            this.roomServiceNUD.Size = new System.Drawing.Size(139, 29);
            this.roomServiceNUD.TabIndex = 5;
            // 
            // miscNUD
            // 
            this.miscNUD.Location = new System.Drawing.Point(183, 120);
            this.miscNUD.Name = "miscNUD";
            this.miscNUD.Size = new System.Drawing.Size(139, 29);
            this.miscNUD.TabIndex = 6;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(262, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(194, 29);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Highlander Hotel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Today\'s Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(497, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 590);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.additonalChargesGB);
            this.Controls.Add(this.roomInfoGB);
            this.Name = "Form1";
            this.Text = "Highlander Hotel";
            this.roomInfoGB.ResumeLayout(false);
            this.roomInfoGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nightsNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nightlyChargeNUD)).EndInit();
            this.additonalChargesGB.ResumeLayout(false);
            this.additonalChargesGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomServiceNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miscNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox roomInfoGB;
        private System.Windows.Forms.NumericUpDown nightlyChargeNUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nightsNUD;
        private System.Windows.Forms.Label nightsLabel;
        private System.Windows.Forms.GroupBox additonalChargesGB;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.Label roomServiceLabel;
        private System.Windows.Forms.NumericUpDown miscNUD;
        private System.Windows.Forms.NumericUpDown roomServiceNUD;
        private System.Windows.Forms.MaskedTextBox telephoneTB;
        private System.Windows.Forms.Label miscLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

