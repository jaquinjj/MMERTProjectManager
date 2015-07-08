using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMERT.MODEL
{
    public class Tasks
    {
        public int ID { get; set; }
        public string TASKNAME { get; set; }
        public string TASKDATE { get; set; }
        public string TASKNOTE { get; set; }
        public string TASKSTATE { get; set; }
        public string TASKTYPE { get; set; }        
        public int ProjectId { get; set; }
    }
}
