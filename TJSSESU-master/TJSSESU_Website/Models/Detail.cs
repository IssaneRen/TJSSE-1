using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TJSSESU_Website.Models
{
    public class Detail
    {
        [Key]
        public string SID { get; set; }
        public string personal_introduction { get; set; }
        //学生班级
        public int sClass { get; set; }
        public int age { get; set; }
        public DateTime birthDate { get; set; }
        public string nameOfBirth { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }

        [ForeignKey("SID")]
        public virtual User user { get; set; }
    }
}