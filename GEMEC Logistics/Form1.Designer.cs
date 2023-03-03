namespace GEMEC_Logistics
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogistikRechnerCalculate = new System.Windows.Forms.Button();
            this.txtLogistikRechnerTransportItems = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLogistikRechnerBelohnung = new System.Windows.Forms.TextBox();
            this.txtLogistikRechnerVersicherung = new System.Windows.Forms.TextBox();
            this.txtLogistikRechnerGesamtkubikmeter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.picbLogistikRechnerBelohnung = new System.Windows.Forms.PictureBox();
            this.picbLogistikRechnerVersicherung = new System.Windows.Forms.PictureBox();
            this.picbLogistikRechnerGesamtkubik = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnPreisvergleichVergleich = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbPreisvergleichItem = new System.Windows.Forms.ComboBox();
            this.lblPreisvergleichMarktZwei = new System.Windows.Forms.Label();
            this.lblPreisvergleichMarktEins = new System.Windows.Forms.Label();
            this.cbPreisvergleichMarktZwei = new System.Windows.Forms.ComboBox();
            this.cbPreisvergleichMarktEins = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbLogistikRechnerBelohnung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbLogistikRechnerVersicherung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbLogistikRechnerGesamtkubik)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Items für den Transport (max. 335.000m³):";
            // 
            // btnLogistikRechnerCalculate
            // 
            this.btnLogistikRechnerCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogistikRechnerCalculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogistikRechnerCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogistikRechnerCalculate.Location = new System.Drawing.Point(283, 203);
            this.btnLogistikRechnerCalculate.Name = "btnLogistikRechnerCalculate";
            this.btnLogistikRechnerCalculate.Size = new System.Drawing.Size(226, 38);
            this.btnLogistikRechnerCalculate.TabIndex = 1;
            this.btnLogistikRechnerCalculate.Text = "Berechne Transport";
            this.btnLogistikRechnerCalculate.UseVisualStyleBackColor = true;
            this.btnLogistikRechnerCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtLogistikRechnerTransportItems
            // 
            this.txtLogistikRechnerTransportItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogistikRechnerTransportItems.Location = new System.Drawing.Point(4, 4);
            this.txtLogistikRechnerTransportItems.Multiline = true;
            this.txtLogistikRechnerTransportItems.Name = "txtLogistikRechnerTransportItems";
            this.txtLogistikRechnerTransportItems.Size = new System.Drawing.Size(785, 193);
            this.txtLogistikRechnerTransportItems.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Belohnung:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Versicherung:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gesamt m³:";
            // 
            // txtLogistikRechnerBelohnung
            // 
            this.txtLogistikRechnerBelohnung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogistikRechnerBelohnung.Enabled = false;
            this.txtLogistikRechnerBelohnung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogistikRechnerBelohnung.Location = new System.Drawing.Point(198, 272);
            this.txtLogistikRechnerBelohnung.Name = "txtLogistikRechnerBelohnung";
            this.txtLogistikRechnerBelohnung.Size = new System.Drawing.Size(311, 29);
            this.txtLogistikRechnerBelohnung.TabIndex = 6;
            this.txtLogistikRechnerBelohnung.Text = "0";
            // 
            // txtLogistikRechnerVersicherung
            // 
            this.txtLogistikRechnerVersicherung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogistikRechnerVersicherung.Enabled = false;
            this.txtLogistikRechnerVersicherung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogistikRechnerVersicherung.Location = new System.Drawing.Point(198, 307);
            this.txtLogistikRechnerVersicherung.Name = "txtLogistikRechnerVersicherung";
            this.txtLogistikRechnerVersicherung.Size = new System.Drawing.Size(311, 29);
            this.txtLogistikRechnerVersicherung.TabIndex = 7;
            this.txtLogistikRechnerVersicherung.Text = "0";
            // 
            // txtLogistikRechnerGesamtkubikmeter
            // 
            this.txtLogistikRechnerGesamtkubikmeter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogistikRechnerGesamtkubikmeter.Enabled = false;
            this.txtLogistikRechnerGesamtkubikmeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogistikRechnerGesamtkubikmeter.Location = new System.Drawing.Point(198, 342);
            this.txtLogistikRechnerGesamtkubikmeter.Name = "txtLogistikRechnerGesamtkubikmeter";
            this.txtLogistikRechnerGesamtkubikmeter.Size = new System.Drawing.Size(145, 29);
            this.txtLogistikRechnerGesamtkubikmeter.TabIndex = 8;
            this.txtLogistikRechnerGesamtkubikmeter.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(515, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "ISK";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(515, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "ISK";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(349, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "m³";
            // 
            // picbLogistikRechnerBelohnung
            // 
            this.picbLogistikRechnerBelohnung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picbLogistikRechnerBelohnung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbLogistikRechnerBelohnung.Image = ((System.Drawing.Image)(resources.GetObject("picbLogistikRechnerBelohnung.Image")));
            this.picbLogistikRechnerBelohnung.Location = new System.Drawing.Point(162, 269);
            this.picbLogistikRechnerBelohnung.Name = "picbLogistikRechnerBelohnung";
            this.picbLogistikRechnerBelohnung.Size = new System.Drawing.Size(30, 30);
            this.picbLogistikRechnerBelohnung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbLogistikRechnerBelohnung.TabIndex = 12;
            this.picbLogistikRechnerBelohnung.TabStop = false;
            this.picbLogistikRechnerBelohnung.Click += new System.EventHandler(this.picbBelohnung_Click);
            this.picbLogistikRechnerBelohnung.MouseLeave += new System.EventHandler(this.picbBelohnung_MouseLeave);
            this.picbLogistikRechnerBelohnung.MouseHover += new System.EventHandler(this.picbBelohnung_MouseHover);
            // 
            // picbLogistikRechnerVersicherung
            // 
            this.picbLogistikRechnerVersicherung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picbLogistikRechnerVersicherung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbLogistikRechnerVersicherung.Image = ((System.Drawing.Image)(resources.GetObject("picbLogistikRechnerVersicherung.Image")));
            this.picbLogistikRechnerVersicherung.Location = new System.Drawing.Point(162, 304);
            this.picbLogistikRechnerVersicherung.Name = "picbLogistikRechnerVersicherung";
            this.picbLogistikRechnerVersicherung.Size = new System.Drawing.Size(30, 30);
            this.picbLogistikRechnerVersicherung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbLogistikRechnerVersicherung.TabIndex = 13;
            this.picbLogistikRechnerVersicherung.TabStop = false;
            this.picbLogistikRechnerVersicherung.Click += new System.EventHandler(this.picbVersicherung_Click);
            this.picbLogistikRechnerVersicherung.MouseLeave += new System.EventHandler(this.picbVersicherung_MouseLeave);
            this.picbLogistikRechnerVersicherung.MouseHover += new System.EventHandler(this.picbVersicherung_MouseHover);
            // 
            // picbLogistikRechnerGesamtkubik
            // 
            this.picbLogistikRechnerGesamtkubik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picbLogistikRechnerGesamtkubik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbLogistikRechnerGesamtkubik.Image = ((System.Drawing.Image)(resources.GetObject("picbLogistikRechnerGesamtkubik.Image")));
            this.picbLogistikRechnerGesamtkubik.Location = new System.Drawing.Point(162, 339);
            this.picbLogistikRechnerGesamtkubik.Name = "picbLogistikRechnerGesamtkubik";
            this.picbLogistikRechnerGesamtkubik.Size = new System.Drawing.Size(30, 30);
            this.picbLogistikRechnerGesamtkubik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbLogistikRechnerGesamtkubik.TabIndex = 14;
            this.picbLogistikRechnerGesamtkubik.TabStop = false;
            this.picbLogistikRechnerGesamtkubik.Click += new System.EventHandler(this.picbGesamtkubik_Click);
            this.picbLogistikRechnerGesamtkubik.MouseLeave += new System.EventHandler(this.picbGesamtkubik_MouseLeave);
            this.picbLogistikRechnerGesamtkubik.MouseHover += new System.EventHandler(this.picbGesamtkubik_MouseHover);
            // 
            // btnPreisvergleichVergleich
            // 
            this.btnPreisvergleichVergleich.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreisvergleichVergleich.Location = new System.Drawing.Point(407, 26);
            this.btnPreisvergleichVergleich.Margin = new System.Windows.Forms.Padding(1);
            this.btnPreisvergleichVergleich.Name = "btnPreisvergleichVergleich";
            this.btnPreisvergleichVergleich.Size = new System.Drawing.Size(119, 26);
            this.btnPreisvergleichVergleich.TabIndex = 15;
            this.btnPreisvergleichVergleich.Text = "Vergleichen";
            this.btnPreisvergleichVergleich.UseVisualStyleBackColor = true;
            this.btnPreisvergleichVergleich.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 400);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.txtLogistikRechnerTransportItems);
            this.tabPage1.Controls.Add(this.btnLogistikRechnerCalculate);
            this.tabPage1.Controls.Add(this.picbLogistikRechnerGesamtkubik);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.picbLogistikRechnerVersicherung);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.picbLogistikRechnerBelohnung);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtLogistikRechnerBelohnung);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtLogistikRechnerVersicherung);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtLogistikRechnerGesamtkubikmeter);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage1.Size = new System.Drawing.Size(792, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LogistikRechner";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.cbPreisvergleichItem);
            this.tabPage2.Controls.Add(this.lblPreisvergleichMarktZwei);
            this.tabPage2.Controls.Add(this.lblPreisvergleichMarktEins);
            this.tabPage2.Controls.Add(this.cbPreisvergleichMarktZwei);
            this.tabPage2.Controls.Add(this.cbPreisvergleichMarktEins);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.btnPreisvergleichVergleich);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage2.Size = new System.Drawing.Size(792, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Preisvergleich";
            // 
            // cbPreisvergleichItem
            // 
            this.cbPreisvergleichItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPreisvergleichItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbPreisvergleichItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPreisvergleichItem.FormattingEnabled = true;
            this.cbPreisvergleichItem.Items.AddRange(new object[] {
            "EvEItemValues.itemName",
            "#System",
            "Corporation",
            "Region",
            "Constellation",
            "Solar System",
            "Sun G5 (Yellow)",
            "Sun K7 (Orange)",
            "Sun K5 (Red Giant)",
            "Sun B0 (Blue)",
            "Sun F0 (White)",
            "Planet (Temperate)",
            "Planet (Ice)",
            "Planet (Gas)",
            "Moon",
            "Asteroid Belt",
            "Stargate (Caldari System)",
            "Stargate (Amarr Constellation)",
            "Plagioclase",
            "Spodumain",
            "Kernite",
            "Hedbergite",
            "Arkonor",
            "Cargo Container",
            "Ring",
            "Corpse Male",
            "Office Folder",
            "Office",
            "Factory Folder",
            "Credits",
            "Faction",
            "Tritanium",
            "Pyerite",
            "Mexallon",
            "Isogen",
            "Nocxium",
            "Zydrine",
            "Megacyte",
            "Garbage",
            "Spiced Wine",
            "Antibiotics",
            "Enriched Uranium",
            "Frozen Plant Seeds",
            "Player Kill",
            "Company Shares",
            "Bookmark",
            "Trading",
            "Trade Session",
            "Caldari Logistics Station",
            "Gallente Military Station",
            "Gallente Station Hub",
            "C-O-1",
            "C-O-2",
            "Asset Safety Wrap",
            "Clone Grade Alpha",
            "Clone Grade Beta",
            "Clone Grade Gamma",
            "Carbonized Lead S",
            "Nuclear S",
            "Proton S",
            "Depleted Uranium S",
            "Titanium Sabot S",
            "Fusion S",
            "Phased Plasma S",
            "EMP S",
            "Carbonized Lead M",
            "Nuclear M",
            "Proton M",
            "Depleted Uranium M",
            "Titanium Sabot M",
            "Fusion M",
            "Phased Plasma M",
            "EMP M",
            "Carbonized Lead L",
            "Nuclear L",
            "Proton L",
            "Depleted Uranium L",
            "Titanium Sabot L",
            "Fusion L",
            "Phased Plasma L",
            "EMP L",
            "Mjolnir Cruise Missile",
            "Scourge Cruise Missile",
            "Inferno Cruise Missile",
            "Nova Cruise Missile",
            "Nova Heavy Missile",
            "Mjolnir Heavy Missile",
            "Inferno Heavy Missile",
            "Scourge Heavy Missile",
            "Scourge Light Missile",
            "Inferno Light Missile",
            "Mjolnir Light Missile",
            "Nova Light Missile",
            "Iron Charge S",
            "Tungsten Charge S",
            "Iridium Charge S",
            "Lead Charge S",
            "Thorium Charge S",
            "Uranium Charge S",
            "Plutonium Charge S",
            "Antimatter Charge S",
            "Iron Charge M",
            "Tungsten Charge M",
            "Iridium Charge M",
            "Lead Charge M",
            "Thorium Charge M",
            "Uranium Charge M",
            "Plutonium Charge M",
            "Antimatter Charge M",
            "Iron Charge L",
            "Tungsten Charge L",
            "Iridium Charge L",
            "Lead Charge L",
            "Thorium Charge L",
            "Uranium Charge L",
            "Plutonium Charge L",
            "Antimatter Charge L",
            "Radio S",
            "Microwave S",
            "Infrared S",
            "Standard S",
            "Ultraviolet S",
            "Xray S",
            "Gamma S",
            "Multifrequency S",
            "Radio M",
            "Microwave M",
            "Infrared M",
            "Standard M",
            "Ultraviolet M",
            "Xray M",
            "Gamma M",
            "Multifrequency M",
            "Radio L",
            "Microwave L",
            "Infrared L",
            "Standard L",
            "Ultraviolet L",
            "Xray L",
            "Gamma L",
            "Multifrequency L",
            "Cap Booster 25",
            "Cap Booster 50",
            "Heavy Defender Missile I",
            "Scourge Rocket",
            "Scourge Torpedo",
            "Mjolnir Auto-Targeting Light Missile I",
            "Python Mine",
            "Small Shield Extender I",
            "Small Shield Extender II",
            "Shield Recharger I",
            "Shield Recharger II",
            "Small Shield Booster I",
            "Small Shield Booster II",
            "\'Micro\' Remote Shield Booster",
            "Micro Remote Shield Booster II",
            "\'Basic\' Capacitor Recharger",
            "5MN Microwarpdrive I",
            "1MN Afterburner II",
            "1MN Afterburner I",
            "5MN Microwarpdrive II",
            "Cargo Scanner I",
            "Ship Scanner I",
            "Survey Scanner I",
            "Warp Scrambler I",
            "Warp Scrambler II",
            "Gatling Pulse Laser I",
            "Dual Light Pulse Laser I",
            "Dual Light Beam Laser I",
            "Small Focused Pulse Laser I",
            "Small Focused Beam Laser I",
            "Quad Light Beam Laser I",
            "Focused Medium Pulse Laser I",
            "Focused Medium Beam Laser I",
            "Heavy Pulse Laser I",
            "Heavy Beam Laser I",
            "Dual Heavy Pulse Laser I",
            "Dual Heavy Beam Laser I",
            "Mega Pulse Laser I",
            "Mega Beam Laser I",
            "Tachyon Beam Laser I",
            "Miner II",
            "Miner I",
            "125mm Gatling AutoCannon I",
            "150mm Light AutoCannon I",
            "200mm AutoCannon I",
            "250mm Light Artillery Cannon I",
            "280mm Howitzer Artillery I",
            "Dual 180mm AutoCannon I",
            "220mm Vulcan AutoCannon I",
            "425mm AutoCannon I",
            "650mm Artillery Cannon I",
            "720mm Howitzer Artillery I",
            "Dual 425mm AutoCannon I",
            "Dual 650mm Repeating Cannon I",
            "800mm Repeating Cannon I",
            "1200mm Artillery Cannon I",
            "1400mm Howitzer Artillery I",
            "Light Missile Launcher I",
            "Heavy Missile Launcher I",
            "Torpedo Launcher I",
            "\'Basic\' Capacitor Power Relay",
            "\'Basic\' Shield Flux Coil",
            "\'Basic\' Capacitor Flux Coil",
            "\'Basic\' Gyrostabilizer",
            "Gyrostabilizer II",
            "Gyrostabilizer I",
            "\'Basic\' Damage Control",
            "\'Micro\' Cap Battery",
            "Small Armor Repairer I",
            "Small Hull Repairer I",
            "Stasis Webifier I",
            "Stasis Webifier II",
            "Small Remote Capacitor Transmitter I",
            "Small Energy Nosferatu I",
            "Small Energy Neutralizer I",
            "75mm Gatling Rail I",
            "Light Electron Blaster I",
            "Light Ion Blaster I",
            "Light Neutron Blaster I",
            "150mm Railgun I",
            "Heavy Electron Blaster I",
            "Dual 150mm Railgun I",
            "Heavy Neutron Blaster I",
            "Heavy Ion Blaster I",
            "250mm Railgun I",
            "Electron Blaster Cannon I",
            "Dual 250mm Railgun I",
            "Neutron Blaster Cannon I",
            "425mm Railgun I",
            "Ion Blaster Cannon I",
            "Medium Capacitor Booster I",
            "Multispectrum Shield Hardener I",
            "Burst Jammer I",
            "Passive Targeter I",
            "Bantam",
            "Condor",
            "Griffin",
            "Slasher",
            "Probe",
            "Rifter",
            "Reaper",
            "Executioner",
            "Inquisitor",
            "Tormentor",
            "Navitas",
            "Tristan",
            "Incursus",
            "Gallente Police Ship",
            "Impairor",
            "Punisher",
            "Breacher",
            "Burst",
            "Minmatar Peacekeeper Ship",
            "Ibis",
            "Kestrel",
            "Merlin",
            "Heron",
            "Velator",
            "Imicus",
            "Atron",
            "Maulus",
            "Devourer",
            "Fury",
            "Immolator",
            "Medusa",
            "Echo",
            "Lynx",
            "Swordspine",
            "Osprey",
            "Caracal",
            "Stabber",
            "Moa",
            "Maller",
            "Augoror",
            "Vexor",
            "Thorax",
            "Arbitrator",
            "Rupture",
            "Bellicose",
            "Scythe",
            "Blackbird",
            "Celestis",
            "Exequror",
            "Opux Luxury Yacht",
            "Raven",
            "Tempest",
            "Scorpion",
            "Megathron",
            "Apocalypse",
            "Armageddon",
            "Typhoon",
            "Dominix",
            "Badger",
            "Tayra",
            "Nereus",
            "Hoarder",
            "Mammoth",
            "Wreathe",
            "Kryos",
            "Epithal",
            "Miasmos",
            "Iteron Mark V",
            "Capsule",
            "Erebus",
            "Caldari Shuttle",
            "Clone Grade Beta Blueprint",
            "Clone Grade Gamma Blueprint",
            "Bantam Blueprint",
            "Condor Blueprint",
            "Griffin Blueprint",
            "Osprey Blueprint",
            "Caracal Blueprint",
            "Raven Blueprint",
            "Slasher Blueprint",
            "Probe Blueprint",
            "Rifter Blueprint",
            "Stabber Blueprint",
            "Tempest Blueprint",
            "Miner II Blueprint",
            "Miner I Blueprint",
            "Light Missile Launcher I Blueprint",
            "Heavy Missile Launcher I Blueprint",
            "Torpedo Launcher I Blueprint",
            "Mjolnir Cruise Missile Blueprint",
            "Scourge Cruise Missile Blueprint",
            "Inferno Cruise Missile Blueprint",
            "Nova Cruise Missile Blueprint",
            "Nova Heavy Missile Blueprint",
            "Mjolnir Heavy Missile Blueprint",
            "Inferno Heavy Missile Blueprint",
            "Scourge Heavy Missile Blueprint",
            "Scourge Light Missile Blueprint",
            "Inferno Light Missile Blueprint",
            "Mjolnir Light Missile Blueprint",
            "Nova Light Missile Blueprint",
            "125mm Gatling AutoCannon I Blueprint",
            "150mm Light AutoCannon I Blueprint",
            "200mm AutoCannon I Blueprint",
            "250mm Light Artillery Cannon I Blueprint",
            "280mm Howitzer Artillery I Blueprint",
            "Dual 180mm AutoCannon I Blueprint",
            "220mm Vulcan AutoCannon I Blueprint",
            "425mm AutoCannon I Blueprint",
            "650mm Artillery Cannon I Blueprint",
            "720mm Howitzer Artillery I Blueprint",
            "Dual 425mm AutoCannon I Blueprint",
            "Dual 650mm Repeating Cannon I Blueprint",
            "800mm Repeating Cannon I Blueprint",
            "1200mm Artillery Cannon I Blueprint",
            "1400mm Howitzer Artillery I Blueprint",
            "Gatling Pulse Laser I Blueprint",
            "Dual Light Pulse Laser I Blueprint",
            "Dual Light Beam Laser I Blueprint",
            "Small Focused Pulse Laser I Blueprint",
            "Small Focused Beam Laser I Blueprint",
            "Quad Light Beam Laser I Blueprint",
            "Focused Medium Pulse Laser I Blueprint",
            "Focused Medium Beam Laser I Blueprint",
            "Heavy Pulse Laser I Blueprint",
            "Heavy Beam Laser I Blueprint",
            "Dual Heavy Pulse Laser I Blueprint",
            "Dual Heavy Beam Laser I Blueprint",
            "Mega Pulse Laser I Blueprint",
            "Mega Beam Laser I Blueprint",
            "Tachyon Beam Laser I Blueprint",
            "Carbonized Lead S Blueprint",
            "Nuclear S Blueprint",
            "Proton S Blueprint",
            "Depleted Uranium S Blueprint",
            "Titanium Sabot S Blueprint",
            "Fusion S Blueprint",
            "Phased Plasma S Blueprint",
            "EMP S Blueprint",
            "Carbonized Lead M Blueprint",
            "Nuclear M Blueprint",
            "Proton M Blueprint",
            "Depleted Uranium M Blueprint",
            "Titanium Sabot M Blueprint",
            "Fusion M Blueprint",
            "Phased Plasma M Blueprint",
            "EMP M Blueprint",
            "Carbonized Lead L Blueprint",
            "Nuclear L Blueprint",
            "Proton L Blueprint",
            "Depleted Uranium L Blueprint",
            "Titanium Sabot L Blueprint",
            "Fusion L Blueprint",
            "Phased Plasma L Blueprint",
            "EMP L Blueprint",
            "Reaper Blueprint",
            "Executioner Blueprint",
            "Inquisitor Blueprint",
            "Tormentor Blueprint",
            "Navitas Blueprint",
            "Tristan Blueprint",
            "Incursus Blueprint",
            "Impairor Blueprint",
            "Punisher Blueprint",
            "Breacher Blueprint",
            "Burst Blueprint",
            "Minmatar Peacekeeper Ship Blueprint",
            "Ibis Blueprint",
            "Kestrel Blueprint",
            "Merlin Blueprint",
            "Heron Blueprint",
            "Velator Blueprint",
            "Imicus Blueprint",
            "Atron Blueprint",
            "Maulus Blueprint",
            "Devourer Blueprint",
            "Fury Blueprint",
            "Immolator Blueprint",
            "Medusa Blueprint",
            "Echo Blueprint",
            "Lynx Blueprint",
            "Swordspine Blueprint",
            "Caldari Shuttle Blueprint",
            "Moa Blueprint",
            "Maller Blueprint",
            "Augoror Blueprint",
            "Vexor Blueprint",
            "Thorax Blueprint",
            "Arbitrator Blueprint",
            "Rupture Blueprint",
            "Bellicose Blueprint",
            "Scythe Blueprint",
            "Blackbird Blueprint",
            "Celestis Blueprint",
            "Exequror Blueprint",
            "Badger Blueprint",
            "Tayra Blueprint",
            "Nereus Blueprint",
            "Hoarder Blueprint",
            "Mammoth Blueprint",
            "Wreathe Blueprint",
            "Kryos Blueprint",
            "Epithal Blueprint",
            "Miasmos Blueprint",
            "Iteron Mark V Blueprint",
            "Scorpion Blueprint",
            "Megathron Blueprint",
            "Apocalypse Blueprint",
            "Armageddon Blueprint",
            "Typhoon Blueprint",
            "Dominix Blueprint",
            "Erebus Blueprint",
            "Small Shield Extender I Blueprint",
            "Small Shield Extender II Blueprint",
            "Shield Recharger I Blueprint",
            "Shield Recharger II Blueprint",
            "Small Shield Booster I Blueprint",
            "Small Shield Booster II Blueprint",
            "5MN Microwarpdrive I Blueprint",
            "1MN Afterburner II Blueprint",
            "1MN Afterburner I Blueprint",
            "5MN Microwarpdrive II Blueprint",
            "Cargo Scanner I Blueprint",
            "Ship Scanner I Blueprint",
            "Survey Scanner I Blueprint",
            "Warp Scrambler I Blueprint",
            "Warp Scrambler II Blueprint",
            "Gyrostabilizer II Blueprint",
            "Gyrostabilizer I Blueprint",
            "Small Armor Repairer I Blueprint",
            "Small Hull Repairer I Blueprint",
            "Stasis Webifier I Blueprint",
            "Stasis Webifier II Blueprint",
            "Small Remote Capacitor Transmitter I Blueprint",
            "Small Energy Nosferatu I Blueprint",
            "Small Energy Neutralizer I Blueprint",
            "75mm Gatling Rail I Blueprint",
            "Light Electron Blaster I Blueprint",
            "Light Ion Blaster I Blueprint",
            "Light Neutron Blaster I Blueprint",
            "150mm Railgun I Blueprint",
            "Heavy Electron Blaster I Blueprint",
            "Dual 150mm Railgun I Blueprint",
            "Heavy Neutron Blaster I Blueprint",
            "Heavy Ion Blaster I Blueprint",
            "250mm Railgun I Blueprint",
            "Electron Blaster Cannon I Blueprint",
            "Dual 250mm Railgun I Blueprint",
            "Neutron Blaster Cannon I Blueprint",
            "425mm Railgun I Blueprint",
            "Ion Blaster Cannon I Blueprint",
            "Medium Capacitor Booster I Blueprint",
            "Multispectrum Shield Hardener I Blueprint",
            "Iron Charge S Blueprint",
            "Tungsten Charge S Blueprint",
            "Iridium Charge S Blueprint",
            "Lead Charge S Blueprint",
            "Thorium Charge S Blueprint",
            "Uranium Charge S Blueprint",
            "Plutonium Charge S Blueprint",
            "Antimatter Charge S Blueprint",
            "Iron Charge M Blueprint",
            "Tungsten Charge M Blueprint",
            "Iridium Charge M Blueprint",
            "Lead Charge M Blueprint",
            "Thorium Charge M Blueprint",
            "Uranium Charge M Blueprint",
            "Plutonium Charge M Blueprint",
            "Antimatter Charge M Blueprint",
            "Iron Charge L Blueprint",
            "Tungsten Charge L Blueprint",
            "Iridium Charge L Blueprint",
            "Lead Charge L Blueprint",
            "Thorium Charge L Blueprint",
            "Uranium Charge L Blueprint",
            "Plutonium Charge L Blueprint",
            "Antimatter Charge L Blueprint",
            "Radio S Blueprint",
            "Microwave S Blueprint",
            "Infrared S Blueprint",
            "Standard S Blueprint",
            "Ultraviolet S Blueprint",
            "Xray S Blueprint",
            "Gamma S Blueprint",
            "Multifrequency S Blueprint",
            "Radio M Blueprint",
            "Microwave M Blueprint",
            "Infrared M Blueprint",
            "Standard M Blueprint",
            "Ultraviolet M Blueprint",
            "Xray M Blueprint",
            "Gamma M Blueprint",
            "Multifrequency M Blueprint",
            "Radio L Blueprint",
            "Microwave L Blueprint",
            "Infrared L Blueprint",
            "Standard L Blueprint",
            "Ultraviolet L Blueprint",
            "Xray L Blueprint",
            "Gamma L Blueprint",
            "Multifrequency L Blueprint",
            "Cap Booster 25 Blueprint",
            "Cap Booster 50 Blueprint",
            "Auto Targeting System I",
            "Small Armor Repairer II",
            "Small Armor Repairer II Blueprint",
            "Small Cap Battery I",
            "Small Cap Battery I Blueprint",
            "Small Remote Capacitor Transmitter II",
            "Small Remote Capacitor Transmitter II Blueprint",
            "\'Basic\' Overdrive Injector System",
            "\'Basic\' EM Coating",
            "Amarr Sentry Gun",
            "Cap Recharger I",
            "Cap Recharger I Blueprint",
            "EM Coating I",
            "EM Coating II",
            "Wasp I",
            "Civilian Mining Drone",
            "EM Coating I Blueprint",
            "EM Coating II Blueprint",
            "Auto Targeting System I Blueprint",
            "Burst Jammer I Blueprint",
            "Passive Targeter I Blueprint",
            "Wasp I Blueprint",
            "Mjolnir Auto-Targeting Light Missile I Blueprint",
            "Python Mine Blueprint",
            "Civilian Mining Drone Blueprint",
            "Scourge Rocket Blueprint",
            "Scourge Torpedo Blueprint",
            "Bistot",
            "Pyroxeres",
            "Crokite",
            "Jaspet",
            "Omber",
            "Scordite",
            "Gneiss",
            "Veldspar",
            "Hemorphite",
            "Dark Ochre",
            "Polaris Enigma Frigate",
            "Overdrive Injector System II",
            "Overdrive Injector System II Blueprint",
            "\'Basic\' Reinforced Bulkheads",
            "\'Basic\' Nanofiber Internal Structure",
            "Overdrive Injector System I",
            "Overdrive Injector System I Blueprint",
            "Capacitor Flux Coil I",
            "Capacitor Flux Coil I Blueprint",
            "Capacitor Flux Coil II",
            "Capacitor Flux Coil II Blueprint",
            "Shield Flux Coil I",
            "Shield Flux Coil I Blueprint",
            "Shield Flux Coil II",
            "Shield Flux Coil II Blueprint",
            "\'Basic\' Explosive Coating",
            "Explosive Coating I",
            "Explosive Coating I Blueprint",
            "Explosive Coating II",
            "Explosive Coating II Blueprint",
            "\'Basic\' Layered Coating",
            "Layered Coating I",
            "Layered Coating I Blueprint",
            "Layered Coating II",
            "Layered Coating II Blueprint",
            "\'Basic\' Kinetic Coating",
            "Kinetic Coating I",
            "Kinetic Coating I Blueprint",
            "Kinetic Coating II",
            "Kinetic Coating II Blueprint",
            "\'Basic\' Thermal Coating",
            "Thermal Coating I",
            "Thermal Coating I Blueprint",
            "Thermal Coating II",
            "Thermal Coating II Blueprint",
            "\'Basic\' Multispectrum Coating",
            "Multispectrum Coating I",
            "Multispectrum Coating I Blueprint",
            "Multispectrum Coating II",
            "Multispectrum Coating II Blueprint",
            "\'Basic\' Expanded Cargohold",
            "Expanded Cargohold I",
            "Expanded Cargohold I Blueprint",
            "Expanded Cargohold II",
            "Expanded Cargohold II Blueprint",
            "Reinforced Bulkheads I",
            "Reinforced Bulkheads I Blueprint",
            "Reinforced Bulkheads II",
            "Reinforced Bulkheads II Blueprint",
            "\'Basic\' Reactor Control Unit",
            "Reactor Control Unit I",
            "Reactor Control Unit I Blueprint",
            "Reactor Control Unit II",
            "Reactor Control Unit II Blueprint",
            "CharacterType",
            "CharacterLegacy10",
            "CharacterLegacy3",
            "CharacterLegacy4",
            "CharacterLegacy5",
            "CharacterLegacy6",
            "CharacterLegacy11",
            "CharacterLegacy2",
            "CharacterLegacy12",
            "CharacterLegacy9",
            "CharacterLegacy1",
            "CharacterLegacy7",
            "CharacterLegacy8",
            "CharacterLegacy13",
            "\'Basic\' Inertial Stabilizers",
            "Inertial Stabilizers I",
            "Inertial Stabilizers I Blueprint",
            "Inertial Stabilizers II",
            "Inertial Stabilizers II Blueprint",
            "\'Basic\' Shield Power Relay",
            "Shield Power Relay II",
            "Shield Power Relay II Blueprint",
            "Auto Targeting System II",
            "Auto Targeting System II Blueprint",
            "Capacitor Power Relay I",
            "Capacitor Power Relay I Blueprint",
            "Capacitor Power Relay II",
            "Capacitor Power Relay II Blueprint",
            "Caldari Administrative Station",
            "Caldari Research Station",
            "Caldari Trading Station",
            "\'Basic\' Power Diagnostic System",
            "Power Diagnostic System I",
            "Power Diagnostic System I Blueprint",
            "Power Diagnostic System II",
            "Power Diagnostic System II Blueprint",
            "Small Proton Smartbomb I",
            "Small Proton Smartbomb I Blueprint",
            "Small Proton Smartbomb II",
            "Small Proton Smartbomb II Blueprint",
            "Small Graviton Smartbomb I",
            "Small Graviton Smartbomb I Blueprint",
            "Small Graviton Smartbomb II",
            "Small Graviton Smartbomb II Blueprint",
            "Small Plasma Smartbomb I",
            "Small Plasma Smartbomb I Blueprint",
            "Small Plasma Smartbomb II",
            "Small Plasma Smartbomb II Blueprint",
            "Small EMP Smartbomb I",
            "Small EMP Smartbomb I Blueprint",
            "Small EMP Smartbomb II",
            "Small EMP Smartbomb II Blueprint",
            "Amarr Bonus",
            "Ni-Kunni Bonus",
            "Civire Bonus",
            "Deteis Bonus",
            "Gallente Bonus",
            "Intaki Bonus",
            "Sebiestor Bonus",
            "Brutor Bonus",
            "Computer Empathy Bonus",
            "Ordered Mind Bonus",
            "Standard DNA Pattern Bonus",
            "Killer Instinct Bonus",
            "Deft Hands Bonus",
            "Structural Understanding Bonus",
            "Creative Bonus",
            "Glib Tongue Bonus",
            "August Demeanor Bonus",
            "Superior Motion Sense Bonus",
            "High-G Tolerance Bonus",
            "Vector Reckoning Bonus",
            "Stratum Form Feel Bonus",
            "Doctrine Ingrained Bonus",
            "Three Dimensional Thinking Bonus",
            "Swift Neural Grafting Bonus",
            "Booster Immunity Bonus",
            "Algiophobia Bonus",
            "Barophobia Bonus",
            "Cenophobia Bonus",
            "Claustrophobia Bonus",
            "Monophobia Bonus",
            "Mysophobia Bonus",
            "Taphephobia Bonus",
            "Xenophobia Bonus",
            "Mechanical Inaptitude Bonus",
            "Weak Double-helix Bond Bonus",
            "Short Attention Span Bonus",
            "Wasteful Bonus",
            "Trigger-happy Bonus",
            "Epileptic Bonus",
            "Strong Immunity System Bonus",
            "Amarr Military Academy Pilot Bonus",
            "Amarr Military Academy Gunner Bonus",
            "Amarr Technical School Engineering Bonus",
            "Amarr Technical School Electronics Bonus",
            "Amarr Business School Commerce Bonus",
            "Amarr Business School Industry Bonus",
            "Caldari Military Academy Pilot Bonus",
            "Caldari Military Academy Gunner Bonus",
            "Caldari Technical School Engineering Bonus",
            "Caldari Technical School Electronics Bonus",
            "Caldari Business School Commerce Bonus",
            "Caldari Business School Industry Bonus",
            "Gallente Military Academy Pilot Bonus",
            "Gallente Military Academy Gunner Bonus",
            "Gallente Technical School Engineering Bonus",
            "Gallente Technical School Electronics Bonus",
            "Gallente Business School Commerce Bonus",
            "Gallente Business School Industry Bonus",
            "Minmatar Military Academy Pilot Bonus",
            "Minmatar Military Academy Gunner Bonus",
            "Minmatar Technical School Engineering Bonus",
            "Minmatar Technical School Electronic Bonus",
            "Minmatar Business School Commerce Bonus",
            "Minmatar Business School Industry Bonus",
            "Bounty Hunter Bonus",
            "Scientist Bonus",
            "Industrialist Bonus",
            "Corporate Magnate Bonus",
            "Covert-op Bonus",
            "Navy Captain Bonus",
            "\'Basic\' EM Shield Amplifier",
            "\'Basic\' Thermal Shield Amplifier",
            "\'Basic\' Kinetic Shield Amplifier",
            "\'Basic\' Explosive Shield Amplifier",
            "EM Shield Amplifier I",
            "EM Shield Amplifier I Blueprint",
            "Scourge Auto-Targeting Light Missile I",
            "Scourge Auto-Targeting Light Missile I Blueprint",
            "Nova Auto-Targeting Light Missile I",
            "Nova Auto-Targeting Light Missile I Blueprint",
            "Inferno Auto-Targeting Light Missile I",
            "Inferno Auto-Targeting Light Missile I Blueprint",
            "Scourge Auto-Targeting Heavy Missile I",
            "Scourge Auto-Targeting Heavy Missile I Blueprint",
            "Mjolnir Auto-Targeting Heavy Missile I",
            "Mjolnir Auto-Targeting Heavy Missile I Blueprint",
            "Nova Auto-Targeting Heavy Missile I",
            "Nova Auto-Targeting Heavy Missile I Blueprint",
            "Inferno Auto-Targeting Heavy Missile I",
            "Inferno Auto-Targeting Heavy Missile I Blueprint",
            "Scourge Auto-Targeting Cruise Missile I",
            "Scourge Auto-Targeting Cruise Missile I Blueprint",
            "Mjolnir Auto-Targeting Cruise Missile I",
            "Mjolnir Auto-Targeting Cruise Missile I Blueprint",
            "Nova Auto-Targeting Cruise Missile I",
            "Nova Auto-Targeting Cruise Missile I Blueprint",
            "Inferno Auto-Targeting Cruise Missile I",
            "Inferno Auto-Targeting Cruise Missile I Blueprint",
            "Ship Scanner II",
            "Ship Scanner II Blueprint",
            "Rapid Light Missile Launcher I",
            "Rapid Light Missile Launcher I Blueprint",
            "Rapid Light Missile Launcher II",
            "Rapid Light Missile Launcher II Blueprint",
            "\'Basic\' Heat Sink",
            "Concord Police Frigate",
            "Concord SWAT Frigate",
            "Concord Army Frigate",
            "Concord Special Ops Frigate",
            "Concord Police Cruiser",
            "Concord Police Battleship",
            "Concord Special Ops Battleship",
            "Concord SWAT Battleship",
            "Concord Army Battleship",
            "Amarr Station Hub",
            "Amarr Station Military",
            "Amarr Industrial Station",
            "Amarr Standard Station",
            "Amarr Mining Station",
            "Amarr Research Station",
            "Amarr Trade Post",
            "Bestower",
            "Bestower Blueprint",
            "Basic RADAR Backup Array",
            "ECCM - Radar I",
            "Magnetometric ECM I",
            "\'Basic\' Signal Amplifier",
            "\'Basic\' Tracking Enhancer",
            "Sensor Booster II",
            "Gravimetric ECM I",
            "Radar ECM I",
            "Multispectral ECM I",
            "Ladar ECM I",
            "ECCM Projector I",
            "ECCM Projector II",
            "Remote Sensor Booster I",
            "Remote Sensor Booster II",
            "Remote Sensor Dampener I",
            "Remote Sensor Dampener II",
            "Sensor Booster I",
            "Tracking Computer I",
            "Tracking Computer II",
            "Basic Ladar Backup Array",
            "Basic Gravimetric Backup Array",
            "Basic Magnetometric Backup Array",
            "Basic Multi Sensor Backup Array",
            "Signal Amplifier I",
            "Signal Amplifier II",
            "Tracking Enhancer I",
            "Tracking Enhancer II",
            "Cynosural Suppression",
            "ECCM - Ladar I",
            "ECCM - Magnetometric I",
            "ECCM - Gravimetric I",
            "ECCM - Omni I",
            "Omen",
            "Omen Blueprint",
            "Cynosural Navigation",
            "Supercapital Construction Facilities",
            "Rebel Leader",
            "Prison Facility",
            "Terrorist Leader",
            "Hostages",
            "Planet (Oceanic)",
            "Planet (Lava)",
            "Planet (Barren)",
            "Planet (Storm)",
            "Medium Cap Battery I",
            "Medium Cap Battery I Blueprint",
            "Large Cap Battery I",
            "Large Cap Battery I Blueprint",
            "X-Large Capacitor Battery I",
            "X-Large Capacitor Battery I Blueprint",
            "Medium Capacitor Booster II",
            "Medium Capacitor Booster II Blueprint",
            "Pirate Detection Array 1",
            "Pirate Detection Array 2",
            "Pirate Detection Array 3",
            "Pirate Detection Array 4",
            "Pirate Detection Array 5",
            "Entrapment Array 1",
            "Cap Recharger II",
            "Cap Recharger II Blueprint",
            "Entrapment Array 2",
            "Entrapment Array 3",
            "Entrapment Array 4",
            "Entrapment Array 5",
            "Cargo Scanner II",
            "Cargo Scanner II Blueprint",
            "Ore Prospecting Array 1",
            "Ore Prospecting Array 2",
            "Ore Prospecting Array 3",
            "Ore Prospecting Array 4",
            "Ore Prospecting Array 5",
            "SARO Frigate",
            "Damage Control I",
            "Damage Control I Blueprint",
            "Damage Control II",
            "Damage Control II Blueprint",
            "Gistum C-Type Multispectrum Shield Hardener",
            "Mercenary Trainee",
            "Survey Networks 1",
            "Survey Networks 2",
            "Survey Networks 3",
            "Survey Networks 4",
            "Survey Networks 5",
            "Quantum Flux Generator 1",
            "Quantum Flux Generator 2",
            "Quantum Flux Generator 3",
            "Quantum Flux Generator 4",
            "Quantum Flux Generator 5",
            "Planet (Plasma)",
            "EVE Gate",
            "Patrikia Noirild\'s Reaper",
            "Karsten Lundham\'s Typhoon",
            "Station (InterBus)",
            "Anire Scarlet",
            "Microorganisms",
            "Zazzmatazz",
            "Consolidated Holdings Commander Access Key",
            "Gate Key",
            "Amarr Frigate Container",
            "Zephyr",
            "Genolution Core Augmentation CA-1",
            "Prototype Iris Probe Launcher",
            "Kidnapped Citizens",
            "Caldari Supercarrier Wreckage",
            "Amarr Supercarrier Wreckage",
            "Phenod\'s Broke-Ass Destroyer",
            "Phenod\'s DNA",
            "Gallente Supercarrier Wreckage",
            "Minmatar Supercarrier Wreckage",
            "Remote Tracking Computer I",
            "Remote Tracking Computer II",
            "Amarr Carrier Wreckage",
            "Caldari Carrier Wreckage",
            "Gallente Carrier Wreckage",
            "Tracking Disruptor I",
            "Tracking Disruptor II",
            "Minmatar Carrier Wreckage",
            "Amarr Freighter Wreckage",
            "Caldari Freighter Wreckage",
            "Gallente Freighter Wreckage",
            "Minmatar Freighter Wreckage",
            "Amarr Dreadnought Wreckage",
            "Caldari Dreadnought Wreckage",
            "Burst Jammer II",
            "Burst Jammer II Blueprint",
            "Gallente Dreadnought Wreckage",
            "Minmatar Dreadnought Wreckage",
            "Amarr Titan Wreckage",
            "Caldari Titan Wreckage",
            "Gallente Titan Wreckage",
            "Minmatar Titan Wreckage",
            "Anakism",
            "Amarr Diplomat Quarters",
            "Locced\'s Destroyer",
            "Limited Barren Command Center",
            "Standard Barren Command Center",
            "Improved Barren Command Center",
            "Advanced Barren Command Center",
            "Elite Barren Command Center",
            "Limited Gas Command Center",
            "Standard Gas Command Center",
            "Improved Gas Command Center",
            "Advanced Gas Command Center",
            "Elite Gas Command Center",
            "Limited Ice Command Center",
            "Standard Ice Command Center",
            "Improved Ice Command Center",
            "Advanced Ice Command Center",
            "Elite Ice Command Center",
            "Limited Lava Command Center",
            "Standard Lava Command Center",
            "Improved Lava Command Center",
            "Advanced Lava Command Center",
            "Elite Lava Command Center",
            "Limited Oceanic Command Center",
            "Standard Oceanic Command Center",
            "Improved Oceanic Command Center",
            "Advanced Oceanic Command Center",
            "Elite Oceanic Command Center",
            "Limited Plasma Command Center",
            "Standard Plasma Command Center",
            "Improved Plasma Command Center",
            "Advanced Plasma Command Center",
            "Elite Plasma Command Center",
            "Limited Storm Command Center",
            "Standard Storm Command Center",
            "Crucifier",
            "Crucifier Blueprint",
            "CONCORD Collection Vessel",
            "Haunter Cruise Missile",
            "Infiltrator I",
            "Infiltrator I Blueprint",
            "Infiltrator II",
            "Infiltrator II Blueprint",
            "Guristas Nova XL Cruise Missile",
            "Sansha Wrath Cruise Missile Blueprint",
            "Guristas Scourge XL Cruise Missile",
            "Minmatar Diplomat Quarters",
            "Guristas Inferno XL Cruise Missile",
            "Hammerhead I",
            "Hammerhead I Blueprint",
            "Hammerhead II",
            "Hammerhead II Blueprint",
            "Orca Container",
            "Guristas Mjolnir XL Cruise Missile",
            "Drone Infested Dominix",
            "Renyn Meten",
            "Antem Neo",
            "The Kundalini Manifest",
            "Praetor I",
            "Praetor I Blueprint",
            "Praetor II",
            "Praetor II Blueprint",
            "Environmentally-friendly Mining Equipment",
            "Crate of Environmentally-friendly Mining Equipment",
            "Prototype Body Armor Fabric",
            "Crate of Prototype Body Armor Fabric",
            "Riot Interdiction Team",
            "Riot Interdiction Teams",
            "Acolyte I",
            "Acolyte I Blueprint",
            "Acolyte II",
            "Acolyte II Blueprint",
            "Vylade Dien",
            "Uitra Telen",
            "Arnon Epithalamus",
            "Banshee Torpedo",
            "Sansha Juggernaut Torpedo Blueprint",
            "Ghost Heavy Missile",
            "Ghost Heavy Missile Blueprint",
            "Guard Post",
            "Amarr TIL-1A Nexus Chips",
            "Crate of Amarr TIL-1A Nexus Chips",
            "Preacher",
            "Locced\'s Bribe",
            "Large Group of Civilian Workers and Dependents",
            "Civilian Workers and Dependents",
            "Manportable Electromagnetic Pulse Weapons",
            "Scions of the Superior Gene",
            "Preacher\'s Quarters",
            "Tolmak\'s Zealots",
            "Sisters of EVE Negotiator",
            "Life pod",
            "Customs Office",
            "Sansha\'s Battletower",
            "Oura Madusaari",
            "Harroken Ikero",
            "Fajah Ateshi",
            "Neurowave Pattern Scanner",
            "Roden Station",
            "Temperate Command Center",
            "Temperate Launchpad",
            "Ice Storage Facility",
            "ECCM - Omni II",
            "ECCM - Gravimetric II",
            "ECCM - Ladar II",
            "ECCM - Magnetometric II",
            "ECCM - Radar II",
            "Planetary Launch Container",
            "Base Metals",
            "Aqueous Liquids",
            "Noble Metals",
            "Heavy Metals",
            "Link",
            "Multispectrum Shield Hardener II",
            "Multispectrum Shield Hardener II Blueprint",
            "Megathron (Roden)",
            "Dominix (Roden)",
            "Planktic Colonies",
            "Complex Organisms",
            "Carbon Compounds",
            "Explosive Shield Hardener I",
            "Explosive Shield Hardener I Blueprint",
            "Kinetic Shield Hardener I",
            "Kinetic Shield Hardener I Blueprint",
            "EM Shield Hardener I",
            "EM Shield Hardener I Blueprint",
            "Thermal Shield Hardener I",
            "Thermal Shield Hardener I Blueprint",
            "Explosive Shield Hardener II",
            "Explosive Shield Hardener II Blueprint",
            "Kinetic Shield Hardener II",
            "Kinetic Shield Hardener II Blueprint",
            "EM Shield Hardener II",
            "EM Shield Hardener II Blueprint",
            "Thermal Shield Hardener II",
            "Thermal Shield Hardener II Blueprint",
            "Autotrophs",
            "Non-CS Crystals",
            "Felsic Magma",
            "Suspended Plasma",
            "Ionic Solutions",
            "Noble Gas",
            "Reactive Gas",
            "Supertensile Plastics",
            "Oxides",
            "Test Cultures",
            "Polyaramids",
            "Microfiber Shielding",
            "Water-Cooled CPU",
            "Biocells",
            "Shield Power Relay I",
            "Shield Power Relay I Blueprint",
            "Survey Scanner II",
            "Survey Scanner II Blueprint",
            "Mysterious Probe",
            "Passive Targeter II",
            "Passive Targeter II Blueprint",
            "Condensates",
            "Camera Drones",
            "Synthetic Synapses",
            "Gel-Matrix Biopaste",
            "Supercomputers",
            "Smartfab Units",
            "Nuclear Reactors",
            "Neocoms",
            "Small Hull Repairer II",
            "Small Hull Repairer II Blueprint",
            "Biotech Research Reports",
            "Industrial Explosives",
            "Hermetic Membranes",
            "Heat Sink I",
            "Heat Sink II",
            "Hazmat Detection Systems",
            "Cryoprotectant Solution",
            "Broken Organic Mortar Applicators",
            "Broken Sterile Conduits",
            "Serpentis Initiate",
            "Broken Nano-Factory",
            "Angel Rogue",
            "Broken Self-Harmonizing Power Core",
            "Broken Recursive Computing Module",
            "Broken Broadcast Node",
            "Broken Integrity Response Drones",
            "Broken Wetware Mainframe",
            "Mysterious Shuttle",
            "Serpentis Spy",
            "Serpentis Chief Spy",
            "Guristas Arrogator",
            "Guristas Invader",
            "Guristas Imputor",
            "Guristas Despoiler",
            "Guristas Plunderer",
            "Guristas Silencer",
            "Plasmoids",
            "Electrolytes",
            "Oxidizing Compound",
            "Bacteria",
            "Proteins",
            "Biofuels",
            "Industrial Fibers",
            "Reactive Metals",
            "Precious Metals",
            "Toxic Metals",
            "Chiral Structures",
            "Advanced Planetology",
            "Light Missile Launcher II",
            "Light Missile Launcher II Blueprint",
            "Planetology",
            "The Terminus Stream",
            "Barren Aqueous Liquid Extractor",
            "Heavy Missile Launcher II",
            "Heavy Missile Launcher II Blueprint",
            "Temperate Aqueous Liquid Extractor",
            "Storm Aqueous Liquid Extractor",
            "Oceanic Aqueous Liquid Extractor",
            "Ice Aqueous Liquid Extractor",
            "Gas Aqueous Liquid Extractor",
            "Plasma Suspended Plasma Extractor",
            "Lava Suspended Plasma Extractor",
            "Storm Suspended Plasma Extractor",
            "Torpedo Launcher II",
            "Torpedo Launcher II Blueprint",
            "Storm Ionic Solutions Extractor",
            "Ice Noble Gas Extractor",
            "Gas Ionic Solutions Extractor",
            "Storm Noble Gas Extractor",
            "Gas Noble Gas Extractor",
            "Gas Reactive Gas Extractor",
            "Lava Base Metals Extractor",
            "Plasma Base Metals Extractor",
            "Barren Base Metals Extractor",
            "Storm Base Metals Extractor",
            "Ice Microorganisms Extractor",
            "Gas Base Metals Extractor",
            "Plasma Noble Metals Extractor",
            "Barren Noble Metals Extractor",
            "Wasp II",
            "Wasp II Blueprint",
            "Ice Planktic Colonies Extractor",
            "Lava Heavy Metals Extractor",
            "Plasma Heavy Metals Extractor",
            "Ice Heavy Metals Extractor",
            "Lava Non-CS Crystals Extractor",
            "Plasma Non-CS Crystals Extractor",
            "Ogre I",
            "Ogre I Blueprint",
            "Ogre II",
            "Ogre II Blueprint",
            "Lava Felsic Magma Extractor",
            "Barren Microorganisms Extractor",
            "Temperate Microorganisms Extractor",
            "Oceanic Microorganisms Extractor",
            "Oceanic Planktic Colonies Extractor",
            "Temperate Complex Organisms Extractor",
            "Hobgoblin I",
            "Hobgoblin I Blueprint",
            "Hobgoblin II",
            "Hobgoblin II Blueprint",
            "Oceanic Complex Organisms Extractor",
            "Barren Carbon Compounds Extractor",
            "Temperate Carbon Compounds Extractor",
            "Oceanic Carbon Compounds Extractor",
            "Temperate Autotrophs Extractor",
            "Nanites",
            "Hornet I",
            "Hornet I Blueprint",
            "Hornet II",
            "Hornet II Blueprint",
            "Fortified Drone Structure II",
            "Lava Basic Industry Facility",
            "Lava Advanced Industry Facility",
            "Plasma Basic Industry Facility",
            "Plasma Advanced Industry Facility",
            "Barren Basic Industry Facility",
            "Barren Advanced Industry Facility",
            "Barren High-Tech Production Plant",
            "Berserker I",
            "Berserker I Blueprint",
            "Berserker II",
            "Berserker II Blueprint",
            "Temperate Advanced Industry Facility",
            "Temperate Basic Industry Facility",
            "Temperate High-Tech Production Plant",
            "Storm Basic Industry Facility",
            "Storm Advanced Industry Facility",
            "Oceanic Advanced Industry Facility",
            "Warrior I",
            "Warrior I Blueprint",
            "Warrior II",
            "Warrior II Blueprint",
            "Oceanic Basic Industry Facility",
            "Ice Advanced Industry Facility",
            "Gas Basic Industry Facility",
            "Ice Basic Industry Facility",
            "Gas Advanced Industry Facility",
            "Interplanetary Consolidation",
            "Minmatar Hub",
            "Minmatar Industrial Station",
            "Minmatar Military Station",
            "Minmatar Mining Station",
            "Minmatar Research Station",
            "Minmatar Station",
            "Minmatar Trade Post",
            "Command Center Upgrades",
            "Mjolnir Torpedo",
            "Mjolnir Torpedo Blueprint",
            "Nova Torpedo",
            "Nova Torpedo Blueprint",
            "Inferno Torpedo",
            "Inferno Torpedo Blueprint",
            "Mjolnir Rocket",
            "Mjolnir Rocket Blueprint",
            "Inferno Rocket",
            "Inferno Rocket Blueprint",
            "Nova Rocket",
            "Nova Rocket Blueprint",
            "Barren Command Center",
            "Oceanic Command Center",
            "QA SpaceAnchor",
            "Explosive Shield Amplifier I",
            "Explosive Shield Amplifier I Blueprint",
            "Explosive Shield Amplifier II",
            "Explosive Shield Amplifier II Blueprint",
            "Ice Command Center",
            "Gas Command Center",
            "Oceanic Storage Facility",
            "Gas Storage Facility",
            "Thermal Shield Amplifier I",
            "Thermal Shield Amplifier I Blueprint",
            "Thermal Shield Amplifier II",
            "Thermal Shield Amplifier II Blueprint",
            "Barren Storage Facility",
            "Oceanic Launchpad",
            "Gas Launchpad",
            "Barren Launchpad",
            "Kinetic Shield Amplifier I",
            "Kinetic Shield Amplifier I Blueprint",
            "Kinetic Shield Amplifier II",
            "Kinetic Shield Amplifier II Blueprint",
            "Lava Command Center",
            "Storm Command Center",
            "Plasma Command Center",
            "Ice Launchpad",
            "EM Shield Amplifier II",
            "EM Shield Amplifier II Blueprint",
            "Lava Launchpad",
            "Plasma Launchpad",
            "Storm Launchpad",
            "Lava Storage Facility",
            "Ladar ECM II",
            "Plasma Storage Facility",
            "Storm Storage Facility",
            "Temperate Storage Facility",
            "Magnetometric ECM II",
            "Multispectral ECM II",
            "Gravimetric ECM II",
            "The Solitaire"});
            this.cbPreisvergleichItem.Location = new System.Drawing.Point(80, 8);
            this.cbPreisvergleichItem.Margin = new System.Windows.Forms.Padding(1);
            this.cbPreisvergleichItem.Name = "cbPreisvergleichItem";
            this.cbPreisvergleichItem.Size = new System.Drawing.Size(323, 21);
            this.cbPreisvergleichItem.TabIndex = 24;
            // 
            // lblPreisvergleichMarktZwei
            // 
            this.lblPreisvergleichMarktZwei.AutoSize = true;
            this.lblPreisvergleichMarktZwei.Location = new System.Drawing.Point(396, 93);
            this.lblPreisvergleichMarktZwei.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPreisvergleichMarktZwei.Name = "lblPreisvergleichMarktZwei";
            this.lblPreisvergleichMarktZwei.Size = new System.Drawing.Size(41, 13);
            this.lblPreisvergleichMarktZwei.TabIndex = 23;
            this.lblPreisvergleichMarktZwei.Text = "label12";
            // 
            // lblPreisvergleichMarktEins
            // 
            this.lblPreisvergleichMarktEins.AutoSize = true;
            this.lblPreisvergleichMarktEins.Location = new System.Drawing.Point(9, 93);
            this.lblPreisvergleichMarktEins.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPreisvergleichMarktEins.Name = "lblPreisvergleichMarktEins";
            this.lblPreisvergleichMarktEins.Size = new System.Drawing.Size(41, 13);
            this.lblPreisvergleichMarktEins.TabIndex = 22;
            this.lblPreisvergleichMarktEins.Text = "label11";
            // 
            // cbPreisvergleichMarktZwei
            // 
            this.cbPreisvergleichMarktZwei.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPreisvergleichMarktZwei.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPreisvergleichMarktZwei.FormattingEnabled = true;
            this.cbPreisvergleichMarktZwei.Location = new System.Drawing.Point(80, 53);
            this.cbPreisvergleichMarktZwei.Name = "cbPreisvergleichMarktZwei";
            this.cbPreisvergleichMarktZwei.Size = new System.Drawing.Size(323, 21);
            this.cbPreisvergleichMarktZwei.TabIndex = 21;
            this.cbPreisvergleichMarktZwei.SelectedIndexChanged += new System.EventHandler(this.cbPreisvergleichMarktZwei_SelectedIndexChanged);
            // 
            // cbPreisvergleichMarktEins
            // 
            this.cbPreisvergleichMarktEins.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPreisvergleichMarktEins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPreisvergleichMarktEins.FormattingEnabled = true;
            this.cbPreisvergleichMarktEins.Location = new System.Drawing.Point(80, 30);
            this.cbPreisvergleichMarktEins.Name = "cbPreisvergleichMarktEins";
            this.cbPreisvergleichMarktEins.Size = new System.Drawing.Size(323, 21);
            this.cbPreisvergleichMarktEins.TabIndex = 20;
            this.cbPreisvergleichMarktEins.SelectedIndexChanged += new System.EventHandler(this.cbPreisvergleichMarktEins_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 56);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Zweiter Markt:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Erster Markt:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Item:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(396, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "label12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(816, 439);
            this.Name = "Form1";
            this.Text = "[GEMEC] Taschenmesser";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbLogistikRechnerBelohnung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbLogistikRechnerVersicherung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbLogistikRechnerGesamtkubik)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogistikRechnerCalculate;
        private System.Windows.Forms.TextBox txtLogistikRechnerTransportItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLogistikRechnerBelohnung;
        private System.Windows.Forms.TextBox txtLogistikRechnerVersicherung;
        private System.Windows.Forms.TextBox txtLogistikRechnerGesamtkubikmeter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picbLogistikRechnerBelohnung;
        private System.Windows.Forms.PictureBox picbLogistikRechnerVersicherung;
        private System.Windows.Forms.PictureBox picbLogistikRechnerGesamtkubik;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnPreisvergleichVergleich;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbPreisvergleichMarktZwei;
        private System.Windows.Forms.ComboBox cbPreisvergleichMarktEins;
        private System.Windows.Forms.Label lblPreisvergleichMarktZwei;
        private System.Windows.Forms.Label lblPreisvergleichMarktEins;
        private System.Windows.Forms.ComboBox cbPreisvergleichItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}

