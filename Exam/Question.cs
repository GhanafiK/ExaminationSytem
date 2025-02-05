using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal abstract class Question
    {
        public  string Header { get; set; }
        public string Body { get; set; }
        public int mark { get; set; }
        public Answer[] AnswersList { get; set; }
        public Answer correctAnswer { get; set; }

        public abstract void ShowQuestion();
        public override string ToString()
        {
            return $"{Header}\n{Body}";
        }
    }
}
