namespace ECG_Doctor_System
{
    partial class Medical_Display
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CPRTB = new System.Windows.Forms.TextBox();
            this.DateLB = new System.Windows.Forms.ListBox();
            this.SearchB = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.AdressTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPR-nummer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(28, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dato for måling:";
            // 
            // CPRTB
            // 
            this.CPRTB.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CPRTB.Location = new System.Drawing.Point(232, 22);
            this.CPRTB.Name = "CPRTB";
            this.CPRTB.Size = new System.Drawing.Size(284, 34);
            this.CPRTB.TabIndex = 2;
            // 
            // DateLB
            // 
            this.DateLB.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateLB.FormattingEnabled = true;
            this.DateLB.ItemHeight = 27;
            this.DateLB.Location = new System.Drawing.Point(232, 97);
            this.DateLB.Name = "DateLB";
            this.DateLB.Size = new System.Drawing.Size(284, 112);
            this.DateLB.TabIndex = 3;
            // 
            // SearchB
            // 
            this.SearchB.BackColor = System.Drawing.Color.Green;
            this.SearchB.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchB.Location = new System.Drawing.Point(558, 22);
            this.SearchB.Name = "SearchB";
            this.SearchB.Size = new System.Drawing.Size(133, 39);
            this.SearchB.TabIndex = 4;
            this.SearchB.Text = "Søg";
            this.SearchB.UseVisualStyleBackColor = false;
            // 
            // Show
            // 
            this.Show.BackColor = System.Drawing.Color.Green;
            this.Show.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Show.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Show.Location = new System.Drawing.Point(558, 97);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(133, 61);
            this.Show.TabIndex = 5;
            this.Show.Text = "Vis måling";
            this.Show.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(763, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Navn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(763, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adresse:";
            // 
            // NameTB
            // 
            this.NameTB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NameTB.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameTB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameTB.Location = new System.Drawing.Point(891, 20);
            this.NameTB.Multiline = true;
            this.NameTB.Name = "NameTB";
            this.NameTB.ReadOnly = true;
            this.NameTB.Size = new System.Drawing.Size(225, 46);
            this.NameTB.TabIndex = 8;
            // 
            // AdressTB
            // 
            this.AdressTB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AdressTB.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdressTB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AdressTB.Location = new System.Drawing.Point(891, 72);
            this.AdressTB.Multiline = true;
            this.AdressTB.Name = "AdressTB";
            this.AdressTB.ReadOnly = true;
            this.AdressTB.Size = new System.Drawing.Size(225, 46);
            this.AdressTB.TabIndex = 9;
            // 
            // Medical_Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1185, 687);
            this.Controls.Add(this.AdressTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.SearchB);
            this.Controls.Add(this.DateLB);
            this.Controls.Add(this.CPRTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Medical_Display";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CPRTB;
        private System.Windows.Forms.ListBox DateLB;
        private System.Windows.Forms.Button SearchB;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox AdressTB;
    }
}

