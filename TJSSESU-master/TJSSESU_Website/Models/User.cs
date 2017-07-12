using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TJSSESU_Website.Models
{
    public class User
    {
        [Key]
        public string SID { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string deptName { get; set; }
        public string posName { get; set; }
        
        [ForeignKey("deptName")]
        public virtual Department department { get; set;}
        [ForeignKey("posName")]
        public virtual Position position { get; set; }
        public virtual ICollection<News> news { get; set; }
        public virtual ICollection<Question> questions { get; set; }
        public virtual  ICollection<ExecuteTask> executeTasks { get; set; }
        public virtual ICollection<Task> publishTasks { get; set; }  
    }
}