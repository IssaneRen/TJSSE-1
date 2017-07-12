using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace TJSSESU_Website.Models
{
    public class Department
    {
        [Key]
        public string deptName { get; set; }
        public int capacity { get; set; }
        public string introduction { get; set; }

        public virtual ICollection<User> user { get; set; }
    }
}