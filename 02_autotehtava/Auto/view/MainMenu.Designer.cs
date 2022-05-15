namespace Autokauppa.view
{
    partial class MainMenu
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
            this.btnSeuraava = new System.Windows.Forms.Button();
            this.gbAuto = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPolttoaine = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbVari = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMalli = new System.Windows.Forms.ComboBox();
            this.dtpPaiva = new System.Windows.Forms.DateTimePicker();
            this.tbMittarilukema = new System.Windows.Forms.TextBox();
            this.tbTilavuus = new System.Windows.Forms.TextBox();
            this.tbHinta = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMerkki = new System.Windows.Forms.ComboBox();
            this.btnEdellinen = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testaaTietokantaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.btnPeruuta = new System.Windows.Forms.Button();
            this.CBKategoria = new System.Windows.Forms.ComboBox();
            this.BtnHae = new System.Windows.Forms.Button();
            this.GBHaku = new System.Windows.Forms.GroupBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbAuto.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.GBHaku.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeuraava
            // 
            this.btnSeuraava.Location = new System.Drawing.Point(71, 230);
            this.btnSeuraava.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeuraava.Name = "btnSeuraava";
            this.btnSeuraava.Size = new System.Drawing.Size(53, 33);
            this.btnSeuraava.TabIndex = 35;
            this.btnSeuraava.Text = ">";
            this.btnSeuraava.UseVisualStyleBackColor = true;
            this.btnSeuraava.Click += new System.EventHandler(this.btnSeuraava_Click);
            // 
            // gbAuto
            // 
            this.gbAuto.Controls.Add(this.label8);
            this.gbAuto.Controls.Add(this.label7);
            this.gbAuto.Controls.Add(this.label6);
            this.gbAuto.Controls.Add(this.label5);
            this.gbAuto.Controls.Add(this.label4);
            this.gbAuto.Controls.Add(this.cbPolttoaine);
            this.gbAuto.Controls.Add(this.label3);
            this.gbAuto.Controls.Add(this.cbVari);
            this.gbAuto.Controls.Add(this.label2);
            this.gbAuto.Controls.Add(this.cbMalli);
            this.gbAuto.Controls.Add(this.dtpPaiva);
            this.gbAuto.Controls.Add(this.tbMittarilukema);
            this.gbAuto.Controls.Add(this.tbTilavuus);
            this.gbAuto.Controls.Add(this.tbHinta);
            this.gbAuto.Controls.Add(this.tbId);
            this.gbAuto.Controls.Add(this.label1);
            this.gbAuto.Controls.Add(this.cbMerkki);
            this.gbAuto.Location = new System.Drawing.Point(12, 36);
            this.gbAuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAuto.Name = "gbAuto";
            this.gbAuto.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAuto.Size = new System.Drawing.Size(568, 188);
            this.gbAuto.TabIndex = 18;
            this.gbAuto.TabStop = false;
            this.gbAuto.Text = "Auton tiedot";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 121);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Moottorin Tilavuus:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Mittarilukema:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Rekisteröintipäivä:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Hinta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Polttoaine:";
            // 
            // cbPolttoaine
            // 
            this.cbPolttoaine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPolttoaine.FormattingEnabled = true;
            this.cbPolttoaine.Location = new System.Drawing.Point(411, 117);
            this.cbPolttoaine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPolttoaine.Name = "cbPolttoaine";
            this.cbPolttoaine.Size = new System.Drawing.Size(121, 24);
            this.cbPolttoaine.TabIndex = 27;
            this.cbPolttoaine.Click += new System.EventHandler(this.ModifyComboBox);
            this.cbPolttoaine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Väri:";
            // 
            // cbVari
            // 
            this.cbVari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVari.FormattingEnabled = true;
            this.cbVari.Location = new System.Drawing.Point(411, 86);
            this.cbVari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbVari.Name = "cbVari";
            this.cbVari.Size = new System.Drawing.Size(121, 24);
            this.cbVari.TabIndex = 26;
            this.cbVari.Click += new System.EventHandler(this.ModifyComboBox);
            this.cbVari.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Malli:";
            // 
            // cbMalli
            // 
            this.cbMalli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMalli.FormattingEnabled = true;
            this.cbMalli.Location = new System.Drawing.Point(411, 57);
            this.cbMalli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMalli.Name = "cbMalli";
            this.cbMalli.Size = new System.Drawing.Size(121, 24);
            this.cbMalli.TabIndex = 25;
            this.cbMalli.Click += new System.EventHandler(this.ModifyComboBox);
            this.cbMalli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValueChanged);
            // 
            // dtpPaiva
            // 
            this.dtpPaiva.Enabled = false;
            this.dtpPaiva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaiva.Location = new System.Drawing.Point(143, 58);
            this.dtpPaiva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpPaiva.Name = "dtpPaiva";
            this.dtpPaiva.Size = new System.Drawing.Size(148, 22);
            this.dtpPaiva.TabIndex = 21;
            // 
            // tbMittarilukema
            // 
            this.tbMittarilukema.Location = new System.Drawing.Point(143, 87);
            this.tbMittarilukema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMittarilukema.Name = "tbMittarilukema";
            this.tbMittarilukema.Size = new System.Drawing.Size(148, 22);
            this.tbMittarilukema.TabIndex = 22;
            this.tbMittarilukema.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValueChanged);
            // 
            // tbTilavuus
            // 
            this.tbTilavuus.Location = new System.Drawing.Point(143, 117);
            this.tbTilavuus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTilavuus.Name = "tbTilavuus";
            this.tbTilavuus.Size = new System.Drawing.Size(148, 22);
            this.tbTilavuus.TabIndex = 23;
            this.tbTilavuus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValueChanged);
            // 
            // tbHinta
            // 
            this.tbHinta.Location = new System.Drawing.Point(143, 28);
            this.tbHinta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(148, 22);
            this.tbHinta.TabIndex = 20;
            this.tbHinta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValueChanged);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(411, 148);
            this.tbId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(121, 22);
            this.tbId.TabIndex = 29;
            this.tbId.TextChanged += new System.EventHandler(this.tbId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Automerkki:";
            // 
            // cbMerkki
            // 
            this.cbMerkki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMerkki.FormattingEnabled = true;
            this.cbMerkki.Location = new System.Drawing.Point(411, 27);
            this.cbMerkki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMerkki.Name = "cbMerkki";
            this.cbMerkki.Size = new System.Drawing.Size(121, 24);
            this.cbMerkki.TabIndex = 24;
            this.cbMerkki.SelectedIndexChanged += new System.EventHandler(this.cbMerkki_SelectedIndexChanged);
            this.cbMerkki.Click += new System.EventHandler(this.ModifyComboBox);
            this.cbMerkki.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValueChanged);
            // 
            // btnEdellinen
            // 
            this.btnEdellinen.Location = new System.Drawing.Point(12, 230);
            this.btnEdellinen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdellinen.Name = "btnEdellinen";
            this.btnEdellinen.Size = new System.Drawing.Size(53, 33);
            this.btnEdellinen.TabIndex = 34;
            this.btnEdellinen.Text = "<";
            this.btnEdellinen.UseVisualStyleBackColor = true;
            this.btnEdellinen.Click += new System.EventHandler(this.btnEdellinen_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(700, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.exitToolStripMenuItem.Text = "Tiedosto";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(123, 26);
            this.exitToolStripMenuItem1.Text = "Poistu";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testaaTietokantaaToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.aboutToolStripMenuItem.Text = "Muuta...";
            // 
            // testaaTietokantaaToolStripMenuItem
            // 
            this.testaaTietokantaaToolStripMenuItem.Name = "testaaTietokantaaToolStripMenuItem";
            this.testaaTietokantaaToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.testaaTietokantaaToolStripMenuItem.Text = "Testaa tietokantaa";
            this.testaaTietokantaaToolStripMenuItem.Click += new System.EventHandler(this.testaaTietokantaaToolStripMenuItem_Click);
            // 
            // btnLisaa
            // 
            this.btnLisaa.BackColor = System.Drawing.Color.Transparent;
            this.btnLisaa.Location = new System.Drawing.Point(585, 50);
            this.btnLisaa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(93, 33);
            this.btnLisaa.TabIndex = 30;
            this.btnLisaa.Text = "Uusi";
            this.btnLisaa.UseVisualStyleBackColor = false;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.BackColor = System.Drawing.Color.Transparent;
            this.btnPoista.Location = new System.Drawing.Point(585, 170);
            this.btnPoista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(93, 33);
            this.btnPoista.TabIndex = 33;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = false;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnTallenna
            // 
            this.btnTallenna.BackColor = System.Drawing.Color.Transparent;
            this.btnTallenna.Enabled = false;
            this.btnTallenna.Location = new System.Drawing.Point(585, 89);
            this.btnTallenna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(93, 33);
            this.btnTallenna.TabIndex = 31;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = false;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // btnPeruuta
            // 
            this.btnPeruuta.BackColor = System.Drawing.Color.Transparent;
            this.btnPeruuta.Enabled = false;
            this.btnPeruuta.Location = new System.Drawing.Point(585, 129);
            this.btnPeruuta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPeruuta.Name = "btnPeruuta";
            this.btnPeruuta.Size = new System.Drawing.Size(93, 33);
            this.btnPeruuta.TabIndex = 32;
            this.btnPeruuta.Text = "Peruuta";
            this.btnPeruuta.UseVisualStyleBackColor = false;
            this.btnPeruuta.Click += new System.EventHandler(this.btnPeruuta_Click);
            // 
            // CBKategoria
            // 
            this.CBKategoria.FormattingEnabled = true;
            this.CBKategoria.Location = new System.Drawing.Point(131, 230);
            this.CBKategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBKategoria.Name = "CBKategoria";
            this.CBKategoria.Size = new System.Drawing.Size(152, 24);
            this.CBKategoria.TabIndex = 37;
            this.CBKategoria.SelectedIndexChanged += new System.EventHandler(this.CBKategoria_SelectedIndexChanged);
            // 
            // BtnHae
            // 
            this.BtnHae.Location = new System.Drawing.Point(585, 230);
            this.BtnHae.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnHae.Name = "BtnHae";
            this.BtnHae.Size = new System.Drawing.Size(93, 33);
            this.BtnHae.TabIndex = 38;
            this.BtnHae.Text = "Hae";
            this.BtnHae.UseVisualStyleBackColor = true;
            this.BtnHae.Click += new System.EventHandler(this.BtnHae_Click);
            // 
            // GBHaku
            // 
            this.GBHaku.Controls.Add(this.dataGrid);
            this.GBHaku.Location = new System.Drawing.Point(12, 271);
            this.GBHaku.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GBHaku.Name = "GBHaku";
            this.GBHaku.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GBHaku.Size = new System.Drawing.Size(667, 364);
            this.GBHaku.TabIndex = 39;
            this.GBHaku.TabStop = false;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(5, 25);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(653, 332);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(295, 230);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(285, 26);
            this.flowLayoutPanel1.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 641);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 33);
            this.button1.TabIndex = 41;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(75, 641);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 33);
            this.button2.TabIndex = 42;
            this.button2.Text = "->";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 689);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.GBHaku);
            this.Controls.Add(this.BtnHae);
            this.Controls.Add(this.CBKategoria);
            this.Controls.Add(this.btnPeruuta);
            this.Controls.Add(this.btnTallenna);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.btnEdellinen);
            this.Controls.Add(this.gbAuto);
            this.Controls.Add(this.btnSeuraava);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.gbAuto.ResumeLayout(false);
            this.gbAuto.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GBHaku.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSeuraava;
        private System.Windows.Forms.GroupBox gbAuto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPolttoaine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbVari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMalli;
        private System.Windows.Forms.DateTimePicker dtpPaiva;
        private System.Windows.Forms.TextBox tbMittarilukema;
        private System.Windows.Forms.TextBox tbTilavuus;
        private System.Windows.Forms.TextBox tbHinta;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMerkki;
        private System.Windows.Forms.Button btnEdellinen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testaaTietokantaaToolStripMenuItem;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPeruuta;
        private System.Windows.Forms.ComboBox CBKategoria;
        private System.Windows.Forms.Button BtnHae;
        private System.Windows.Forms.GroupBox GBHaku;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}