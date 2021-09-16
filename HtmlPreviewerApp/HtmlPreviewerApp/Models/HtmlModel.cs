using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HtmlPreviewerApp.Models
{
    public class HtmlModel
    {
        public string HtmlSample { get; set; }

        [Key]
        public int SampleID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastEditDate { get; set; }
        public string Title { get; set; }
        //public bool IsNew { get; set; }
    }
}
