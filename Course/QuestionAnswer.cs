using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public class QuestionAnswer
    {
        public string Information { get; set; }
        public string Question { get; set; }
        public Answer Answer1 { get; set; }
        public Answer Answer2 { get; set; }
        public Answer Answer3 { get; set; }

        public QuestionAnswer(string info,string question,Answer Answer1, Answer Answer2, Answer Answer3)
        {
            Information = info;
            Question = question;
            this.Answer1 = Answer1;
            this.Answer2 = Answer2;
            this.Answer3 = Answer3;
        }
    }
}
