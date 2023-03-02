﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Client:BaseEntity
    {
        public string CompanyName { get; set; }


        //Relational Properties

        public virtual List<Stand> Stands { get; set; }
        public virtual List<SaloonClient> SaloonClients { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual ClientProfile Profile { get; set; }

    }
}
