using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Order:BaseEntity
    {
        /*
            Fuar organizasyon firmasının aldığı siparişleri temsil eden class.
         */
        public decimal UnitPrice { get; set; }
        public int ClientID  { get; set; }
        public int StandID { get; set; }

        //Relational Properties
        public virtual Client Client { get; set; }
        public virtual Stand Stand { get; set; }
    }
}
