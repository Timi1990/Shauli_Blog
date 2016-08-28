using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace shuli_blog.Models
{
    public class Fan {
        public enum Gender
        {
            MALE,
            FEMALE
        }
   
        public Fan(int id, string fname, string lname, DateTime bday, int years)
        {
            this.ID = id;
            this.FirstName = fname;
            this.LastName = lname;
            this.Birthday = bday;
            this.years = years;
        }
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
        private Gender gender;
        
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