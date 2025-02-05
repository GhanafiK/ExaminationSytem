using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Subject
    {
        public int SubId { get; set; }
        public string SubName { get; set; }
        public BaseExam Exam { get; set; }

        public Subject(int subId, string subName)
        {
            SubId = subId;
            SubName = subName;
        }

        public void CreateExam()
        {
            bool ExamTypeFlag;
            int ExamType;
            do
            {
                Console.Write("Please Enter The Type Of THe Exam U Want To Create (1 for Practical , 2 for Final): ");
                ExamTypeFlag = int.TryParse(Console.ReadLine(), out ExamType);
            } while (!ExamTypeFlag || !(ExamType is 1 or 2));

            bool TimeFlag;
            int ExamTime;
            do
            {
                Console.Write("Please Enter The Time Of Exam in Minutes: ");
                TimeFlag = int.TryParse(Console.ReadLine(), out ExamTime);
            } while (!TimeFlag || ExamTime <= 0);

            bool NumOfQFlag;
            int NumberOfQuestion;
            do
            {
                Console.Write("Please Enter The Number Of Questions U Wanted To Create: ");
                NumOfQFlag=int.TryParse(Console.ReadLine(),out NumberOfQuestion);
            }while(!NumOfQFlag || NumberOfQuestion <= 0);

            if (ExamType == 1)
                Exam = new PracticalExam(ExamTime, NumberOfQuestion);
            else
                Exam = new FinalExam(ExamTime, NumberOfQuestion);

            Console.Clear();
            Exam.CreateExamQuestions();

        }


    }
}
