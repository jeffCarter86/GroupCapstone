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
        
        [Display(Name = "Job Address")]
        public string JobAddress { get; set; }

        [Display(Name = "Zip Code")]
        //[RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Zip")]
        [Required(ErrorMessage = "Zip Code is Required")]
        public string ZipCode { get; set; }
        
        [Display(Name = "Clock-In Time")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? ClockIn { get; set; }

        [Display(Name = "Clock-Out Time")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? ClockOut { get; set; }



        [NotMapped]
        public IEnumerable<Customer> Employees { get; set; }
        public IEnumerable<Customer> Operations { get; set; }
    }
}

