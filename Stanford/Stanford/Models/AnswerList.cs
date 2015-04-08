using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stanford.Models
{
    public class AnswerList
    {
        public int Id { get; set; }
        public List<Answer> alist { get; set; }
        public AnswerList()
        {
            alist = new List<Answer>();
        }
        public void add(String answer) {
            alist.Add(new Answer(answer));
        }
        public List<Answer> getList()
        {
            return alist;
        }
    }
}