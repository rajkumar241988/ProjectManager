﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.BusinessEntities
{
    public class TaskEntity
    {
        public int Task_ID { get; set; }
        public Nullable<int> Parent__ID { get; set; }
        public Nullable<int> Project_ID { get; set; }
        public string Task1 { get; set; }
        public System.DateTime Start_Date { get; set; }
        public Nullable<System.DateTime> End_Date { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
    }
}
