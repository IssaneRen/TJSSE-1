using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TJSSESU_Website.Models
{
    public class ExecuteTask
    {
        public int taskID { get; set; }
        public string SID { get; set; }
        public int executeStatement { get; set; }

        [ForeignKey("taskID")]
        public virtual Task task { get; set; }
        [ForeignKey("SID")]
        public virtual User user { get; set; }
    }
}