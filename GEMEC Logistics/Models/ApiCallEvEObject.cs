using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEMEC_Logistics.Models
{
    public class Buy
    {
        public string volume { get; set; }
        public string avg { get; set; }
        public string stddev { get; set; }
        public string median { get; set; }
        public string percentile { get; set; }
        public string max { get; set; }
        public string min { get; set; }
    }

    public class ExecApi
    {
        [JsonProperty("@version")]
        public string version { get; set; }

        [JsonProperty("@method")]
        public string method { get; set; }
        public Marketstat marketstat { get; set; }
    }

    public class Marketstat
    {
        public List<Type> type { get; set; }
    }

    public class RootEvEItem
    {
        [JsonProperty("?xml")]
        public Xml xml { get; set; }
        public ExecApi exec_api { get; set; }
    }

    public class Sell
    {
        public string volume { get; set; }
        public string avg { get; set; }
        public string stddev { get; set; }
        public string median { get; set; }
        public string percentile { get; set; }
        public string max { get; set; }
        public string min { get; set; }
    }

    public class Type
    {
        [JsonProperty("@id")]
        public string id { get; set; }
        public Buy buy { get; set; }
        public Sell sell { get; set; }
    }

    public class Xml
    {
        [JsonProperty("@version")]
        public string version { get; set; }

        [JsonProperty("@encoding")]
        public string encoding { get; set; }
    }

}
