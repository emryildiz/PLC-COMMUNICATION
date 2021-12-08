
namespace PLC
{
    partial class Ayarlar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbDil = new System.Windows.Forms.ComboBox();
            this.btnTumunuSıl = new FontAwesome.Sharp.IconButton();
            this.grpSifre = new System.Windows.Forms.GroupBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.btnSifre = new FontAwesome.Sharp.IconButton();
            this.grpIp = new System.Windows.Forms.GroupBox();
            this.comCpu = new System.Windows.Forms.ComboBox();
            this.lblCpuType = new System.Windows.Forms.Label();
            this.txtSlot = new System.Windows.Forms.TextBox();
            this.lblSlot = new System.Windows.Forms.Label();
            this.txtRack = new System.Windows.Forms.TextBox();
            this.lblRack = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.lblIp = new System.Windows.Forms.Label();
            this.btnIp = new FontAwesome.Sharp.IconButton();
            this.grpSil = new System.Windows.Forms.GroupBox();
            this.cmbSil = new System.Windows.Forms.ComboBox();
            this.lblSil = new System.Windows.Forms.Label();
            this.btnSil = new FontAwesome.Sharp.IconButton();
            this.grpEkle = new System.Windows.Forms.GroupBox();
            this.chkWritable = new System.Windows.Forms.CheckBox();
            this.txtİsim = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblİsim = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.ekleBtn = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.grpSifre.SuspendLayout();
            this.grpIp.SuspendLayout();
            this.grpSil.SuspendLayout();
            this.grpEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.cmbDil);
            this.panel1.Controls.Add(this.btnTumunuSıl);
            this.panel1.Controls.Add(this.grpSifre);
            this.panel1.Controls.Add(this.grpIp);
            this.panel1.Controls.Add(this.grpSil);
            this.panel1.Controls.Add(this.grpEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 727);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmbDil
            // 
            this.cmbDil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDil.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbDil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbDil.FormattingEnabled = true;
            this.cmbDil.ItemHeight = 45;
            this.cmbDil.Items.AddRange(new object[] {
            "Türkçe",
            "English"});
            this.cmbDil.Location = new System.Drawing.Point(534, 549);
            this.cmbDil.Name = "cmbDil";
            this.cmbDil.Size = new System.Drawing.Size(171, 53);
            this.cmbDil.TabIndex = 26;
            this.cmbDil.SelectedIndexChanged += new System.EventHandler(this.cmbDil_SelectedIndexChanged);
            // 
            // btnTumunuSıl
            // 
            this.btnTumunuSıl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnTumunuSıl.FlatAppearance.BorderSize = 2;
            this.btnTumunuSıl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTumunuSıl.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTumunuSıl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnTumunuSıl.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnTumunuSıl.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnTumunuSıl.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTumunuSıl.IconSize = 1;
            this.btnTumunuSıl.Location = new System.Drawing.Point(724, 550);
            this.btnTumunuSıl.Name = "btnTumunuSıl";
            this.btnTumunuSıl.Size = new System.Drawing.Size(178, 53);
            this.btnTumunuSıl.TabIndex = 25;
            this.btnTumunuSıl.Text = "TÜMÜNÜ SİL";
            this.btnTumunuSıl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTumunuSıl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTumunuSıl.UseVisualStyleBackColor = false;
            this.btnTumunuSıl.Click += new System.EventHandler(this.btnTumunuSıl_Click);
            // 
            // grpSifre
            // 
            this.grpSifre.Controls.Add(this.txtSifre);
            this.grpSifre.Controls.Add(this.lblSifre);
            this.grpSifre.Controls.Add(this.btnSifre);
            this.grpSifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.grpSifre.Location = new System.Drawing.Point(534, 296);
            this.grpSifre.Name = "grpSifre";
            this.grpSifre.Size = new System.Drawing.Size(368, 247);
            this.grpSifre.TabIndex = 24;
            this.grpSifre.TabStop = false;
            this.grpSifre.Text = "ŞİFRE DEĞİŞTİR";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(190, 38);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(161, 34);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // lblSifre
            // 
            this.lblSifre.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblSifre.Location = new System.Drawing.Point(15, 31);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(169, 47);
            this.lblSifre.TabIndex = 0;
            this.lblSifre.Text = "ŞİFRE:";
            this.lblSifre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSifre
            // 
            this.btnSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnSifre.FlatAppearance.BorderSize = 2;
            this.btnSifre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifre.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnSifre.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnSifre.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnSifre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSifre.IconSize = 1;
            this.btnSifre.Location = new System.Drawing.Point(190, 181);
            this.btnSifre.Name = "btnSifre";
            this.btnSifre.Size = new System.Drawing.Size(161, 48);
            this.btnSifre.TabIndex = 18;
            this.btnSifre.Text = "DEĞİŞTİR";
            this.btnSifre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSifre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSifre.UseVisualStyleBackColor = false;
            this.btnSifre.Click += new System.EventHandler(this.btnSifre_Click);
            // 
            // grpIp
            // 
            this.grpIp.Controls.Add(this.comCpu);
            this.grpIp.Controls.Add(this.lblCpuType);
            this.grpIp.Controls.Add(this.txtSlot);
            this.grpIp.Controls.Add(this.lblSlot);
            this.grpIp.Controls.Add(this.txtRack);
            this.grpIp.Controls.Add(this.lblRack);
            this.grpIp.Controls.Add(this.txtIp);
            this.grpIp.Controls.Add(this.lblIp);
            this.grpIp.Controls.Add(this.btnIp);
            this.grpIp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpIp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.grpIp.Location = new System.Drawing.Point(98, 296);
            this.grpIp.Name = "grpIp";
            this.grpIp.Size = new System.Drawing.Size(368, 306);
            this.grpIp.TabIndex = 23;
            this.grpIp.TabStop = false;
            this.grpIp.Text = "PLC AYARLARI";
            // 
            // comCpu
            // 
            this.comCpu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comCpu.FormattingEnabled = true;
            this.comCpu.Items.AddRange(new object[] {
            "S7200",
            "S7300",
            "S7300",
            "S7-1200",
            "S7-1400"});
            this.comCpu.Location = new System.Drawing.Point(181, 38);
            this.comCpu.Name = "comCpu";
            this.comCpu.Size = new System.Drawing.Size(133, 36);
            this.comCpu.TabIndex = 24;
            // 
            // lblCpuType
            // 
            this.lblCpuType.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCpuType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblCpuType.Location = new System.Drawing.Point(32, 33);
            this.lblCpuType.Name = "lblCpuType";
            this.lblCpuType.Size = new System.Drawing.Size(131, 47);
            this.lblCpuType.TabIndex = 23;
            this.lblCpuType.Text = "CPU Type:";
            this.lblCpuType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSlot
            // 
            this.txtSlot.Location = new System.Drawing.Point(181, 181);
            this.txtSlot.Name = "txtSlot";
            this.txtSlot.Size = new System.Drawing.Size(133, 34);
            this.txtSlot.TabIndex = 22;
            // 
            // lblSlot
            // 
            this.lblSlot.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSlot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblSlot.Location = new System.Drawing.Point(32, 174);
            this.lblSlot.Name = "lblSlot";
            this.lblSlot.Size = new System.Drawing.Size(131, 47);
            this.lblSlot.TabIndex = 21;
            this.lblSlot.Text = "Slot:";
            this.lblSlot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRack
            // 
            this.txtRack.Location = new System.Drawing.Point(181, 134);
            this.txtRack.Name = "txtRack";
            this.txtRack.Size = new System.Drawing.Size(133, 34);
            this.txtRack.TabIndex = 20;
            // 
            // lblRack
            // 
            this.lblRack.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblRack.Location = new System.Drawing.Point(32, 127);
            this.lblRack.Name = "lblRack";
            this.lblRack.Size = new System.Drawing.Size(131, 47);
            this.lblRack.TabIndex = 19;
            this.lblRack.Text = "Rack:";
            this.lblRack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(181, 87);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(133, 34);
            this.txtIp.TabIndex = 1;
            // 
            // lblIp
            // 
            this.lblIp.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblIp.Location = new System.Drawing.Point(32, 80);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(131, 47);
            this.lblIp.TabIndex = 0;
            this.lblIp.Text = "IP Adresi:";
            this.lblIp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIp
            // 
            this.btnIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnIp.FlatAppearance.BorderSize = 2;
            this.btnIp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIp.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnIp.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnIp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnIp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIp.IconSize = 1;
            this.btnIp.Location = new System.Drawing.Point(181, 244);
            this.btnIp.Name = "btnIp";
            this.btnIp.Size = new System.Drawing.Size(133, 48);
            this.btnIp.TabIndex = 18;
            this.btnIp.Text = "DEĞİŞTİR";
            this.btnIp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIp.UseVisualStyleBackColor = false;
            this.btnIp.Click += new System.EventHandler(this.btnIp_Click);
            // 
            // grpSil
            // 
            this.grpSil.Controls.Add(this.cmbSil);
            this.grpSil.Controls.Add(this.lblSil);
            this.grpSil.Controls.Add(this.btnSil);
            this.grpSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.grpSil.Location = new System.Drawing.Point(534, 26);
            this.grpSil.Name = "grpSil";
            this.grpSil.Size = new System.Drawing.Size(368, 236);
            this.grpSil.TabIndex = 22;
            this.grpSil.TabStop = false;
            this.grpSil.Text = "SİL";
            // 
            // cmbSil
            // 
            this.cmbSil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSil.FormattingEnabled = true;
            this.cmbSil.Location = new System.Drawing.Point(189, 38);
            this.cmbSil.Name = "cmbSil";
            this.cmbSil.Size = new System.Drawing.Size(134, 36);
            this.cmbSil.TabIndex = 19;
            // 
            // lblSil
            // 
            this.lblSil.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblSil.Location = new System.Drawing.Point(15, 31);
            this.lblSil.Name = "lblSil";
            this.lblSil.Size = new System.Drawing.Size(106, 47);
            this.lblSil.TabIndex = 0;
            this.lblSil.Text = "İSİM:";
            this.lblSil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnSil.FlatAppearance.BorderSize = 2;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnSil.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnSil.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnSil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSil.IconSize = 36;
            this.btnSil.Location = new System.Drawing.Point(190, 182);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(134, 48);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "SİL";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // grpEkle
            // 
            this.grpEkle.Controls.Add(this.chkWritable);
            this.grpEkle.Controls.Add(this.txtİsim);
            this.grpEkle.Controls.Add(this.txtAdres);
            this.grpEkle.Controls.Add(this.lblİsim);
            this.grpEkle.Controls.Add(this.lblAdres);
            this.grpEkle.Controls.Add(this.ekleBtn);
            this.grpEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.grpEkle.Location = new System.Drawing.Point(98, 26);
            this.grpEkle.Name = "grpEkle";
            this.grpEkle.Size = new System.Drawing.Size(368, 236);
            this.grpEkle.TabIndex = 21;
            this.grpEkle.TabStop = false;
            this.grpEkle.Text = "EKLE";
            // 
            // chkWritable
            // 
            this.chkWritable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkWritable.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkWritable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.chkWritable.Location = new System.Drawing.Point(6, 132);
            this.chkWritable.Name = "chkWritable";
            this.chkWritable.Size = new System.Drawing.Size(259, 44);
            this.chkWritable.TabIndex = 21;
            this.chkWritable.Text = "YAZILABİLİR:";
            this.chkWritable.UseVisualStyleBackColor = true;
            // 
            // txtİsim
            // 
            this.txtİsim.Location = new System.Drawing.Point(189, 44);
            this.txtİsim.Name = "txtİsim";
            this.txtİsim.Size = new System.Drawing.Size(125, 34);
            this.txtİsim.TabIndex = 1;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(189, 91);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(125, 34);
            this.txtAdres.TabIndex = 20;
            // 
            // lblİsim
            // 
            this.lblİsim.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblİsim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblİsim.Location = new System.Drawing.Point(15, 31);
            this.lblİsim.Name = "lblİsim";
            this.lblİsim.Size = new System.Drawing.Size(106, 47);
            this.lblİsim.TabIndex = 0;
            this.lblİsim.Text = "İSİM:";
            this.lblİsim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdres
            // 
            this.lblAdres.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblAdres.Location = new System.Drawing.Point(15, 78);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(106, 47);
            this.lblAdres.TabIndex = 19;
            this.lblAdres.Text = "ADRES:";
            this.lblAdres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ekleBtn
            // 
            this.ekleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ekleBtn.FlatAppearance.BorderSize = 2;
            this.ekleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekleBtn.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ekleBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ekleBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ekleBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ekleBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ekleBtn.IconSize = 36;
            this.ekleBtn.Location = new System.Drawing.Point(189, 182);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(125, 48);
            this.ekleBtn.TabIndex = 18;
            this.ekleBtn.Text = "EKLE";
            this.ekleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ekleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ekleBtn.UseVisualStyleBackColor = false;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 727);
            this.Controls.Add(this.panel1);
            this.Name = "Ayarlar";
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.Ayarlar_Load);
            this.panel1.ResumeLayout(false);
            this.grpSifre.ResumeLayout(false);
            this.grpSifre.PerformLayout();
            this.grpIp.ResumeLayout(false);
            this.grpIp.PerformLayout();
            this.grpSil.ResumeLayout(false);
            this.grpEkle.ResumeLayout(false);
            this.grpEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtİsim;
        private System.Windows.Forms.Label lblİsim;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblAdres;
        private FontAwesome.Sharp.IconButton ekleBtn;
        private System.Windows.Forms.GroupBox grpSil;
        private System.Windows.Forms.Label lblSil;
        private FontAwesome.Sharp.IconButton btnSil;
        private System.Windows.Forms.GroupBox grpEkle;
        private System.Windows.Forms.CheckBox chkWritable;
        private System.Windows.Forms.GroupBox grpIp;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label lblIp;
        private FontAwesome.Sharp.IconButton btnIp;
        private System.Windows.Forms.GroupBox grpSifre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblSifre;
        private FontAwesome.Sharp.IconButton btnSifre;
        private FontAwesome.Sharp.IconButton btnTumunuSıl;
        private System.Windows.Forms.ComboBox cmbSil;
        private System.Windows.Forms.ComboBox comCpu;
        private System.Windows.Forms.Label lblCpuType;
        private System.Windows.Forms.TextBox txtSlot;
        private System.Windows.Forms.Label lblSlot;
        private System.Windows.Forms.TextBox txtRack;
        private System.Windows.Forms.Label lblRack;
        private System.Windows.Forms.ComboBox cmbDil;
    }
}