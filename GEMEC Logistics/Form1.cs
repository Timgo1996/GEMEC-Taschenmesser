using GEMEC_Logistics.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GEMEC_Logistics
{
    public partial class Form1 : Form
    {

        decimal gesamtBelohnung = 0;
        decimal gesamtKubikmeter = 0;
        decimal gesamtVersicherung = 0;

        List<EvEItemValues> eveItemValueIDs = new List<EvEItemValues>();
        List<EvEStationValues> eveStationValueIDs = new List<EvEStationValues>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            setPreisvergleichValuesToZero();

            if (txtLogistikRechnerTransportItems.Text != "")
            {
                if (getValuesForTextboxes() == false)
                {
                    MessageBox.Show("Daten konnten nicht ausgewertet werden. Bitte füge einen korrekten Datensatz ein!", "Daten nicht korrekt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    setPreisvergleichValuesToZero();
                }
            }
            else
            {
                setPreisvergleichValuesToZero();
                MessageBox.Show("Trag was beim Transport ein du Depp!", "Transport Items fehlen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtLogistikRechnerBelohnung.Text = gesamtBelohnung.ToString().Replace(",", ".");
            txtLogistikRechnerGesamtkubikmeter.Text = gesamtKubikmeter.ToString().Replace(",", ".");
            txtLogistikRechnerVersicherung.Text = gesamtVersicherung.ToString().Replace(",", ".");
        }

        private bool getValuesForTextboxes()
        {
            string[] items = txtLogistikRechnerTransportItems.Lines.ToArray();
            string seperator = "\t";

            try
            {
                foreach (string item in items)
                {
                    string[] itemValues = item.Split(seperator.ToCharArray());
                    itemValues = itemValues.Where(x => !string.IsNullOrEmpty(x)).ToArray();

                    if (itemValues.Length == 0)
                    {
                        return false;
                    }


                    if (itemValues[itemValues.Length - 1].Contains("ISK") && itemValues[itemValues.Length - 2].Contains("m3"))
                    {
                        gesamtVersicherung += decimal.Parse(itemValues[itemValues.Length - 1].Replace("ISK", ""));
                        gesamtKubikmeter += decimal.Parse(itemValues[itemValues.Length - 2].Replace("m3", ""));
                    }
                    else if (itemValues[itemValues.Length - 1].Contains("m3") && itemValues[1].EndsWith("Blueprint*"))
                    {
                        MessageBox.Show("Die Blueprint " + itemValues[0] + " wurde erkannt. Diese wird nicht mit in die Berechnung für die Versicherungssume berücksichtigt da Sie keinen geschätzen Preis hat. Der Preis für die Versicherung muss ggf. manuell auf auf die Versicherung aufberechnet werden.", "Blueprint ohne Preis erkannt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        return false;
                    }

                }

                if (gesamtKubikmeter >= 335000)
                {
                    decimal transportGrenzenDifferenz = gesamtKubikmeter - 335000;
                    MessageBox.Show("Die maximale Transportkapazität beträgt 335000m³. Deine liegt bei " + gesamtKubikmeter.ToString() + "m³ und übersteigt diese mit " + transportGrenzenDifferenz.ToString() + "m³.", "Transportkapazitätslimit überschritten", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    setPreisvergleichValuesToZero();
                    return true;
                }
                gesamtBelohnung = gesamtKubikmeter * 300;
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        private void setPreisvergleichValuesToZero()
        {
            gesamtBelohnung = 0;
            gesamtKubikmeter = 0;
            gesamtVersicherung = 0;
        }

        private void picbBelohnung_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtLogistikRechnerBelohnung.Text);
        }

        private void picbVersicherung_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtLogistikRechnerVersicherung.Text);
        }

        private void picbGesamtkubik_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtLogistikRechnerGesamtkubikmeter.Text);
        }

        private void setTooltipForItem(string tooltipText, Control controlItem)
        {
            toolTip1.AutoPopDelay = 0;
            toolTip1.InitialDelay = 1;
            toolTip1.ReshowDelay = 0;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(controlItem, tooltipText);
        }

        private void picbBelohnung_MouseHover(object sender, EventArgs e)
        {
            setTooltipForItem("Belohnung kopieren", this.picbLogistikRechnerBelohnung);
        }

        private void picbBelohnung_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.RemoveAll();
        }

        private void picbVersicherung_MouseHover(object sender, EventArgs e)
        {
            setTooltipForItem("Versicherung kopieren", this.picbLogistikRechnerVersicherung);
        }

        private void picbVersicherung_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.RemoveAll();
        }

        private void picbGesamtkubik_MouseHover(object sender, EventArgs e)
        {
            setTooltipForItem("Gesamt Kubikmeter kopieren", this.picbLogistikRechnerGesamtkubik);
        }

        private void picbGesamtkubik_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.RemoveAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getEvECsvData();
        }

        private void getEvECsvData()
        {
            eveItemValueIDs = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Data//typeids.csv")).Select(itm => EvEItemValues.FromCsv(itm)).ToList();
            eveStationValueIDs = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Data//stationids.csv")).Select(itm => EvEStationValues.FromCsv(itm)).ToList();

            foreach (var station in eveStationValueIDs)
            {
                cbPreisvergleichMarktEins.Items.Add(station.stationName);
                cbPreisvergleichMarktZwei.Items.Add(station.stationName);
                cbPreisrechnerMarkt.Items.Add(station.stationName);
            }

            cbPreisvergleichMarktEins.SelectedIndex = 0;
            cbPreisvergleichMarktZwei.SelectedIndex = 1;
            cbPreisrechnerMarkt.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnPreisvergleichVergleich.BackColor = Color.Transparent;
            if (cbPreisvergleichItem.Text != "")
            {
                getPreisvergleichDataToCompare();
            }
            else
            {
                MessageBox.Show("Bitte geben sie ein Item an.");
            }
        }

        private async Task<List<Models.SingleItem.RootEvEItem>> getItemPriceToCompareData(List<int> stationIDs)
        {
            List<int> searchItemIDs = await getItemIDsByItemName();
            List<Models.SingleItem.RootEvEItem> eveItemInfos = new List<Models.SingleItem.RootEvEItem>();
            EvEMarketerAPI eveMarketerInstance = new EvEMarketerAPI();

            if (searchItemIDs.Count != 0 && stationIDs.Count == 2)
            {
                try
                {
                    foreach (var stationID in stationIDs)
                    {
                        eveItemInfos.Add(await eveMarketerInstance.getSingleItemPricesAsync(searchItemIDs, stationID));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            else
            {
                return null;
            }
            return eveItemInfos;
        }

        private async void getPreisvergleichDataToCompare()
        {
            List<int> stationIDs = await getPreisvergleichStationNameByStationID();

            if (stationIDs.Count != 0 && stationIDs != null)
            {
                List<Models.SingleItem.RootEvEItem> marktItemInfos = await getItemPriceToCompareData(stationIDs);

                if (marktItemInfos != null)
                {
                    setItemsToLabels(marktItemInfos);
                }
                else
                {
                    MessageBox.Show("Das angegebene Item konnte nicht gefunden werden!", "Item konnte nicht gefunden werden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ein Fehler ist aufgetreten. Ihre Daten konnten nicht verglichen werden!", "Daten konnten nicht verglichen werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setItemsToLabels(List<Models.SingleItem.RootEvEItem> marktItemInfos)
        {
            try
            {
                //Markt Eins mit Daten befüllen:
                lblBuyOne.Text = "Kauf (" + Convert.ToDecimal(marktItemInfos[0].exec_api.marketstat.type.buy.volume.Replace(".", ",")).ToString("N1") + ")";
                lblPreisvergleichBuyAvgOne.Text = Convert.ToDecimal(marktItemInfos[0].exec_api.marketstat.type.buy.avg.Replace(".", ",")).ToString("N1");
                lblPreisvergleichBuyStddevOne.Text = Convert.ToDecimal(marktItemInfos[0].exec_api.marketstat.type.buy.stddev.Replace(".", ",")).ToString("N1");
                lblPreisvergleichBuyMedianOne.Text = Convert.ToDecimal(marktItemInfos[0].exec_api.marketstat.type.buy.median.Replace(".", ",")).ToString("N1");
                lblPreisvergleichBuyPercentileOne.Text = Convert.ToDecimal(marktItemInfos[0].exec_api.marketstat.type.buy.percentile.Replace(".", ",")).ToString("N1");
                lblPreisvergleichBuyMaxOne.Text = Convert.ToDecimal(marktItemInfos[0].exec_api.marketstat.type.buy.max.Replace(".", ",")).ToString("N1");
                lblPreisvergleichBuyMinOne.Text = Convert.ToDecimal(marktItemInfos[0].exec_api.marketstat.type.buy.min.Replace(".", ",")).ToString("N1");

                lblSellOne.Text = "Verkauf (" + Convert.ToDecimal(marktItemInfos[0].exec_api.marketstat.type.buy.volume.Replace(".", ",")).ToString("N1") + ")";
                lblPreisvergleichSellAvgOne.Text = Convert.ToDecimal(marktItemInfos[0].exec_api.marketstat.type.sell.avg.Replace(".", ",")).ToString("N1");
                lblPreisvergleichSellStddevOne.Text = Convert.ToDecimal(marktItemInfos[0].exec_api.marketstat.type.sell.stddev.Replace(".", ",")).ToString("N1");
                lblPreisvergleichSellMedianOne.Text = Convert.ToDecimal(marktItemInfos[0].exec_api.marketstat.type.sell.median.Replace(".", ",")).ToString("N1");
                lblPreisvergleichSellPercentileOne.Text = Convert.ToDecimal(marktItemInfos[0].exec_api.marketstat.type.sell.percentile.Replace(".", ",")).ToString("N1");
                lblPreisvergleichSellMaxOne.Text = Convert.ToDecimal(marktItemInfos[0].exec_api.marketstat.type.sell.max.Replace(".", ",")).ToString("N1");
                lblPreisvergleichSellMinOne.Text = Convert.ToDecimal(marktItemInfos[0].exec_api.marketstat.type.sell.min.Replace(".", ",")).ToString("N1");



                //Markt Zwei mit Daten befüllen:
                lblBuySecond.Text = "Kauf (" + Convert.ToDecimal(marktItemInfos[1].exec_api.marketstat.type.buy.volume.Replace(".", ",")).ToString("N1") + ")";
                lblPreisvergleichBuyAvgSecond.Text = Convert.ToDecimal(marktItemInfos[1].exec_api.marketstat.type.buy.avg.Replace(".", ",")).ToString("N1");
                lblPreisvergleichBuyStddevSecond.Text = Convert.ToDecimal(marktItemInfos[1].exec_api.marketstat.type.buy.stddev.Replace(".", ",")).ToString("N1");
                lblPreisvergleichBuyMedianSecond.Text = Convert.ToDecimal(marktItemInfos[1].exec_api.marketstat.type.buy.median.Replace(".", ",")).ToString("N1");
                lblPreisvergleichBuyPercentileSecond.Text = Convert.ToDecimal(marktItemInfos[1].exec_api.marketstat.type.buy.percentile.Replace(".", ",")).ToString("N1");
                lblPreisvergleichBuyMaxSecond.Text = Convert.ToDecimal(marktItemInfos[1].exec_api.marketstat.type.buy.max.Replace(".", ",")).ToString("N1");
                lblPreisvergleichBuyMinSecond.Text = Convert.ToDecimal(marktItemInfos[1].exec_api.marketstat.type.buy.min.Replace(".", ",")).ToString("N1");

                lblSellSecond.Text = "Verkauf (" + Convert.ToDecimal(marktItemInfos[1].exec_api.marketstat.type.buy.volume.Replace(".", ",")).ToString("N1") + ")";
                lblPreisvergleichSellAvgSecond.Text = Convert.ToDecimal(marktItemInfos[1].exec_api.marketstat.type.sell.avg.Replace(".", ",")).ToString("N1");
                lblPreisvergleichSellStddevSecond.Text = Convert.ToDecimal(marktItemInfos[1].exec_api.marketstat.type.sell.stddev.Replace(".", ",")).ToString("N1");
                lblPreisvergleichSellMedianSecond.Text = Convert.ToDecimal(marktItemInfos[1].exec_api.marketstat.type.sell.median.Replace(".", ",")).ToString("N1");
                lblPreisvergleichSellPercentileSecond.Text = Convert.ToDecimal(marktItemInfos[1].exec_api.marketstat.type.sell.percentile.Replace(".", ",")).ToString("N1");
                lblPreisvergleichSellMaxSecond.Text = Convert.ToDecimal(marktItemInfos[1].exec_api.marketstat.type.sell.max.Replace(".", ",")).ToString("N1");
                lblPreisvergleichSellMinSecond.Text = Convert.ToDecimal(marktItemInfos[1].exec_api.marketstat.type.sell.min.Replace(".", ",")).ToString("N1");
            }
            catch (Exception)
            {
                //Markt Eins mit Daten befüllen:
                lblBuyOne.Text = "Kauf";
                lblPreisvergleichBuyAvgOne.Text = "...";
                lblPreisvergleichBuyStddevOne.Text = "...";
                lblPreisvergleichBuyMedianOne.Text = "...";
                lblPreisvergleichBuyPercentileOne.Text = "...";
                lblPreisvergleichBuyMaxOne.Text = "...";
                lblPreisvergleichBuyMinOne.Text = "...";

                lblSellOne.Text = "Verkauf";
                lblPreisvergleichSellAvgOne.Text = "...";
                lblPreisvergleichSellStddevOne.Text = "...";
                lblPreisvergleichSellMedianOne.Text = "...";
                lblPreisvergleichSellPercentileOne.Text = "...";
                lblPreisvergleichSellMaxOne.Text = "...";
                lblPreisvergleichSellMinOne.Text = "...";



                //Markt Zwei mit Daten befüllen:
                lblBuySecond.Text = "Kauf";
                lblPreisvergleichBuyAvgSecond.Text = "...";
                lblPreisvergleichBuyStddevSecond.Text = "...";
                lblPreisvergleichBuyMedianSecond.Text = "...";
                lblPreisvergleichBuyPercentileSecond.Text = "...";
                lblPreisvergleichBuyMaxSecond.Text = "...";
                lblPreisvergleichBuyMinSecond.Text = "...";

                lblSellSecond.Text = "Verkauf";
                lblPreisvergleichSellAvgSecond.Text = "...";
                lblPreisvergleichSellStddevSecond.Text = "...";
                lblPreisvergleichSellMedianSecond.Text = "...";
                lblPreisvergleichSellPercentileSecond.Text = "...";
                lblPreisvergleichSellMaxSecond.Text = "...";
                lblPreisvergleichSellMinSecond.Text = "...";
            }
        }

        private async Task<List<int>> getPreisvergleichStationNameByStationID()
        {
            List<int> itemIDs = new List<int>();

            var marktEinsResult = eveStationValueIDs.Where(itm => itm.stationName == cbPreisvergleichMarktEins.Text).FirstOrDefault();
            var marktZweiResult = eveStationValueIDs.Where(itm => itm.stationName == cbPreisvergleichMarktZwei.Text).FirstOrDefault();

            if (marktEinsResult != null && marktZweiResult != null)
            {
                itemIDs.Add(marktEinsResult.ID);
                itemIDs.Add(marktZweiResult.ID);
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie nur eine verfügbare Station aus. Zu mindestens einer deiner ausgewählten Stationen liegen uns keine Daten vor.");
                return null;
            }

            return itemIDs;
        }

        private async Task<List<int>> getItemIDsByItemName()
        {
            List<int> itemIDs = new List<int>();

            var result = eveItemValueIDs.Where(itm => itm.itemName.ToUpper() == cbPreisvergleichItem.Text.ToUpper());

            foreach (var item in result)
            {
                itemIDs.Add(item.typeID);
            }

            return itemIDs;
        }

        private void cbPreisvergleichMarktEins_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPreisvergleichMarktEins.Text = cbPreisvergleichMarktEins.SelectedItem.ToString();
        }

        private void cbPreisvergleichMarktZwei_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPreisvergleichMarktZwei.Text = cbPreisvergleichMarktZwei.SelectedItem.ToString();
        }

        private void cbPreisvergleichItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void pbLogistikRechnerListeLeeren_Click(object sender, EventArgs e)
        {
            txtLogistikRechnerTransportItems.Text = "";
        }

        private void btnPreisrechnerBerechnen_Click(object sender, EventArgs e)
        {
            PreisvergleichDoTheMagic();
        }

        private async void PreisvergleichDoTheMagic()
        {
            if (txtPreisrechnerItems.Text != "")
            {
                List<PreisrechnerCustomObject> rootEvEItems = new List<PreisrechnerCustomObject>();
                rootEvEItems = await PreisrechnerBerechneItemKosten();

                dgvPreisrechner.Rows.Clear();
                dgvPreisrechner.Refresh();

                if (rootEvEItems.Count != null)
                {
                    //Clear old Data Source
                    dgvPreisrechner.DataSource = null;
                    dgvPreisrechner.Rows.Add();

                    decimal kaufGesamtPreisMIN = 0;
                    decimal kaufGesamtPreisAVG = 0;
                    decimal kaufGesamtPreisMAX = 0;
                    decimal verkaufGesamtPreisMIN = 0;
                    decimal verkaufGesamtPreisAVG = 0;
                    decimal verkaufGesamtPreisMAX = 0;

                    foreach (var item in rootEvEItems)
                    {
                        DataGridViewRow singlEvEItemDgvRow = (DataGridViewRow)dgvPreisrechner.Rows[0].Clone();

                        decimal kaufPreisMIN = Convert.ToDecimal(item.rootEvEItemeveItem.exec_api.marketstat.type.buy.min.Replace(".", ",")) * item.intQuantity;
                        decimal kaufPreisAVG = Convert.ToDecimal(item.rootEvEItemeveItem.exec_api.marketstat.type.buy.avg.Replace(".", ",")) * item.intQuantity;
                        decimal kaufPreisMAX = Convert.ToDecimal(item.rootEvEItemeveItem.exec_api.marketstat.type.buy.max.Replace(".", ",")) * item.intQuantity;
                        decimal verkaufPreisMIN = Convert.ToDecimal(item.rootEvEItemeveItem.exec_api.marketstat.type.sell.min.Replace(".", ",")) * item.intQuantity;
                        decimal verkaufPreisAVG = Convert.ToDecimal(item.rootEvEItemeveItem.exec_api.marketstat.type.sell.avg.Replace(".", ",")) * item.intQuantity;
                        decimal verkaufPreisMAX = Convert.ToDecimal(item.rootEvEItemeveItem.exec_api.marketstat.type.sell.max.Replace(".", ",")) * item.intQuantity;

                        kaufGesamtPreisMIN += kaufPreisMIN;
                        kaufGesamtPreisAVG += kaufPreisAVG;
                        kaufGesamtPreisMAX += kaufPreisMAX;
                        verkaufGesamtPreisMIN += verkaufPreisMIN;
                        verkaufGesamtPreisAVG += verkaufPreisAVG;
                        verkaufGesamtPreisMAX += verkaufPreisMAX;

                        singlEvEItemDgvRow.Cells[0].Value = item.stringItemName;
                        singlEvEItemDgvRow.Cells[1].Value = item.intQuantity;
                        singlEvEItemDgvRow.Cells[2].Value = item.rootEvEItemeveItem.exec_api.marketstat.type.buy.min.Replace(".", ",");
                        singlEvEItemDgvRow.Cells[3].Value = item.rootEvEItemeveItem.exec_api.marketstat.type.sell.min.Replace(".", ",");
                        singlEvEItemDgvRow.Cells[4].Value = item.rootEvEItemeveItem.exec_api.marketstat.type.buy.avg.Replace(".", ",");
                        singlEvEItemDgvRow.Cells[5].Value = item.rootEvEItemeveItem.exec_api.marketstat.type.sell.avg.Replace(".", ",");
                        singlEvEItemDgvRow.Cells[6].Value = item.rootEvEItemeveItem.exec_api.marketstat.type.buy.max.Replace(".", ",");
                        singlEvEItemDgvRow.Cells[7].Value = item.rootEvEItemeveItem.exec_api.marketstat.type.sell.max.Replace(".", ",");
                        singlEvEItemDgvRow.Cells[8].Value = kaufPreisMIN;
                        singlEvEItemDgvRow.Cells[9].Value = verkaufPreisMIN;
                        singlEvEItemDgvRow.Cells[10].Value = kaufPreisAVG;
                        singlEvEItemDgvRow.Cells[11].Value = verkaufPreisAVG;
                        singlEvEItemDgvRow.Cells[12].Value = kaufPreisMAX;
                        singlEvEItemDgvRow.Cells[13].Value = verkaufPreisMAX;

                        this.dgvPreisrechner.Rows.Add(singlEvEItemDgvRow);
                    }
                    //Remove first dummy row
                    dgvPreisrechner.Rows.RemoveAt(0);

                    lblPreisrechnerKaufMin.Text = kaufGesamtPreisMIN.ToString("N1");
                    lblPreisrechnerKaufAvg.Text = kaufGesamtPreisAVG.ToString("N1");
                    lblPreisrechnerKaufMax.Text = kaufGesamtPreisMAX.ToString("N1");
                    lblPreisrechnerVerkaufMin.Text = verkaufGesamtPreisMIN.ToString("N1");
                    lblPreisrechnerVerkaufAvg.Text = verkaufGesamtPreisAVG.ToString("N1");
                    lblPreisrechnerVerkaufMax.Text = verkaufGesamtPreisMAX.ToString("N1");

                    // Set your desired AutoSize Mode:
                    for (int i = 0; i < 13; i++)
                    {
                        dgvPreisrechner.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }

                    // Now that DataGridView has calculated it's Widths; we can now store each column Width values.
                    for (int i = 0; i <= dgvPreisrechner.Columns.Count - 1; i++)
                    {
                        // Store Auto Sized Widths:
                        int colw = dgvPreisrechner.Columns[i].Width;

                        // Remove AutoSizing:
                        dgvPreisrechner.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                        // Set Width to calculated AutoSize value:
                        dgvPreisrechner.Columns[i].Width = colw;
                    }
                }
                else
                {
                    MessageBox.Show("Daten konnten nicht ausgewertet werden. Bitte füge einen korrekten Datensatz ein!", "Daten nicht korrekt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bitte fügen Sie Item(s) in die Textbox ein!", "Keine Items eingetragen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async Task<List<PreisrechnerCustomObject>> PreisrechnerBerechneItemKosten()
        {
            List<PreisrechnerCustomObject> rootEvEItems = new List<PreisrechnerCustomObject>();
            string[] items = txtPreisrechnerItems.Lines.ToArray();
            string seperator = "\t";

            try
            {
                int stationID = await PreisrechnerGetStationIDByStationName();
                

                if (stationID != 0)
                {
                    foreach (string item in items)
                    {
                        string[] itemValues = item.Split(seperator.ToCharArray());
                        itemValues = itemValues.Where(x => !string.IsNullOrEmpty(x)).ToArray();

                        if (itemValues.Length == 0)
                        {
                            return null;
                        }
                        PreisrechnerCustomObject myObject = new PreisrechnerCustomObject();
                        myObject.stringItemName = itemValues[0];
                        try
                        {
                            myObject.intQuantity = Convert.ToInt32(itemValues[1].Replace(".",""));
                        }
                        catch (Exception)
                        {
                            myObject.intQuantity = 1;
                        }
                        myObject.rootEvEItemeveItem = await PreisrechnerGetDataToCompare(stationID, itemValues[0].Replace("*", ""));

                        rootEvEItems.Add(myObject);
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
            return rootEvEItems;
        }

        private async Task<Models.SingleItem.RootEvEItem> PreisrechnerGetDataToCompare(int stationID, string searchItemName)
        {
            Models.SingleItem.RootEvEItem marktItemInfos = await PreisrechnerGetItemPriceToCompareData(stationID, searchItemName);

            if (marktItemInfos != null)
            {
                return marktItemInfos;
            }
            else
            {
                MessageBox.Show("Das angegebene Item konnte nicht gefunden werden!", "Item konnte nicht gefunden werden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        private async Task<int> PreisrechnerGetStationIDByStationName()
        {
            int itemIDs = 0;

            var marktResult = eveStationValueIDs.Where(itm => itm.stationName == cbPreisrechnerMarkt.Text).FirstOrDefault();

            if (marktResult != null)
            {
                return marktResult.ID;
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine verfügbare Station aus. Zu deiner ausgewählten Stationen liegen uns keine Daten vor.", "Stationsdaten nicht verfügbar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
        }

        private async Task<Models.SingleItem.RootEvEItem> PreisrechnerGetItemPriceToCompareData(int stationID, string searchItemName)
        {
            int searchItemIDs = await PreisrechnerGetItemIDsByItemName(searchItemName);
            Models.SingleItem.RootEvEItem eveItemInfos = new Models.SingleItem.RootEvEItem();
            EvEMarketerAPI eveMarketerInstance = new EvEMarketerAPI();

                try
                {
                        eveItemInfos = await eveMarketerInstance.PreisrechnerGetSingleItemPriceAsync(searchItemIDs, stationID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            return eveItemInfos;
        }

        private async Task<int> PreisrechnerGetItemIDsByItemName(string itemName)
        {
            var result =  eveItemValueIDs.Where(itm => itm.itemName.ToUpper() == itemName.ToUpper()).FirstOrDefault();
            return Convert.ToInt32(result.ID);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtPreisrechnerItems.Text = "";
        }
    }


    public class EvEItemValues
    {
        public int ID { get; set; }
        public string itemName { get; set; }
        public int typeID { get; set; }

        public static EvEItemValues FromCsv(string csvLine)
        {
            string[] stringSeparators = new string[] { "\",\"" };
            string[] values = csvLine.Split(stringSeparators, StringSplitOptions.None);
            EvEItemValues itemInfos = new EvEItemValues();
            itemInfos.ID = Convert.ToInt32(values[0].Replace("\"", ""));
            itemInfos.itemName = Convert.ToString(values[1].Replace("\"", ""));
            itemInfos.typeID = Convert.ToInt32(values[2].Replace("\"", ""));

            return itemInfos;
        }
    }

    public class EvEStationValues
    {
        public int ID { get; set; }
        public string stationName { get; set; }

        public static EvEStationValues FromCsv(string csvLine)
        {
            string[] stringSeparators = new string[] { "," };
            string[] values = csvLine.Split(stringSeparators, StringSplitOptions.None);
            EvEStationValues stationInfos = new EvEStationValues();
            stationInfos.ID = Convert.ToInt32(values[0]);
            stationInfos.stationName = Convert.ToString(values[1]);

            return stationInfos;
        }
    }

    public struct PreisrechnerCustomObject
    {
        public PreisrechnerCustomObject(int quantity, string itemName, Models.SingleItem.RootEvEItem eveItem)
        {
            intQuantity = quantity;
            stringItemName = itemName;
            rootEvEItemeveItem = eveItem;
        }

        public int intQuantity { get; set; }
        public string stringItemName { get; set; }
        public Models.SingleItem.RootEvEItem rootEvEItemeveItem { get; set; }
    }
}
