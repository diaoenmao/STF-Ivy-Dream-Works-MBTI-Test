using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stanford.Models
{
    public class ChrTrait
    {
        public int Id {get; set;}
        public string name { get; set; }
        public List<Major> majors { get; set; }

        public ChrTrait(int Id, string name, List<Major> majors)
        {
            this.Id = Id;
            this.name = name;
            this.majors = majors;
        }

        public ChrTrait() {}

    }
}