using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TJSSESU_Website.Models
{
    public class File
    {
        [Key]
        public int fileID { get; set; }
        public string fileName { get; set; }
        public string addressString { get; set; }
        public int fatherID { get; set; }

        public virtual ICollection<File> children { get; set; }
        [ForeignKey("fatherID")]
        public virtual File fatherFile { get; set; }

    }
}