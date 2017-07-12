using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TJSSESU_Website.Models
{
    public class Task
    {
        [Key]
        public int taskID { set; get; }
        public string taskTitle { get; set; }
        public string introduction { get; set; }
        public DateTime publishDate { get; set; }
        public DateTime deadlineDate { get; set; }
        public int executeStatement { get; set; }
        public string SID { get; set; }
        //所属活动标签
        public string tag { get; set; }

        [ForeignKey("SID")]
        public virtual User user { get; set; }
        public virtual ICollection<ExecuteTask> executeTasks { get; set; }
    }
}