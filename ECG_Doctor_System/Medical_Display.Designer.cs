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
            this.CPRTB.Location = new System.Drawing.Point(232, 22);
            this.CPRTB.Name = "CPRTB";
            this.CPRTB.Size = new System.Drawing.Size(284, 31);
            this.CPRTB.TabIndex = 2;
            // 
            // DateLB
            // 
            this.DateLB.FormattingEnabled = true;
            this.DateLB.ItemHeight = 25;
            this.DateLB.Location = new System.Drawing.Point(232, 97);
            this.DateLB.Name = "DateLB";
            this.DateLB.Size = new System.Drawing.Size(284, 129);
            this.DateLB.TabIndex = 3;
            // 
            // SearchB
            // 
            this.SearchB.BackColor = System.Drawing.Color.Green;
            this.SearchB.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchB.Location = new System.Drawing.Point(558, 22);
            this.SearchB.Name = "SearchB";
            this.SearchB.Size = new System.Drawing.Size(112, 39);
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
            // Medical_Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(990, 687);
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
    }
}

