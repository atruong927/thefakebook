using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace The_Fake_Book.Models
{
    public class Photo
    {
        public int PhotoID
        {
            get; set;
        }
        [Display(Name = "File Location")]
        public string FileLocation
        {
            get; set;
        }
        public string Description
        {
            get; set;
        }
        [Display(Name = "Date Added")]
        public DateTime DateAdded
        {
            get; set;
        }
        [Display(Name = "Profile Picture")]
        public Boolean ProfilePicture
        {
            get; set;
        }
    }
}