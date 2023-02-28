using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEMEC_Logistics.Models
{
    public class EvEItem
    {
        public EvEMarketstat marketstat;
    }

    public class EvEMarketstat
    {
        public EvEType type;
    }
    public class EvEType
    {
        public EvEBuy buy;
        public EvESell sell;
    }

    public class EvEBuy
    {
        public string volume;
        public string avg;
        public string stddev;
        public string median;
        public string percentile;
        public string max;
        public string min;
    }

    public class EvESell
    {
        public string volume;
        public string avg;
        public string stddev;
        public string median;
        public string percentile;
        public string max;
        public string min;
    }
}
