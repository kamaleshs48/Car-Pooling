﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace GreenCabV1.Models
{
    public class DailyCabModels
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Official { get; set; }
        [Required]
        public string MobileNo { get; set; }
        [Required]
        public string Source { get; set; }
        [Required]
        public string Destination { get; set; }
        [Required]
        public string ReachingHour { get; set; }
        [Required]
        public string ReachingMinute { get; set; }
        [Required]
        [DefaultValue("Hour")]
        public string DepartureHour { get; set; }
        [Required]
        public string DepartureMinute { get; set; }
        [Required]
        public string EstimatedCast { get; set; }
        [Required]
        public string Sex { get; set; }
        [Required]
        public string NoOfSeat { get; set; }
    }


    public class CarporateCarpoolModels
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(11)]
        public string Phone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Organization { get; set; }
        [Required]
        public string NoOfEmployee { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Comments { get; set; }
    }

}
