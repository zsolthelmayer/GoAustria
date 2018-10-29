using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GoAustria.Models
{
    public class Link
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        
        public int Sequence { set; get; }

       
        public String Title { set; get; }

       
        public String Url { set; get; }
    }
}