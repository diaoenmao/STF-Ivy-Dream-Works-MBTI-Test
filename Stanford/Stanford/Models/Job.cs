using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Stanford.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stanford.Models
{
    public class Job
    {
        [Key]
        public String Job_Id { get; set; }
        public String majorsStr { get; set; }
        //public List<Major> majors { get; set; }
        public Job(String name, String majorsStr)
        {
            this.Job_Id = name;
            this.majorsStr = majorsStr;
        }

        public Job() { }
    }
}