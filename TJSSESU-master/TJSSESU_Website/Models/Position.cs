using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TJSSESU_Website.Models
{
    public class Position
    {
        [Key]
        public string posName { get; set; }
        //区分等级
        public int Sclass { get; set; }

        public ICollection<User> users { get; set; }
    }
}