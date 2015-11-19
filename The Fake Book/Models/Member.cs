using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace The_Fake_Book.Models
{
    public class Member
    {
        public int ID
        {
            get; set;
        }
        public string Username
        {
            get; set;
        }
        [Display(Name = "Display Name")]
        public string MemberName
        {
            get; set;
        }
        [Display(Name = "Date Joined")]
        public DateTime DateJoined
        {
            get; set;
        }
        [Display(Name = "Last Login")]
        public DateTime LastLogin
        {
            get; set;
        }
        public int ProfileID
        {
            get; set;
        }
        public virtual Profile Profile
        {
            get; set;
        }
        public int MemberID
        {
            get; set;
        }
        public virtual Friend Friend
        {
            get; set;
        }
        public int MessageID
        {
            get; set;
        }
        public virtual Message Message
        {
            get; set;
        }
    }
}