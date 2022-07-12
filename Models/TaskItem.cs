using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task1.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string taskdescription { get; set; }
        public int taskpriority { get; set; }
        public string taskstatus { get; set; }
        public int customerid { get; set; }

    }
}
