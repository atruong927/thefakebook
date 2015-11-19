using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace The_Fake_Book.Models
{
    public class Profile
    {
        public int ProfileID
        {
            get; set;
        }
        public string Introduction
        {
            get; set;
        }
        public int InterestID
        {
            get; set;
        }
        public virtual Interest Interest
        {
            get; set;
        }
        public int PhotoID
        {
            get; set;
        }
        public virtual Photo Photo
        {
            get; set;
        }
        public int ID
        {
            get; set;
        }
    }
}