using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SmartBookingApp.Models
{
    public class MusicAndEntertainmentBaseViewModel
    {
        //Theatre  //Concerts
        [Key]
        public int Id { get; set; }

        [Display(Name = "Coordinator who looks after the Theatres and Concerts")]
        public string Coordinator { get; set; }
        [Required, StringLength(50)]
        [Display(Name = "Shop Name")]
        public string Name { get; set; }

        [Required, StringLength(50)]
        [Display(Name = "Adress")]
        public string location { get; set; }

        [Display(Name = "Shop image (cover art)")]
        public string UrlAlbum { get; set; }
    }
}