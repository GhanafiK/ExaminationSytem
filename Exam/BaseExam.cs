using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal abstract class BaseExam
    {
        public int Time { get; set; }
        public int NumberOfQuestion { get; set; }
        public Question[] QuestionArr { get; set; }

        public abstract void CreateExam();
        public abstract void ShowExam();
    }
}
