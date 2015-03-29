using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stanford.Models
{
    public class QuestionList
    {
        public int Id { get; set; }
        public List<Question> qlist { get; set; } 
        public QuestionList()
        {
            qlist = new List<Question>();
            qlist.Add(new Question("当你要外出一整天，你会", "计划你要做什么和在什么时候做", "说去就去"));
            qlist.Add(new Question("你认为自己是一个", "较为随兴所至的人", "较为有条理的人"));
        }
        public String getQ(int idx)
        {
            return qlist[idx].Q;
        }
        public String getA(int idx)
        {
            return qlist[idx].A;
        }
        public String getB(int idx)
        {
            return qlist[idx].B;
        }
    }
}