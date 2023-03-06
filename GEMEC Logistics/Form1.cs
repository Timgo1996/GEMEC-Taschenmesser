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
                lblBuyOne.Text = "Kauf (" + marktItemInfos[0].exec_api.marketstat.type.buy.volume.ToString() + ")";
                lblPreisvergleichBuyAvgOne.Text = marktItemInfos[0].exec_api.marketstat.type.buy.avg.ToString();
                lblPreisvergleichBuyStddevOne.Text = marktItemInfos[0].exec_api.marketstat.type.buy.stddev.ToString();
                lblPreisvergleichBuyMedianOne.Text = marktItemInfos[0].exec_api.marketstat.type.buy.median.ToString();
                lblPreisvergleichBuyPercentileOne.Text = marktItemInfos[0].exec_api.marketstat.type.buy.percentile.ToString();
                lblPreisvergleichBuyMaxOne.Text = marktItemInfos[0].exec_api.marketstat.type.buy.max.ToString();
                lblPreisvergleichBuyMinOne.Text = marktItemInfos[0].exec_api.marketstat.type.buy.min.ToString();

                lblSellOne.Text = "Verkauf (" + marktItemInfos[0].exec_api.marketstat.type.buy.volume.ToString() + ")";
                lblPreisvergleichSellAvgOne.Text = marktItemInfos[0].exec_api.marketstat.type.sell.avg.ToString().Replace(".", ",");
                lblPreisvergleichSellStddevOne.Text = marktItemInfos[0].exec_api.marketstat.type.sell.stddev.ToString().Replace(".", ",");
                lblPreisvergleichSellMedianOne.Text = marktItemInfos[0].exec_api.marketstat.type.sell.median.ToString().Replace(".", ",");
                lblPreisvergleichSellPercentileOne.Text = marktItemInfos[0].exec_api.marketstat.type.sell.percentile.ToString().Replace(".", ",");
                lblPreisvergleichSellMaxOne.Text = marktItemInfos[0].exec_api.marketstat.type.sell.max.ToString().Replace(".", ",");
                lblPreisvergleichSellMinOne.Text = marktItemInfos[0].exec_api.marketstat.type.sell.min.ToString().Replace(".", ",");



                //Markt Zwei mit Daten befüllen:
                lblBuySecond.Text = "Kauf (" + marktItemInfos[1].exec_api.marketstat.type.buy.volume.ToString() + ")";
                lblPreisvergleichBuyAvgSecond.Text = marktItemInfos[1].exec_api.marketstat.type.buy.avg.ToString().Replace(".", ",");
                lblPreisvergleichBuyStddevSecond.Text = marktItemInfos[1].exec_api.marketstat.type.buy.stddev.ToString().Replace(".", ",");
                lblPreisvergleichBuyMedianSecond.Text = marktItemInfos[1].exec_api.marketstat.type.buy.median.ToString().Replace(".", ",");
                lblPreisvergleichBuyPercentileSecond.Text = marktItemInfos[1].exec_api.marketstat.type.buy.percentile.ToString().Replace(".", ",");
                lblPreisvergleichBuyMaxSecond.Text = marktItemInfos[1].exec_api.marketstat.type.buy.max.ToString().Replace(".", ",");
                lblPreisvergleichBuyMinSecond.Text = marktItemInfos[1].exec_api.marketstat.type.buy.min.ToString().Replace(".", ",");

                lblSellSecond.Text = "Verkauf (" + marktItemInfos[1].exec_api.marketstat.type.buy.volume.ToString() + ")";
                lblPreisvergleichSellAvgSecond.Text = marktItemInfos[1].exec_api.marketstat.type.sell.avg.ToString().Replace(".", ",");
                lblPreisvergleichSellStddevSecond.Text = marktItemInfos[1].exec_api.marketstat.type.sell.stddev.ToString().Replace(".", ",");
                lblPreisvergleichSellMedianSecond.Text = marktItemInfos[1].exec_api.marketstat.type.sell.median.ToString().Replace(".", ",");
                lblPreisvergleichSellPercentileSecond.Text = marktItemInfos[1].exec_api.marketstat.type.sell.percentile.ToString().Replace(".", ",");
                lblPreisvergleichSellMaxSecond.Text = marktItemInfos[1].exec_api.marketstat.type.sell.max.ToString().Replace(".", ",");
                lblPreisvergleichSellMinSecond.Text = marktItemInfos[1].exec_api.marketstat.type.sell.min.ToString().Replace(".", ",");
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

                if (rootEvEItems.Count != null)
                {
                    foreach (var item in rootEvEItems)
                    {
                        //TODO: Hier Daten aufbereiten
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
                            myObject.intQuantity = Convert.ToInt32(itemValues[1]);
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
