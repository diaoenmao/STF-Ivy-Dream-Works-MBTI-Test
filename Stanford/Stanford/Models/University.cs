using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stanford.Models
{
    public class University
    {
        public int Id { get; set; }
        public String name { get; set; }
        public String address { get; set; }
        public String SAT { get; set; }
        public String SATII { get; set; }
        public String ACT { get; set; }
        public String TOEFL { get; set; }
        public String IELTS { get; set; }

        public University(String name, String address, String SAT, String SATII, String ACT, String TOEFL, String IELTS)
        {
            this.name = name;
            this.address = address;
            this.SAT = SAT;
            this.SATII = SATII;
            this.ACT = ACT;
            this.TOEFL = TOEFL;
            this.IELTS = IELTS;
        }

        public University() { }
    }
}