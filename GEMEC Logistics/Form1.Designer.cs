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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtTransportItems = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBelohnung = new System.Windows.Forms.TextBox();
            this.txtVersicherung = new System.Windows.Forms.TextBox();
            this.txtGesamtkubikmeter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.picbBelohnung = new System.Windows.Forms.PictureBox();
            this.picbVersicherung = new System.Windows.Forms.PictureBox();
            this.picbGesamtkubik = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picbBelohnung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbVersicherung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbGesamtkubik)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(829, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Items für den Transport (max. 335.000m³):";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(728, 524);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(471, 85);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Berechne Transport";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtTransportItems
            // 
            this.txtTransportItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTransportItems.Location = new System.Drawing.Point(37, 80);
            this.txtTransportItems.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtTransportItems.Multiline = true;
            this.txtTransportItems.Name = "txtTransportItems";
            this.txtTransportItems.Size = new System.Drawing.Size(1796, 426);
            this.txtTransportItems.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 665);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 51);
            this.label2.TabIndex = 3;
            this.label2.Text = "Belohnung:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 743);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 51);
            this.label3.TabIndex = 4;
            this.label3.Text = "Versicherung:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 821);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 51);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gesamt m³:";
            // 
            // txtBelohnung
            // 
            this.txtBelohnung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBelohnung.Enabled = false;
            this.txtBelohnung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBelohnung.Location = new System.Drawing.Point(471, 658);
            this.txtBelohnung.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtBelohnung.Name = "txtBelohnung";
            this.txtBelohnung.Size = new System.Drawing.Size(723, 56);
            this.txtBelohnung.TabIndex = 6;
            this.txtBelohnung.Text = "0";
            // 
            // txtVersicherung
            // 
            this.txtVersicherung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVersicherung.Enabled = false;
            this.txtVersicherung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVersicherung.Location = new System.Drawing.Point(471, 736);
            this.txtVersicherung.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtVersicherung.Name = "txtVersicherung";
            this.txtVersicherung.Size = new System.Drawing.Size(723, 56);
            this.txtVersicherung.TabIndex = 7;
            this.txtVersicherung.Text = "0";
            // 
            // txtGesamtkubikmeter
            // 
            this.txtGesamtkubikmeter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGesamtkubikmeter.Enabled = false;
            this.txtGesamtkubikmeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGesamtkubikmeter.Location = new System.Drawing.Point(471, 814);
            this.txtGesamtkubikmeter.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtGesamtkubikmeter.Name = "txtGesamtkubikmeter";
            this.txtGesamtkubikmeter.Size = new System.Drawing.Size(335, 56);
            this.txtGesamtkubikmeter.TabIndex = 8;
            this.txtGesamtkubikmeter.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1213, 665);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 51);
            this.label5.TabIndex = 9;
            this.label5.Text = "ISK";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1213, 743);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 51);
            this.label6.TabIndex = 10;
            this.label6.Text = "ISK";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(826, 821);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 51);
            this.label7.TabIndex = 11;
            this.label7.Text = "m³";
            // 
            // picbBelohnung
            // 
            this.picbBelohnung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picbBelohnung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbBelohnung.Image = ((System.Drawing.Image)(resources.GetObject("picbBelohnung.Image")));
            this.picbBelohnung.Location = new System.Drawing.Point(387, 651);
            this.picbBelohnung.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.picbBelohnung.Name = "picbBelohnung";
            this.picbBelohnung.Size = new System.Drawing.Size(70, 67);
            this.picbBelohnung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbBelohnung.TabIndex = 12;
            this.picbBelohnung.TabStop = false;
            this.picbBelohnung.Click += new System.EventHandler(this.picbBelohnung_Click);
            this.picbBelohnung.MouseLeave += new System.EventHandler(this.picbBelohnung_MouseLeave);
            this.picbBelohnung.MouseHover += new System.EventHandler(this.picbBelohnung_MouseHover);
            // 
            // picbVersicherung
            // 
            this.picbVersicherung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picbVersicherung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbVersicherung.Image = ((System.Drawing.Image)(resources.GetObject("picbVersicherung.Image")));
            this.picbVersicherung.Location = new System.Drawing.Point(387, 729);
            this.picbVersicherung.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.picbVersicherung.Name = "picbVersicherung";
            this.picbVersicherung.Size = new System.Drawing.Size(70, 67);
            this.picbVersicherung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbVersicherung.TabIndex = 13;
            this.picbVersicherung.TabStop = false;
            this.picbVersicherung.Click += new System.EventHandler(this.picbVersicherung_Click);
            this.picbVersicherung.MouseLeave += new System.EventHandler(this.picbVersicherung_MouseLeave);
            this.picbVersicherung.MouseHover += new System.EventHandler(this.picbVersicherung_MouseHover);
            // 
            // picbGesamtkubik
            // 
            this.picbGesamtkubik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picbGesamtkubik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbGesamtkubik.Image = ((System.Drawing.Image)(resources.GetObject("picbGesamtkubik.Image")));
            this.picbGesamtkubik.Location = new System.Drawing.Point(387, 808);
            this.picbGesamtkubik.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.picbGesamtkubik.Name = "picbGesamtkubik";
            this.picbGesamtkubik.Size = new System.Drawing.Size(70, 67);
            this.picbGesamtkubik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbGesamtkubik.TabIndex = 14;
            this.picbGesamtkubik.TabStop = false;
            this.picbGesamtkubik.Click += new System.EventHandler(this.picbGesamtkubik_Click);
            this.picbGesamtkubik.MouseLeave += new System.EventHandler(this.picbGesamtkubik_MouseLeave);
            this.picbGesamtkubik.MouseHover += new System.EventHandler(this.picbGesamtkubik_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1867, 892);
            this.Controls.Add(this.picbGesamtkubik);
            this.Controls.Add(this.picbVersicherung);
            this.Controls.Add(this.picbBelohnung);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGesamtkubikmeter);
            this.Controls.Add(this.txtVersicherung);
            this.Controls.Add(this.txtBelohnung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTransportItems);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.MinimumSize = new System.Drawing.Size(1867, 882);
            this.Name = "Form1";
            this.Text = "[GEMEC] Logistics V1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbBelohnung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbVersicherung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbGesamtkubik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtTransportItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBelohnung;
        private System.Windows.Forms.TextBox txtVersicherung;
        private System.Windows.Forms.TextBox txtGesamtkubikmeter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picbBelohnung;
        private System.Windows.Forms.PictureBox picbVersicherung;
        private System.Windows.Forms.PictureBox picbGesamtkubik;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

