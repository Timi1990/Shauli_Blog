using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace shuli_blog.Models
{
        private enum Gender{
            MALE,
            FEMALE
        }


    public class Fan 
    {

        [Required]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "LastName")]
        public string LastName { get; set; }


        [DisplayFormat(NullDisplayText = "No gender")]
        private Gender Gender { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Birthday")]
        private DateTime Birthday { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "years")]
        private int years;

    } 
}