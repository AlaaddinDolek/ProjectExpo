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

        public DateTime DueDate { get; set; }

        public int ClientID  { get; set; }

        public int StandID { get; set; }

        public int EmployeeID { get; set; }

        //Relational Properties
        public virtual Client Client { get; set; }

        public virtual Stand Stand { get; set; }

        public virtual  Employee Employee { get; set; }
        public virtual List<ExtraOrder> ExtraOrders { get; set; }
    }
}
