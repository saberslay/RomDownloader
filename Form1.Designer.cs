namespace TowerUnite_Rom_Downloader
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
            this.ConsolesCLB = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HandheldsCBL = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DownloadAllRomsCD = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ConsolesCLB
            // 
            this.ConsolesCLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsolesCLB.FormattingEnabled = true;
            this.ConsolesCLB.Items.AddRange(new object[] {
            "Nintendo",
            "Master System",
            "Genesis",
            "Super Nintendo",
            "Saturn",
            "PlayStation",
            "Nintendo 64",
            "Dreamcast",
            "PlayStation 2",
            "Xbox",
            "GameCube",
            "Xbox 360",
            "PlayStation 3",
            "Wii",
            "WiiWare"});
            this.ConsolesCLB.Location = new System.Drawing.Point(12, 25);
            this.ConsolesCLB.Name = "ConsolesCLB";
            this.ConsolesCLB.Size = new System.Drawing.Size(166, 79);
            this.ConsolesCLB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consoles";
            // 
            // HandheldsCBL
            // 
            this.HandheldsCBL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HandheldsCBL.FormattingEnabled = true;
            this.HandheldsCBL.Items.AddRange(new object[] {
            "Virtual Boy",
            "Game Boy",
            "Nintendo DS",
            "PlayStation Portable"});
            this.HandheldsCBL.Location = new System.Drawing.Point(184, 25);
            this.HandheldsCBL.Name = "HandheldsCBL";
            this.HandheldsCBL.Size = new System.Drawing.Size(164, 79);
            this.HandheldsCBL.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Handhelds";
            // 
            // DownloadAllRomsCD
            // 
            this.DownloadAllRomsCD.AutoSize = true;
            this.DownloadAllRomsCD.Location = new System.Drawing.Point(9, 110);
            this.DownloadAllRomsCD.Name = "DownloadAllRomsCD";
            this.DownloadAllRomsCD.Size = new System.Drawing.Size(339, 17);
            this.DownloadAllRomsCD.TabIndex = 4;
            this.DownloadAllRomsCD.Text = "Download all Roms (Warning this will take some time to Download)";
            this.DownloadAllRomsCD.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(360, 138);
            this.Controls.Add(this.DownloadAllRomsCD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HandheldsCBL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConsolesCLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ConsolesCLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox HandheldsCBL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox DownloadAllRomsCD;
    }
}

