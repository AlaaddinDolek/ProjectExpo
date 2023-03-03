using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    /*
            Müşteri bilgilerinin girildiği class.
     */
    public class ClientProfile:BaseEntity
    {
        public string CompanyAddress { get; set; }
        public string TaxNumber { get; set; }
        public string PhoneNumber { get; set; }

        // Relational Properties
        public virtual Client Client { get; set; }
    }
}
