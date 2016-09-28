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

        public string FirstName { get; set; }

        public string LastName { get; set; }


        
        public Gender gender { get; set; }
        
        
        public DateTime Bday { get; set; }

        
        public int Seniority { get; set; }
    } 
}