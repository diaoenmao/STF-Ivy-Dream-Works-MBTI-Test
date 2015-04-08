using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stanford.Models
{
    public class Question
    {
        public int Id { get; set; }
        public String Q { get; set; }
        public String A { get; set; }
        public String B { get; set; }
        public Question(String Q, String A, String B)
        {
            this.Q = Q;
            this.A = A;
            this.B = B;
        }

        public Question(){}

    }
}