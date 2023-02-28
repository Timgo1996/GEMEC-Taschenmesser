using GEMEC_Logistics.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        List<EvEValues> eveItemValueIDs = new List<EvEValues>();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            setValuesToZero();

            if (txtLogistikRechnerTransportItems.Text != "")
            {
               if (getValuesForTextboxes() == false)
                {
                    MessageBox.Show("Daten konnten nicht ausgewertet werden. Bitte füge einen korrekten Datensatz ein!", "Daten nicht korrekt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    setValuesToZero() ;
                }
            } else
            {
                setValuesToZero();
                MessageBox.Show("Trag was beim Transport ein du Depp!","Transport Items fehlen",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtLogistikRechnerBelohnung.Text = gesamtBelohnung.ToString();
            txtLogistikRechnerGesamtkubikmeter.Text = gesamtKubikmeter.ToString();
            txtLogistikRechnerVersicherung.Text = gesamtVersicherung.ToString();
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
                    else
                    {
                        return false;
                    }

                }

                if (gesamtKubikmeter >= 335000)
                {
                    decimal transportGrenzenDifferenz = gesamtKubikmeter - 335000;
                    MessageBox.Show("Die maximale Transportkapazität beträgt 335000m³. Deine liegt bei " + gesamtKubikmeter.ToString() + "m³ und übersteigt diese mit " + transportGrenzenDifferenz.ToString() + "m³.", "Transportkapazitätslimit überschritten", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    setValuesToZero();
                    return true;
                }
                gesamtBelohnung = gesamtKubikmeter * 400;
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        private void setValuesToZero()
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
            getEvEValueList();
        }

        private void getEvEValueList()
        {
            eveItemValueIDs = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "typeids.csv")).Select(itm => EvEValues.FromCsv(itm)).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getItemPrice();
        }

        private async void getItemPrice()
        {
            List<int> searchItemIDs = await getItemIDsByItemName();

            if (searchItemIDs.Count != 0)
            {
                //TODO: Nur zum testen hinzugefügt. Muss gelöscht werden!!!!
                searchItemIDs.Add(256);

                EvEMarketerAPI eveMarketerInstance = new EvEMarketerAPI();
                try
                {
                    await eveMarketerInstance.getItemPricesAsync(searchItemIDs);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
                
            }
            
        }

        private async Task<List<int>> getItemIDsByItemName()
        {
            List<int> itemIDs = new List<int>();

            var result = eveItemValueIDs.Where(itm => itm.itemName == txtPreisvergleichItem.Text);
            
            foreach ( var item in result )
            {
                itemIDs.Add(item.typeID);
            }

            return itemIDs;
        }
    }

    public class EvEValues
    {
        public int ID { get; set; }
        public string itemName { get; set; }
        public int typeID { get; set; }

        public static EvEValues FromCsv(string csvLine)
        {
            string[] stringSeparators = new string[] { "\",\"" };
            string[] values = csvLine.Split(stringSeparators, StringSplitOptions.None);
            EvEValues itemInfos = new EvEValues();
            itemInfos.ID = Convert.ToInt32(values[0].Replace("\"", ""));
            itemInfos.itemName = Convert.ToString(values[1].Replace("\"", ""));
            itemInfos.typeID = Convert.ToInt32(values[2].Replace("\"", ""));

            return itemInfos;
        }
    }
}
