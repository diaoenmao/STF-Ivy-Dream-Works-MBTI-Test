using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stanford.Models
{
    public class Major
    {
        public int Id { get; set; }
        public String name { get; set; }

        public Major(String name)
        {
            this.name = name;
        }

        public Major() { }
    }
}