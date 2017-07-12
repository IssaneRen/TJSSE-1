using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TJSSESU_Website.Models
{
    public class Answer
    {
        public string adminID { get; set; }
        public int questionID { get; set; }
        public string answerContext { get; set; }

        [ForeignKey("questionID")]
        public virtual Question question { get; set; }
        [ForeignKey("adminID")]
        public virtual Admin admin { get; set; }
        
    }
}