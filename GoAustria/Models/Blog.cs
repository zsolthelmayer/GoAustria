using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GoAustria.Models
{
    public class Blog
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { set; get; }

        [Required, StringLength(50)]
        public string Author { set; get; }

        [Required, StringLength(50)]
        public string Title { set; get; }

        [Required]
        public string Content { set; get; }
       
        public bool Active { set; get; }
    }
}