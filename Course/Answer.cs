using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public class Answer//класс для ответов
    {
        public string Key { get; set; }
        public bool Correct { get; set; }
        
        public Answer(string answer,bool correct)
        {
            Key = answer;
            Correct = correct;
        } 
    }
}
