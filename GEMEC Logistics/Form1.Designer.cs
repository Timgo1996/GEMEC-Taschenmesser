﻿namespace GEMEC_Logistics
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPreisvergleichItem = new System.Windows.Forms.TextBox();
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
            this.btnPreisvergleichVergleich.Location = new System.Drawing.Point(6, 100);
            this.btnPreisvergleichVergleich.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnPreisvergleichVergleich.Name = "btnPreisvergleichVergleich";
            this.btnPreisvergleichVergleich.Size = new System.Drawing.Size(134, 26);
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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
            this.tabPage1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage1.Size = new System.Drawing.Size(792, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LogistikRechner";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtPreisvergleichItem);
            this.tabPage2.Controls.Add(this.btnPreisvergleichVergleich);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage2.Size = new System.Drawing.Size(792, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Preisvergleich";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(403, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Zweiter Markt:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 37);
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
            // txtPreisvergleichItem
            // 
            this.txtPreisvergleichItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreisvergleichItem.Location = new System.Drawing.Point(71, 8);
            this.txtPreisvergleichItem.Name = "txtPreisvergleichItem";
            this.txtPreisvergleichItem.Size = new System.Drawing.Size(719, 20);
            this.txtPreisvergleichItem.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(738, 411);
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
        private System.Windows.Forms.TextBox txtPreisvergleichItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

