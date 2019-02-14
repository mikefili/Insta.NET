using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InstaDOTNET.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public int ImageID { get; set; }

        [Required(ErrorMessage = "Please provide a comment")]
        [Display(Name = "Comment")]
        public string CommentString { get; set; }

        // navigation property
        public ICollection<Image> Images { get; set; }
    }
}
