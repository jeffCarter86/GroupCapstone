using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Mowerman.Models
{
    public class TimeClock


    {
        public int Id { get; set; }

        [Display(Name = "Team")]
        public string Team { get; set; }

        [Display(Name = "Job Address")]
        public string JobAddress { get; set; }

        [Display(Name = "Zip Code")]
        //[RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Zip")]
        [Required(ErrorMessage = "Zip Code is Required")]
        public string ZipCode { get; set; }
        
        [Display(Name = "Clock-In Time")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? ClockIn { get; set; }

        [Display(Name = "Clock-Out Time")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? ClockOut { get; set; }

        [Display(Name = "Current Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Date { get; set; }

        [Display(Name = "Job Duration")]
        
        public int Duration { get; set; }


    }
}

