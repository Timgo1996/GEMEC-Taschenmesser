using GEMEC_Logistics.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GEMEC_Logistics
{
    public class EvEMarketerAPI
    {
        static HttpClient client;

        public void setBaseValues()
        {
            //Set base information
            client = new HttpClient();
            client.Timeout = TimeSpan.FromSeconds(30);
            client.BaseAddress = new Uri($"https://api.evemarketer.com/ec/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        /// <summary>
        /// Get multiple items with price informations
        /// </summary>
        /// <param name="TypeIDs">Type ID's of the item to search the price for</param>
        /// <param name="Usesystem">Standard Value for Jita</param>
        /// <returns></returns>
        public async Task<GEMEC_Logistics.Models.MultipleItems.RootEvEItem> getMultipleItemPricesAsync(List<int> TypeIDs, int Usesystem = 30000142)
        {
            setBaseValues();
            string buildedURI = client.BaseAddress.ToString();

            buildedURI += $"/marketstat?typeid=";
            for (int i = 0; i < TypeIDs.Count - 1; i++)
            {
                buildedURI += TypeIDs[i].ToString() + ",";
            }
            buildedURI += TypeIDs[TypeIDs.Count - 1].ToString() + $"&usesystem=" + Usesystem.ToString();

            var response = await client.GetStringAsync(buildedURI);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(response);
            string jsonString = JsonConvert.SerializeXmlNode(doc);

            return JsonConvert.DeserializeObject<GEMEC_Logistics.Models.MultipleItems.RootEvEItem>(jsonString);
        }


        /// <summary>
        /// Get single item with price informations
        /// </summary>
        /// <param name="TypeIDs">Type ID's of the item to search the price for</param>
        /// <param name="Usesystem">Standard Value for Jita</param>
        /// <returns></returns>
        public async Task<GEMEC_Logistics.Models.SingleItem.RootEvEItem> getSingleItemPricesAsync(List<int> TypeIDs, int Usesystem = 30000142)
        {
            setBaseValues();
            string buildedURI = client.BaseAddress.ToString();

            buildedURI += $"/marketstat?typeid=";
            for (int i = 0; i < TypeIDs.Count - 1; i++)
            {
                buildedURI += TypeIDs[i].ToString() + ",";
            }
            buildedURI += TypeIDs[TypeIDs.Count - 1].ToString() + $"&usesystem=" + Usesystem.ToString();

            //TODO: Nur zum Testen verwenden um API aufrufen zu können:
            //if (MessageBox.Show("test", "Visit", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            //{
            //    System.Diagnostics.Process.Start(buildedURI);
            //}

            var response = await client.GetStringAsync(buildedURI);
            
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(response);
            string jsonString = JsonConvert.SerializeXmlNode(doc);

            return JsonConvert.DeserializeObject<GEMEC_Logistics.Models.SingleItem.RootEvEItem>(jsonString);
        }

    }
}
