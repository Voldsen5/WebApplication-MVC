using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_MVC.Models
{
    public class HomeModel
    {
        public HomeModel(string _name, int _age, DateTime _birthday) 
        {
            name = _name;
            age = _age;
            birthday = _birthday;
        }

        public string name { get; set; }
        public int age { get; set; }
        public DateTime birthday { get; set; }
    }
}