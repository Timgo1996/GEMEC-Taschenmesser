using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEMEC_Logistics.Models
{
    public class PreisrechnerModel
    {
        public string ItemName { get; set; }
        public int Menge { get; set; }
        public decimal EinzelpreisVerkauf { get ; set; }
        public decimal EinzelpreisKauf { get; set; }
        public decimal GesamtpreisVerkauf { get; set; }
        public decimal GesamtpreisKauf { get; set; }
    }
}
