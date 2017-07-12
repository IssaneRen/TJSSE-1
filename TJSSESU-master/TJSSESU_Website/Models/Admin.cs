using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TJSSESU_Website.Models
{
    public class Admin
    {
        [Key]
        public string adminID { get; set; }
        public string passWord { get; set; }

        public virtual ICollection<Answer> answers { get; set; }
    }
}