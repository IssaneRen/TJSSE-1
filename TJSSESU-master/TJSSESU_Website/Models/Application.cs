using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TJSSESU_Website.Models
{
    public class Application
    {
        [Key]
        public string SID { get; set; }
        public string firstWill { get; set; }
        public string secondWill { get; set; }
        //小分队
        public Boolean[] unitWill { get; set; }
        public Boolean isSubject { get; set; }
        public Boolean changeMajoirWill { get; set; }
        public string previousPosition { get; set; }
        public string habbit { get; set; }
        public string chooseHabit { get; set; }
        public string chooseReason { get; set;}
        public string workExperiments { get; set; }
        public string expect { get; set; }
    }
}