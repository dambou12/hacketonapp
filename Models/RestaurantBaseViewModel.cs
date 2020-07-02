using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SmartBookingApp.Models
{
    public class RestaurantBaseViewModel
    {
        //Restaurant, Breakfast, Bistro and Bakeries
        [Key]
        public int RestaurantId { get; set; }

        [Display(Name = "Coordinator who looks after the Restaurants")]
        public string Coordinator { get; set; }

        [Required, StringLength(50)]
        [Display(Name = "Restaurant Name")]
        public string Name { get; set; }

        [Required, StringLength(50)]
        [Display(Name = "Adress")]
        public string location { get; set; }

        [Display(Name = "Restaurant image (cover art)")]
        public string UrlAlbum { get; set; }

    }
}