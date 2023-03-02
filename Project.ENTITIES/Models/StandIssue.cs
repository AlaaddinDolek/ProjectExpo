using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class StandIssue:BaseEntity
    {
        public int StandID { get; set; }
        public int IssueID { get; set; }

        //Relational Properties

        public virtual Stand Stand { get; set; }
        public virtual Issue Issue { get; set; }
    }
}
