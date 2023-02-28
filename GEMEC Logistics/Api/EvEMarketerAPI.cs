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
using System.Xml;

namespace GEMEC_Logistics
{
    public class EvEMarketerAPI
    {
        static HttpClient client = new HttpClient();

        public async Task<bool> setBaseValues()
        {
            //Set base information
            client.BaseAddress = new Uri($"https://api.evemarketer.com/ec/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="TypeIDs">Type ID's of the item to search the price for</param>
        /// <param name="Usesystem">Standard Value for Jita</param>
        public async Task<RootEvEItem> getItemPricesAsync(List<int> TypeIDs, int Usesystem = 30000142)
        {
            await setBaseValues();
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

            return JsonConvert.DeserializeObject<RootEvEItem>(jsonString);
        }

    }
}
