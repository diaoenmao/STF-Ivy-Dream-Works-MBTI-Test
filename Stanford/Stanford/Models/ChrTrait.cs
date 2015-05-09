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
        public int Id { get; set; }
        public string name { get; set; }
        public string jobsStr { get; set; }

        public ChrTrait(int Id, string name, string jobsStr)
        {
            this.Id = Id;
            this.name = name;
            this.jobsStr = jobsStr;
        }

        public ChrTrait() {}

    }
}