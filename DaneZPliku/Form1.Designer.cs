namespace DaneZPlikuOkienko
{
    partial class DaneZPliku
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
            this.btnWybierzPlikSystemu = new System.Windows.Forms.Button();
            this.tbSciezkaDoSystemuDecyzyjnego = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbSystemDecyzyjny = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCoverI = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbCoverRegulyII = new System.Windows.Forms.TextBox();
            this.tbCoverRegulyI = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWybierzPlikSystemu
            // 
            this.btnWybierzPlikSystemu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWybierzPlikSystemu.Location = new System.Drawing.Point(677, 10);
            this.btnWybierzPlikSystemu.Margin = new System.Windows.Forms.Padding(2);
            this.btnWybierzPlikSystemu.Name = "btnWybierzPlikSystemu";
            this.btnWybierzPlikSystemu.Size = new System.Drawing.Size(32, 19);
            this.btnWybierzPlikSystemu.TabIndex = 0;
            this.btnWybierzPlikSystemu.Text = "...";
            this.btnWybierzPlikSystemu.UseVisualStyleBackColor = true;
            this.btnWybierzPlikSystemu.Click += new System.EventHandler(this.btnWybierzPlik_Click);
            // 
            // tbSciezkaDoSystemuDecyzyjnego
            // 
            this.tbSciezkaDoSystemuDecyzyjnego.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSciezkaDoSystemuDecyzyjnego.Location = new System.Drawing.Point(145, 10);
            this.tbSciezkaDoSystemuDecyzyjnego.Margin = new System.Windows.Forms.Padding(2);
            this.tbSciezkaDoSystemuDecyzyjnego.Name = "tbSciezkaDoSystemuDecyzyjnego";
            this.tbSciezkaDoSystemuDecyzyjnego.ReadOnly = true;
            this.tbSciezkaDoSystemuDecyzyjnego.Size = new System.Drawing.Size(529, 20);
            this.tbSciezkaDoSystemuDecyzyjnego.TabIndex = 1;
            this.tbSciezkaDoSystemuDecyzyjnego.Click += new System.EventHandler(this.btnWybierzPlik_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ścieżka do pliku systemu";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStart.Location = new System.Drawing.Point(12, 391);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 35);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Pracuj";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbSystemDecyzyjny
            // 
            this.tbSystemDecyzyjny.Location = new System.Drawing.Point(6, 19);
            this.tbSystemDecyzyjny.Name = "tbSystemDecyzyjny";
            this.tbSystemDecyzyjny.Size = new System.Drawing.Size(188, 326);
            this.tbSystemDecyzyjny.TabIndex = 10;
            this.tbSystemDecyzyjny.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSystemDecyzyjny);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 351);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System Decyzyjny";
            // 
            // tbCoverI
            // 
            this.tbCoverI.Location = new System.Drawing.Point(6, 19);
            this.tbCoverI.Name = "tbCoverI";
            this.tbCoverI.ReadOnly = true;
            this.tbCoverI.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.tbCoverI.Size = new System.Drawing.Size(212, 120);
            this.tbCoverI.TabIndex = 12;
            this.tbCoverI.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCoverI);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 146);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odrzucone rząd I";
            // 
            // TabControl
            // 
            this.TabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Enabled = false;
            this.TabControl.Location = new System.Drawing.Point(218, 35);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(488, 391);
            this.TabControl.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Honeydew;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(480, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sequential covering";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbCoverRegulyII);
            this.groupBox4.Location = new System.Drawing.Point(6, 158);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(224, 201);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wyniki II rzędu";
            // 
            // tbCoverRegulyII
            // 
            this.tbCoverRegulyII.Location = new System.Drawing.Point(6, 19);
            this.tbCoverRegulyII.Multiline = true;
            this.tbCoverRegulyII.Name = "tbCoverRegulyII";
            this.tbCoverRegulyII.ReadOnly = true;
            this.tbCoverRegulyII.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbCoverRegulyII.Size = new System.Drawing.Size(212, 176);
            this.tbCoverRegulyII.TabIndex = 1;
            // 
            // tbCoverRegulyI
            // 
            this.tbCoverRegulyI.Location = new System.Drawing.Point(6, 19);
            this.tbCoverRegulyI.Multiline = true;
            this.tbCoverRegulyI.Name = "tbCoverRegulyI";
            this.tbCoverRegulyI.ReadOnly = true;
            this.tbCoverRegulyI.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbCoverRegulyI.Size = new System.Drawing.Size(226, 325);
            this.tbCoverRegulyI.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(480, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Exhaust";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Snow;
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(480, 362);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "LEM2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbCoverRegulyI);
            this.groupBox3.Location = new System.Drawing.Point(236, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 350);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wyniki I rzędu";
            // 
            // DaneZPliku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 437);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSciezkaDoSystemuDecyzyjnego);
            this.Controls.Add(this.btnWybierzPlikSystemu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(529, 413);
            this.Name = "DaneZPliku";
            this.Text = "System Decyzyjny";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWybierzPlikSystemu;
        private System.Windows.Forms.TextBox tbSciezkaDoSystemuDecyzyjnego;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox tbSystemDecyzyjny;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox tbCoverI;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbCoverRegulyI;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbCoverRegulyII;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

