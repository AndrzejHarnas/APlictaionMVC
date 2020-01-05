using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APlictaionMVC.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int age { get; set; } = 0;
        public bool IsAlive { get; set; } = true;

    }
}