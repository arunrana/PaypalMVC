using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaypalMVC.Models
{
    public class Register
    {
        public string Username { get; set;}
        public string Password { get; set;}
        public string Firstname { get; set;}
        public string Lastname { get; set;}
        public string EmailId { get; set;}
    }
}