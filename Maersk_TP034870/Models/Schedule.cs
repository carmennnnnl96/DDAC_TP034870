using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace Maersk_TP034870.Models
{
    public class Schedule
    {

        public int id { get; set; }

        [Display(Name = "Departure Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime deptdate { get; set; }

        [Display(Name = "Departing from:")]
        [Required]
        public string deptfrom { get; set; }



        [Display(Name = "Arrival Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime arrivaldate { get; set; }

        [Display(Name = "Arrive at:")]
        [Required]
        public string arrto { get; set; }


        [Display(Name = "Vessel")]
        [Required]
        public string Vessel { get; set; }

       
}


}