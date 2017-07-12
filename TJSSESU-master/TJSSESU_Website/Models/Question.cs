using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TJSSESU_Website.Models
{
    public class Question
    {
        [Key]
        public int questionID { get; set; }
        public string SID { get; set; }
        public string title { get; set; }
        public DateTime questionDate { get; set; }
        public string questionText  { get; set; }

        [ForeignKey("SID")]
        public virtual User user { get; set; }
        public virtual ICollection<Answer> answers { get; set; }
    }
}