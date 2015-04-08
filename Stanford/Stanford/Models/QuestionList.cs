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
            qlist.Add(new Question("假如你是一位老师，你会选教", "以事实为主的课程", "涉及理论的课程"));
            qlist.Add(new Question("你通常", "与人容易混熟", "比较沉静或矜持"));
            qlist.Add(new Question("一般来说，你和哪些人比较合得来？", "富于想象力的人", "现实的人"));
            qlist.Add(new Question("你是否经常让", "你的情感支配你的理智", "你的理智主宰你的情感"));
            qlist.Add(new Question("处理许多事情上，你会喜欢", "凭兴所至行事", "按照计划行事"));
            qlist.Add(new Question("你是否", "容易让人了解", "难于让人了解"));
            qlist.Add(new Question("按照程序表做事", "合你心意", "令你感到束缚"));
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
        public List<Question> getList()
        {
            return qlist;
        }
    }
}