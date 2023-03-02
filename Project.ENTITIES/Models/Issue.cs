﻿using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Issue:BaseEntity
    {
        public string Description { get; set; }
        public IssueNum? Status { get; set; }

        //Relational Properties

        public virtual List<StandIssue> StandIssues { get; set; }
    }
}
