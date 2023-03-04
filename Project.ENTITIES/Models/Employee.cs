using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    // Mevcut siparişlerin kontrolu için  programı kullanan kişiyi temsil etmesi adına açıldı...
	public  class Employee:BaseEntity
	{
        public string UserName { get; set; }

        public string Password { get; set; }

        //Relational Properties

        public virtual List<Order> Orders { get; set; }
    }
}
