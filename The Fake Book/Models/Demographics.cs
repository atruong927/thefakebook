using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace The_Fake_Book.Models
{
    public class Demographics
    {
        public int DemographicsID
        {
            get; set;
        }
        public string City
        {
            get; set;
        }
        public string State
        {
            get; set;
        }
        public string Country
        {
            get; set;
        }
        [Display(Name = "Birth Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime BirthDate
        {
            get; set;
        }
        public string Gender
        {
            get; set;
        }
    }
}