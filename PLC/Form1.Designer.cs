
namespace PLC
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtIP = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAnasayfa = new FontAwesome.Sharp.IconButton();
            this.btnCikis = new FontAwesome.Sharp.IconButton();
            this.btnYazma = new FontAwesome.Sharp.IconButton();
            this.ayarlarBtn = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizeBtn = new FontAwesome.Sharp.IconButton();
            this.maximizeBtn = new FontAwesome.Sharp.IconButton();
            this.closeBtn = new FontAwesome.Sharp.IconButton();
            this.headerLBL = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.loadBg = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIP.BackColor = System.Drawing.Color.Silver;
            this.txtIP.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIP.Location = new System.Drawing.Point(3, 602);
            this.txtIP.Name = "txtIP";
            this.txtIP.ReadOnly = true;
            this.txtIP.Size = new System.Drawing.Size(277, 56);
            this.txtIP.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(-1148, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.btnAnasayfa);
            this.panelMenu.Controls.Add(this.btnCikis);
            this.panelMenu.Controls.Add(this.btnYazma);
            this.panelMenu.Controls.Add(this.ayarlarBtn);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.txtIP);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(286, 739);
            this.panelMenu.TabIndex = 7;
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.FlatAppearance.BorderSize = 0;
            this.btnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnasayfa.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnasayfa.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAnasayfa.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnAnasayfa.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnAnasayfa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnasayfa.Location = new System.Drawing.Point(3, 71);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(277, 80);
            this.btnAnasayfa.TabIndex = 17;
            this.btnAnasayfa.Text = "ANASAYFA";
            this.btnAnasayfa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnasayfa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            this.btnAnasayfa.MouseEnter += new System.EventHandler(this.btnAnasayfa_MouseEnter);
            this.btnAnasayfa.MouseLeave += new System.EventHandler(this.btnAnasayfa_MouseLeave);
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCikis.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCikis.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnCikis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCikis.IconSize = 40;
            this.btnCikis.Location = new System.Drawing.Point(3, 662);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(277, 72);
            this.btnCikis.TabIndex = 15;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            this.btnCikis.MouseEnter += new System.EventHandler(this.btnCikis_MouseEnter);
            this.btnCikis.MouseLeave += new System.EventHandler(this.btnCikis_MouseLeave);
            // 
            // btnYazma
            // 
            this.btnYazma.Enabled = false;
            this.btnYazma.FlatAppearance.BorderSize = 0;
            this.btnYazma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazma.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnYazma.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnYazma.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnYazma.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnYazma.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnYazma.IconSize = 40;
            this.btnYazma.Location = new System.Drawing.Point(3, 231);
            this.btnYazma.Name = "btnYazma";
            this.btnYazma.Size = new System.Drawing.Size(277, 80);
            this.btnYazma.TabIndex = 16;
            this.btnYazma.Text = " YAZMA";
            this.btnYazma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYazma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYazma.UseVisualStyleBackColor = true;
            this.btnYazma.Click += new System.EventHandler(this.btnYazma_Click);
            this.btnYazma.MouseEnter += new System.EventHandler(this.btnYazma_MouseEnter);
            this.btnYazma.MouseLeave += new System.EventHandler(this.btnYazma_MouseLeave);
            // 
            // ayarlarBtn
            // 
            this.ayarlarBtn.FlatAppearance.BorderSize = 0;
            this.ayarlarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ayarlarBtn.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ayarlarBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ayarlarBtn.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.ayarlarBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ayarlarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ayarlarBtn.Location = new System.Drawing.Point(3, 151);
            this.ayarlarBtn.Name = "ayarlarBtn";
            this.ayarlarBtn.Size = new System.Drawing.Size(277, 80);
            this.ayarlarBtn.TabIndex = 14;
            this.ayarlarBtn.Text = "AYARLAR";
            this.ayarlarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ayarlarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ayarlarBtn.UseVisualStyleBackColor = true;
            this.ayarlarBtn.Click += new System.EventHandler(this.btnAyarlar_Click);
            this.ayarlarBtn.MouseEnter += new System.EventHandler(this.btnAyarlar_MouseEnter);
            this.ayarlarBtn.MouseLeave += new System.EventHandler(this.btnAyarlar_MouseLeave);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.pictureLogo);
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(286, 65);
            this.panelLogo.TabIndex = 8;
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pictureLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(286, 65);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            this.pictureLogo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureLogo_MouseDoubleClick);
            this.pictureLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureLogo_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.minimizeBtn);
            this.panel1.Controls.Add(this.maximizeBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.headerLBL);
            this.panel1.Location = new System.Drawing.Point(286, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 65);
            this.panel1.TabIndex = 8;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minimizeBtn.ForeColor = System.Drawing.Color.DimGray;
            this.minimizeBtn.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.minimizeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(78)))));
            this.minimizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimizeBtn.IconSize = 24;
            this.minimizeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.minimizeBtn.Location = new System.Drawing.Point(898, 3);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.minimizeBtn.Size = new System.Drawing.Size(30, 30);
            this.minimizeBtn.TabIndex = 19;
            this.minimizeBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimizeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // maximizeBtn
            // 
            this.maximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.maximizeBtn.FlatAppearance.BorderSize = 0;
            this.maximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.maximizeBtn.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.maximizeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(69)))));
            this.maximizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.maximizeBtn.IconSize = 24;
            this.maximizeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.maximizeBtn.Location = new System.Drawing.Point(928, 3);
            this.maximizeBtn.Name = "maximizeBtn";
            this.maximizeBtn.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.maximizeBtn.Size = new System.Drawing.Size(30, 30);
            this.maximizeBtn.TabIndex = 18;
            this.maximizeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.maximizeBtn.UseVisualStyleBackColor = false;
            this.maximizeBtn.Click += new System.EventHandler(this.maximizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.closeBtn.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.closeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(92)))));
            this.closeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeBtn.IconSize = 24;
            this.closeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeBtn.Location = new System.Drawing.Point(958, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.closeBtn.Size = new System.Drawing.Size(30, 30);
            this.closeBtn.TabIndex = 17;
            this.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // headerLBL
            // 
            this.headerLBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.headerLBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerLBL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLBL.Font = new System.Drawing.Font("Segoe UI Variable Small", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLBL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.headerLBL.Location = new System.Drawing.Point(0, 0);
            this.headerLBL.Margin = new System.Windows.Forms.Padding(0);
            this.headerLBL.Name = "headerLBL";
            this.headerLBL.Size = new System.Drawing.Size(991, 65);
            this.headerLBL.TabIndex = 0;
            this.headerLBL.Text = "ANASAYFA";
            this.headerLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.headerLBL.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.headerLBL_MouseDoubleClick);
            this.headerLBL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerLBL_MouseDown);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 100);
            this.label7.TabIndex = 5;
            this.label7.Text = "Değer:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(69, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(262, 156);
            this.label8.TabIndex = 6;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contentPanel
            // 
            this.contentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.contentPanel.Location = new System.Drawing.Point(286, 65);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(991, 674);
            this.contentPanel.TabIndex = 9;
            // 
            // loadBg
            // 
            this.loadBg.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loadBg_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1277, 739);
            this.ControlBox = false;
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1277, 739);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnYazma;
        private FontAwesome.Sharp.IconButton btnCikis;
        private FontAwesome.Sharp.IconButton ayarlarBtn;
        private System.Windows.Forms.Label headerLBL;
        private FontAwesome.Sharp.IconButton closeBtn;
        private FontAwesome.Sharp.IconButton minimizeBtn;
        private FontAwesome.Sharp.IconButton maximizeBtn;
        private System.Windows.Forms.Panel contentPanel;
        private FontAwesome.Sharp.IconButton btnAnasayfa;
        private System.ComponentModel.BackgroundWorker loadBg;
    }
}

