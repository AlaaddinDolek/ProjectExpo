using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class SaloonClient:BaseEntity
    {
        public int ClientID { get; set; }
        public int SaloonID { get; set; }

        //Relational Properties

        public virtual Saloon Saloon { get; set; }
        public virtual Client Client { get; set; }
    }
}
