using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    /*
            Fuar alanındaki salonları temsil eden class.
     */
    public class Saloon:BaseEntity
    {
        public string SaloonName { get; set; }

        //Relational Properties

        public virtual List<Stand> Stands { get; set; }
        public virtual List<SaloonClient> SaloonClients { get; set; }
    }
}
