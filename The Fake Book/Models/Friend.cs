using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace The_Fake_Book.Models
{
    public class Friend
    {
        public int MemberID
        {
            get; set;
        }
        [Display(Name = "Date Friended")]
        public DateTime DateFriended
        {
            get; set;
        }
    }
}