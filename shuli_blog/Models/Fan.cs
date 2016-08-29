using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        
       
        [Required]
        [Display(Name = "ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "firstName")]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "LastName")]
        public string LastName { get; set; }


        [DisplayFormat(NullDisplayText = "No gender")]
        public Gender gender { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Bday")]
        public DateTime Bday { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Seniority")]
        public int Seniority { get; set; }
    } 
}