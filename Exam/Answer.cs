using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Answer
    {
        public int AnsId { get; set; }
        public string AnsText { get; set; }

        public Answer() { }
        public Answer(int ansId, string ansText)
        {
            AnsId = ansId;
            AnsText = ansText;
        }
        public override string ToString()
        {
            return $"{AnsText}";
        }
    }
}
