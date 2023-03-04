using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    /*
            Fuardaki standları temsil eden class.
     */
    public class Stand:BaseEntity
    {
        public string StandNo { get; set; }
        public string StandArea { get; set; }
        public int? ClientID { get; set; }
        public int? SaloonID { get; set; }
        public Activity ActivityStatus { get; set; }

        //Relational Properties

        public virtual Client Client { get; set; }
        public virtual List<StandIssue> StandIssues { get; set; }
        public virtual Saloon Saloon { get; set; }
        public virtual Order Order { get; set; }

        public override string ToString()
        {
            return $"No:{StandNo} ,{StandArea}";
        }


    }
}
