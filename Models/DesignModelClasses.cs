﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SmartBookingApp.Models
{
    // Add your design model classes below

    // Follow these rules or conventions:

    // To ease other coding tasks, the name of the integer identifier property should be "Id"
    // Collection properties (including navigation properties) must be of type ICollection<T>
    // Valid data annotations are pretty much limited to [Required] and [StringLength(n)]
    // Required to-one navigation properties must include the [Required] attribute
    // Do NOT configure scalar properties (e.g. int, double) with the [Required] attribute
    // Initialize DateTime and collection properties in a default constructor

    public class RoleClaim
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }
    }

    public class Restaurant
    {
        public int RestaurantId { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }
    }


    public class MusicAndEntertainment
    {
        public int MusicAndEntertainmentId { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }
    }

    public class HealthAndBeauty
    {
        public int HealthAndBeautyId { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }
    }

}
