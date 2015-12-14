using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace The_Fake_Book.Models
{
    public class RegisterMemberViewModel
    {
        public RegisterViewModel RegisterViewModel
        {
            get; set;
        }
        public Member Member
        {
            get; set;
        }
    }
}