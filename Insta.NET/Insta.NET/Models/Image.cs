using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InstaDOTNET.Models
{
    public class Image
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please provide a title for the image")]
        [Display(Name = "Title")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please provide a username for the image")]
        [Display(Name = "Username")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Please provide a caption for the image")]
        [Display(Name = "Caption")]
        public string Caption { get; set; }

        [Display(Name = "Image Link")]
        public string URL { get; set; }
    }
}
