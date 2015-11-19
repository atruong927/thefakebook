using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace The_Fake_Book.Models
{
    public class Message
    {
        public int MessageID
        {
            get; set;
        }
        public string MessageText
        {
            get; set;
        }
        [Display(Name = "Date Sent")]
        public DateTime DateSent
        {
            get; set;
        }
        public Boolean MessageRead
        {
            get; set;
        }
        public int ThreadID
        {
            get; set;
        }

    }
}