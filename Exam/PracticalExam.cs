using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class PracticalExam:BaseExam
    {
        public PracticalExam(int _Time , int _NumOfQuestions)
        {
            Time=Time;
            NumberOfQuestion=_NumOfQuestions;
        }


        public override void CreateExam()
        {
            QuestionArr=new Question[NumberOfQuestion];
            for(int i=0;i<QuestionArr.Length;i++)
            {
                Console.WriteLine($"(Qestion{i+1})");
                QuestionArr[i]=new MCQ();
                QuestionArr[i].ShowQuestion();
            }
        }

        public override void ShowExam()
        {  
            if (QuestionArr?.Length > 0)
            {

                for (int i = 0; i < QuestionArr.Length; i++)
                {
                    Console.WriteLine($"{QuestionArr[i].Header}");
                    Console.WriteLine(QuestionArr[i].Body);

                    for(int j = 0; j < QuestionArr[i].AnswersList.Length; j++)
                    {
                        Console.Write($"{j+1}-{QuestionArr[i].AnswersList[j]}         ");
                    }
                    Console.WriteLine("\n-----------------------------------------------");

                    int ansId;
                    bool validAns;
                    do
                    {
                        validAns=int.TryParse(Console.ReadLine(),out  ansId);
                    }while( !validAns || !(ansId is 1 or 2 or 3) );

                }

                Console.Clear();
                Console.WriteLine("Right Answers");

                for (int i=0;i<QuestionArr.Length;i++)
                {
                    Console.WriteLine($"Q{i+1})  {QuestionArr[i].Body} : {QuestionArr[i].correctAnswer}");
                }
            }
        }
    }
}
