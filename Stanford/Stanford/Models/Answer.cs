using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stanford.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public int answer { get; set; }
        public Answer(String answer)
        {
            if (answer != null)
            {
                this.answer = Int32.Parse(answer);
            }
        }
        public int getAnswer()
        {
            return answer;
        }
    }
}