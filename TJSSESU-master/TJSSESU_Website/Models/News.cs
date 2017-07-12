using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TJSSESU_Website.Models
{
    public class News
    {
        [Key]
        public int newsID { get; set; }
        public DateTime publishDate { get; set; }
        public string newsTitle { get; set; }
        public string context { get; set; }
        public string pictureUrl { get; set; }
        public string SID { get; set; }

        [ForeignKey("SID")]
        public virtual User user { get; set; }
    }
}