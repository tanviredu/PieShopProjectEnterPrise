using System;
using System.Collections.Generic;
using System.Text;

namespace PieShop.Models
{
    public class Email
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public string ToAddress { get; set; }
    }
}
