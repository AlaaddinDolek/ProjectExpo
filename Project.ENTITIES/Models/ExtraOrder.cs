using Project.ENTITIES.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class ExtraOrder:BaseEntity
    {
        public int OrderID { get; set; }
        public int ExtraID { get; set; }

        //Relational properties

        public virtual Extra    Extra { get; set; }

        public virtual Order Order { get; set; }
    }
}
