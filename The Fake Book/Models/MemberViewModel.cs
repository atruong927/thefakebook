using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace The_Fake_Book.Models
{
    public class MemberViewModel
    {
        public string Username
        {
            get; set;
        }
        public string MemberName
        {
            get; set;
        }
        public virtual Profile Profile
        {
            get; set;
        }
        public virtual Friend Friend
        {
            get; set;
        }
        public virtual Message Message
        {
            get; set;
        }
    }
}