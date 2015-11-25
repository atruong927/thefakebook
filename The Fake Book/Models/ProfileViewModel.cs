using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace The_Fake_Book.Models
{
    public class ProfileViewModel
    {
        public string Introduction
        {
            get; set;
        }
        public virtual Interest Interest
        {
            get; set;
        }
        public virtual Photo Photo
        {
            get; set;
        }
    }
}