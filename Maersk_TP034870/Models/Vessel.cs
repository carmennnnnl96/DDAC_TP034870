using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Maersk_TP034870.Models
{
    public class Vessel
    {
        public int id { get; set; }

        [Display(Name = "Vessel")]
        [Required]
        public string BVesselname { get; set; }

        [Display(Name = "Classification")]
        [StringLength(3)]
        [Required]
        public string Bclassi { get; set; }

        
        [Display(Name = "Weight (KG)")]
       
        [Required]
        public int weight { get; set; }

        [Display(Name = "From")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime fromdate { get; set; }


        [Display(Name = "To")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime todate { get; set; }


        
        



       

    }

}